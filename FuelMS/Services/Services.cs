using FuelMS.Data;
using FuelMS.Models;

namespace FuelMS.Services;

public static class FuelService
{
    public static List<Fuel> GetAll()
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM Fuel ORDER BY FuelName";
        using var r = cmd.ExecuteReader();
        var list = new List<Fuel>();
        while (r.Read()) list.Add(Map(r));
        return list;
    }

    public static bool Add(Fuel f)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO Fuel (FuelName,PricePerLiter,Quantity,Status) VALUES (@n,@p,@q,@s)";
        cmd.Parameters.AddWithValue("@n", f.FuelName);
        cmd.Parameters.AddWithValue("@p", f.PricePerLiter);
        cmd.Parameters.AddWithValue("@q", f.Quantity);
        cmd.Parameters.AddWithValue("@s", f.Status);
        return cmd.ExecuteNonQuery() > 0;
    }

    public static bool Update(Fuel f)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "UPDATE Fuel SET FuelName=@n,PricePerLiter=@p,Quantity=@q,Status=@s WHERE FuelID=@id";
        cmd.Parameters.AddWithValue("@n", f.FuelName);
        cmd.Parameters.AddWithValue("@p", f.PricePerLiter);
        cmd.Parameters.AddWithValue("@q", f.Quantity);
        cmd.Parameters.AddWithValue("@s", f.Status);
        cmd.Parameters.AddWithValue("@id", f.FuelID);
        return cmd.ExecuteNonQuery() > 0;
    }

    public static bool Delete(int id)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "UPDATE Fuel SET Status='Unavailable' WHERE FuelID=@id";
        cmd.Parameters.AddWithValue("@id", id);
        return cmd.ExecuteNonQuery() > 0;
    }

    public static bool UpdateStock(int fuelId, decimal addQty)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "UPDATE Fuel SET Quantity = Quantity + @q WHERE FuelID=@id";
        cmd.Parameters.AddWithValue("@q", addQty);
        cmd.Parameters.AddWithValue("@id", fuelId);
        return cmd.ExecuteNonQuery() > 0;
    }

    private static Fuel Map(Microsoft.Data.Sqlite.SqliteDataReader r) => new Fuel
    {
        FuelID = Convert.ToInt32(r["FuelID"]),
        FuelName = r["FuelName"].ToString()!,
        PricePerLiter = Convert.ToDecimal(r["PricePerLiter"]),
        Quantity = Convert.ToDecimal(r["Quantity"]),
        Status = r["Status"].ToString()!,
        CreatedAt = DateTime.Parse(r["CreatedAt"].ToString()!)
    };
}

public static class OrderService
{
    public static (bool success, string message) PlaceOrder(int userId, int fuelId, decimal quantity)
    {
        using var conn = Database.GetConnection();

        // Check fuel availability
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM Fuel WHERE FuelID=@id AND Status='Available'";
        cmd.Parameters.AddWithValue("@id", fuelId);
        using var fr = cmd.ExecuteReader();
        if (!fr.Read()) return (false, "Fuel not available.");
        decimal fuelQty = Convert.ToDecimal(fr["Quantity"]);
        decimal price = Convert.ToDecimal(fr["PricePerLiter"]);
        string fuelName = fr["FuelName"].ToString()!;
        fr.Close();

        if (quantity > fuelQty) return (false, $"Insufficient stock. Available: {fuelQty}L");

        // Check monthly limit
        var limitCmd = conn.CreateCommand();
        limitCmd.CommandText = "SELECT LimitPerMonth FROM Users WHERE UserID=@id";
        limitCmd.Parameters.AddWithValue("@id", userId);
        decimal limit = Convert.ToDecimal(limitCmd.ExecuteScalar() ?? 0m);

        var usedCmd = conn.CreateCommand();
        usedCmd.CommandText = @"SELECT COALESCE(SUM(o.Quantity),0) FROM Orders o 
                                WHERE o.UserID=@uid AND o.Status != 'Cancelled'
                                AND strftime('%Y-%m', o.CreatedAt) = strftime('%Y-%m', 'now')";
        usedCmd.Parameters.AddWithValue("@uid", userId);
        decimal used = Convert.ToDecimal(usedCmd.ExecuteScalar() ?? 0m);

        if (used + quantity > limit)
            return (false, $"Monthly limit exceeded. Limit: {limit}L, Used: {used}L, Remaining: {limit - used}L");

        decimal total = quantity * price;

        // Place order
        var orderCmd = conn.CreateCommand();
        orderCmd.CommandText = @"INSERT INTO Orders (UserID,FuelID,Quantity,TotalPrice,Status)
                                 VALUES (@u,@f,@q,@t,'Pending')";
        orderCmd.Parameters.AddWithValue("@u", userId);
        orderCmd.Parameters.AddWithValue("@f", fuelId);
        orderCmd.Parameters.AddWithValue("@q", quantity);
        orderCmd.Parameters.AddWithValue("@t", total);
        orderCmd.ExecuteNonQuery();

        // Deduct stock
        var stockCmd = conn.CreateCommand();
        stockCmd.CommandText = "UPDATE Fuel SET Quantity = Quantity - @q WHERE FuelID=@id";
        stockCmd.Parameters.AddWithValue("@q", quantity);
        stockCmd.Parameters.AddWithValue("@id", fuelId);
        stockCmd.ExecuteNonQuery();

        // Log
        LogService.Log(userId, "PlaceOrder", $"Ordered {quantity}L of {fuelName}, Total: ৳{total:F2}");

        return (true, $"Order placed! {quantity}L of {fuelName} for ৳{total:F2}");
    }

