namespace FuelMS.Models;

public enum PaymentMethodType
{
    Cash,
    bKash,
    Nagad,
    Rocket,
    BankTransfer
}

public class User
{
    public int UserID { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public string Phone { get; set; } = "";
    public int RoleID { get; set; }
    public string RoleName { get; set; } = "";
    public decimal LimitPerMonth { get; set; }
    public string Status { get; set; } = "Active";
    public DateTime CreatedAt { get; set; }
}

public class Fuel
{
    public int FuelID { get; set; }
    public string FuelName { get; set; } = "";
    public decimal PricePerLiter { get; set; }
    public decimal Quantity { get; set; }
    public string Status { get; set; } = "Available";
    public DateTime CreatedAt { get; set; }
}

public class Order
{
    public int OrderID { get; set; }
    public int UserID { get; set; }
    public string UserName { get; set; } = "";
    public int FuelID { get; set; }
    public string FuelName { get; set; } = "";
    public decimal Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public string Status { get; set; } = "Pending";
    public DateTime CreatedAt { get; set; }
}

public class Payment
{
    public int PaymentID { get; set; }
    public int OrderID { get; set; }
    public int UserID { get; set; }
    public string UserName { get; set; } = "";
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; } = "Cash";
    public string Status { get; set; } = "Pending";
    public DateTime PaymentDate { get; set; }
}

public class Review
{
    public int ReviewID { get; set; }
    public int UserID { get; set; }
    public string UserName { get; set; } = "";
    public int OrderID { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = "";
    public DateTime ReviewDate { get; set; }
}

public class ActivityLog
{
    public int LogID { get; set; }
    public int UserID { get; set; }
    public string UserName { get; set; } = "";
    public string Action { get; set; } = "";
    public string Details { get; set; } = "";
    public DateTime LogDate { get; set; }
    public string IPAddress { get; set; } = "127.0.0.1";
}

public class DashboardStats
{
    public int TotalUsers { get; set; }
    public int TotalAdmins { get; set; }
    public int TotalOrders { get; set; }
    public decimal TotalRevenue { get; set; }
    public int PendingOrders { get; set; }
    public decimal TodaySales { get; set; }
}