    public static List<Order> GetOrders(int userId = 0, string status = "")
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        string where = "WHERE 1=1";
        if (userId > 0) { where += " AND o.UserID=@uid"; cmd.Parameters.AddWithValue("@uid", userId); }
        if (!string.IsNullOrEmpty(status)) { where += " AND o.Status=@st"; cmd.Parameters.AddWithValue("@st", status); }
        cmd.CommandText = $@"SELECT o.*,u.Name as UserName,f.FuelName FROM Orders o 
                            JOIN Users u ON o.UserID=u.UserID 
                            JOIN Fuel f ON o.FuelID=f.FuelID 
                            {where} ORDER BY o.CreatedAt DESC";
        using var r = cmd.ExecuteReader();
        var list = new List<Order>();
        while (r.Read()) list.Add(new Order
        {
            OrderID = Convert.ToInt32(r["OrderID"]),
            UserID = Convert.ToInt32(r["UserID"]),
            UserName = r["UserName"].ToString()!,
            FuelID = Convert.ToInt32(r["FuelID"]),
            FuelName = r["FuelName"].ToString()!,
            Quantity = Convert.ToDecimal(r["Quantity"]),
            TotalPrice = Convert.ToDecimal(r["TotalPrice"]),
            Status = r["Status"].ToString()!,
            CreatedAt = DateTime.Parse(r["CreatedAt"].ToString()!)
        });
        return list;
    }

    public static bool UpdateOrderStatus(int orderId, string status)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "UPDATE Orders SET Status=@s WHERE OrderID=@id";
        cmd.Parameters.AddWithValue("@s", status);
        cmd.Parameters.AddWithValue("@id", orderId);

        // If cancelled, restore stock
        if (status == "Cancelled")
        {
            var getCmd = conn.CreateCommand();
            getCmd.CommandText = "SELECT FuelID, Quantity FROM Orders WHERE OrderID=@id";
            getCmd.Parameters.AddWithValue("@id", orderId);
            using var r = getCmd.ExecuteReader();
            if (r.Read())
            {
                int fuelId = Convert.ToInt32(r["FuelID"]);
                decimal qty = Convert.ToDecimal(r["Quantity"]);
                r.Close();
                var restoreCmd = conn.CreateCommand();
                restoreCmd.CommandText = "UPDATE Fuel SET Quantity=Quantity+@q WHERE FuelID=@fid";
                restoreCmd.Parameters.AddWithValue("@q", qty);
                restoreCmd.Parameters.AddWithValue("@fid", fuelId);
                restoreCmd.ExecuteNonQuery();
            }
        }

        return cmd.ExecuteNonQuery() > 0;
    }

    public static (decimal limit, decimal used, decimal remaining) GetUserLimit(int userId)
    {
        using var conn = Database.GetConnection();
        var lCmd = conn.CreateCommand();
        lCmd.CommandText = "SELECT LimitPerMonth FROM Users WHERE UserID=@id";
        lCmd.Parameters.AddWithValue("@id", userId);
        decimal limit = Convert.ToDecimal(lCmd.ExecuteScalar() ?? 100m);

        var uCmd = conn.CreateCommand();
        uCmd.CommandText = @"SELECT COALESCE(SUM(Quantity),0) FROM Orders 
                             WHERE UserID=@uid AND Status!='Cancelled'
                             AND strftime('%Y-%m', CreatedAt) = strftime('%Y-%m', 'now')";
        uCmd.Parameters.AddWithValue("@uid", userId);
        decimal used = Convert.ToDecimal(uCmd.ExecuteScalar() ?? 0m);

        return (limit, used, limit - used);
    }
}

public static class PaymentService
{
    public static List<string> GetPaymentMethods()
    {
        return new List<string> { "Cash", "bKash", "Nagad", "Rocket", "Bank Transfer" };
    }

    public static bool MakePayment(int orderId, int userId, decimal amount, string method)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = @"INSERT INTO Payments (OrderID,UserID,Amount,PaymentMethod,Status,PaymentDate)
                            VALUES (@oid,@uid,@amt,@mth,'Completed',datetime('now'))";
        cmd.Parameters.AddWithValue("@oid", orderId);
        cmd.Parameters.AddWithValue("@uid", userId);
        cmd.Parameters.AddWithValue("@amt", amount);
        cmd.Parameters.AddWithValue("@mth", method);
        return cmd.ExecuteNonQuery() > 0;
    }

    public static bool ApproveOrder(int orderId)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "UPDATE Orders SET Status='Approved' WHERE OrderID=@id AND Status='Pending'";
        cmd.Parameters.AddWithValue("@id", orderId);
        return cmd.ExecuteNonQuery() > 0;
    }

    public static List<Payment> GetPayments(int userId = 0)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        string where = userId > 0 ? "WHERE p.UserID=@uid" : "";
        if (userId > 0) cmd.Parameters.AddWithValue("@uid", userId);
        cmd.CommandText = $@"SELECT p.*,u.Name as UserName FROM Payments p 
                            JOIN Users u ON p.UserID=u.UserID {where} ORDER BY p.PaymentDate DESC";
        using var r = cmd.ExecuteReader();
        var list = new List<Payment>();
        while (r.Read()) list.Add(new Payment
        {
            PaymentID = Convert.ToInt32(r["PaymentID"]),
            OrderID = Convert.ToInt32(r["OrderID"]),
            UserID = Convert.ToInt32(r["UserID"]),
            UserName = r["UserName"].ToString()!,
            Amount = Convert.ToDecimal(r["Amount"]),
            PaymentMethod = r["PaymentMethod"].ToString()!,
            Status = r["Status"].ToString()!,
            PaymentDate = DateTime.Parse(r["PaymentDate"].ToString()!)
        });
        return list;
    }

    public static bool HasPayment(int orderId)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT COUNT(*) FROM Payments WHERE OrderID=@oid";
        cmd.Parameters.AddWithValue("@oid", orderId);
        return (long)(cmd.ExecuteScalar() ?? 0L) > 0;
    }
}

public static class ReviewService
{
    public static bool AddReview(int userId, int orderId, int rating, string comment)
    {
        using var conn = Database.GetConnection();
        // prevent duplicate
        var chk = conn.CreateCommand();
        chk.CommandText = "SELECT COUNT(*) FROM Reviews WHERE UserID=@u AND OrderID=@o";
        chk.Parameters.AddWithValue("@u", userId);
        chk.Parameters.AddWithValue("@o", orderId);
        if ((long)(chk.ExecuteScalar() ?? 0L) > 0) return false;

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"INSERT INTO Reviews (UserID,OrderID,Rating,Comment) VALUES (@u,@o,@r,@c)";
        cmd.Parameters.AddWithValue("@u", userId);
        cmd.Parameters.AddWithValue("@o", orderId);
        cmd.Parameters.AddWithValue("@r", rating);
        cmd.Parameters.AddWithValue("@c", comment);
        return cmd.ExecuteNonQuery() > 0;
    }

    public static List<Review> GetReviews(int userId = 0)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        string where = userId > 0 ? "WHERE r.UserID=@uid" : "";
        if (userId > 0) cmd.Parameters.AddWithValue("@uid", userId);
        cmd.CommandText = $@"SELECT r.*,u.Name as UserName FROM Reviews r 
                            JOIN Users u ON r.UserID=u.UserID {where} ORDER BY r.ReviewDate DESC";
        using var rd = cmd.ExecuteReader();
        var list = new List<Review>();
        while (rd.Read()) list.Add(new Review
        {
            ReviewID = Convert.ToInt32(rd["ReviewID"]),
            UserID = Convert.ToInt32(rd["UserID"]),
            UserName = rd["UserName"].ToString()!,
            OrderID = Convert.ToInt32(rd["OrderID"]),
            Rating = Convert.ToInt32(rd["Rating"]),
            Comment = rd["Comment"]?.ToString() ?? "",
            ReviewDate = DateTime.Parse(rd["ReviewDate"].ToString()!)
        });
        return list;
    }

    public static List<int> GetReviewedOrderIds(int userId)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT OrderID FROM Reviews WHERE UserID=@uid";
        cmd.Parameters.AddWithValue("@uid", userId);
        var ids = new List<int>();
        using var r = cmd.ExecuteReader();
        while (r.Read()) ids.Add(Convert.ToInt32(r["OrderID"]));
        return ids;
    }
}

public static class LogService
{
    public static void Log(int userId, string action, string details)
    {
        try
        {
            using var conn = Database.GetConnection();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO ActivityLogs (UserID,Action,Details) VALUES (@u,@a,@d)";
            cmd.Parameters.AddWithValue("@u", userId);
            cmd.Parameters.AddWithValue("@a", action);
            cmd.Parameters.AddWithValue("@d", details);
            cmd.ExecuteNonQuery();
        }
        catch { /* non-critical */ }
    }

    public static List<ActivityLog> GetLogs(int limit = 200)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = $@"SELECT l.*,u.Name as UserName FROM ActivityLogs l 
                            JOIN Users u ON l.UserID=u.UserID 
                            ORDER BY l.LogDate DESC LIMIT {limit}";
        using var r = cmd.ExecuteReader();
        var list = new List<ActivityLog>();
        while (r.Read()) list.Add(new ActivityLog
        {
            LogID = Convert.ToInt32(r["LogID"]),
            UserID = Convert.ToInt32(r["UserID"]),
            UserName = r["UserName"].ToString()!,
            Action = r["Action"].ToString()!,
            Details = r["Details"]?.ToString() ?? "",
            LogDate = DateTime.Parse(r["LogDate"].ToString()!),
            IPAddress = r["IPAddress"]?.ToString() ?? ""
        });
        return list;
    }
}

public static class DashboardService
{
    public static DashboardStats GetStats()
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            SELECT 
                (SELECT COUNT(*) FROM Users WHERE RoleID=3 AND Status='Active') as TotalUsers,
                (SELECT COUNT(*) FROM Users WHERE RoleID IN(1,2) AND Status='Active') as TotalAdmins,
                (SELECT COUNT(*) FROM Orders) as TotalOrders,
                (SELECT COALESCE(SUM(Amount),0) FROM Payments WHERE Status='Completed') as TotalRevenue,
                (SELECT COUNT(*) FROM Orders WHERE Status='Pending') as PendingOrders,
                (SELECT COALESCE(SUM(Amount),0) FROM Payments WHERE Status='Completed' AND date(PaymentDate)=date('now')) as TodaySales";
        using var r = cmd.ExecuteReader();
        if (r.Read())
        {
            return new DashboardStats
            {
                TotalUsers = Convert.ToInt32(r["TotalUsers"]),
                TotalAdmins = Convert.ToInt32(r["TotalAdmins"]),
                TotalOrders = Convert.ToInt32(r["TotalOrders"]),
                TotalRevenue = Convert.ToDecimal(r["TotalRevenue"]),
                PendingOrders = Convert.ToInt32(r["PendingOrders"]),
                TodaySales = Convert.ToDecimal(r["TodaySales"])
            };
        }
        return new DashboardStats();
    }
}
