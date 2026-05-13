using FuelMS.Data;
using FuelMS.Models;

namespace FuelMS.Services;

public static class UserService
{
    public static User? Login(string email, string password)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            SELECT u.*, r.RoleName FROM Users u 
            JOIN Roles r ON u.RoleID = r.RoleID 
            WHERE u.Email = @email AND u.Status = 'Active'";
        cmd.Parameters.AddWithValue("@email", email);
        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            string hash = reader["PasswordHash"].ToString()!;
            if (BCrypt.Net.BCrypt.Verify(password, hash))
            {
                return MapUser(reader);
            }
        }
        return null;
    }

    public static bool Register(string name, string email, string password, string phone)
    {
        if (EmailExists(email)) return false;
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        string hash = BCrypt.Net.BCrypt.HashPassword(password);
        cmd.CommandText = @"INSERT INTO Users (Name,Email,PasswordHash,Phone,RoleID,LimitPerMonth,Status)
                            VALUES (@n,@e,@h,@p,3,100,'Active')";
        cmd.Parameters.AddWithValue("@n", name);
        cmd.Parameters.AddWithValue("@e", email);
        cmd.Parameters.AddWithValue("@h", hash);
        cmd.Parameters.AddWithValue("@p", phone);
        return cmd.ExecuteNonQuery() > 0;
    }

    public static bool EmailExists(string email)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Email=@e";
        cmd.Parameters.AddWithValue("@e", email);
        return (long)(cmd.ExecuteScalar() ?? 0L) > 0;
    }

    public static List<User> GetAllUsers(int roleId = 0)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = roleId == 0
            ? "SELECT u.*, r.RoleName FROM Users u JOIN Roles r ON u.RoleID=r.RoleID ORDER BY u.CreatedAt DESC"
            : "SELECT u.*, r.RoleName FROM Users u JOIN Roles r ON u.RoleID=r.RoleID WHERE u.RoleID=@rid ORDER BY u.CreatedAt DESC";
        if (roleId > 0) cmd.Parameters.AddWithValue("@rid", roleId);
        using var reader = cmd.ExecuteReader();
        var list = new List<User>();
        while (reader.Read()) list.Add(MapUser(reader));
        return list;
    }

    public static bool AddUser(User u, string password)
    {
        if (EmailExists(u.Email)) return false;
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        string hash = BCrypt.Net.BCrypt.HashPassword(password);
        cmd.CommandText = @"INSERT INTO Users (Name,Email,PasswordHash,Phone,RoleID,LimitPerMonth,Status)
                            VALUES (@n,@e,@h,@p,@r,@l,@s)";
        cmd.Parameters.AddWithValue("@n", u.Name);
        cmd.Parameters.AddWithValue("@e", u.Email);
        cmd.Parameters.AddWithValue("@h", hash);
        cmd.Parameters.AddWithValue("@p", u.Phone);
        cmd.Parameters.AddWithValue("@r", u.RoleID);
        cmd.Parameters.AddWithValue("@l", u.LimitPerMonth);
        cmd.Parameters.AddWithValue("@s", u.Status);
        return cmd.ExecuteNonQuery() > 0;
    }

    public static bool UpdateUser(User u)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = @"UPDATE Users SET Name=@n,Email=@e,Phone=@p,RoleID=@r,LimitPerMonth=@l,Status=@s WHERE UserID=@id";
        cmd.Parameters.AddWithValue("@n", u.Name);
        cmd.Parameters.AddWithValue("@e", u.Email);
        cmd.Parameters.AddWithValue("@p", u.Phone);
        cmd.Parameters.AddWithValue("@r", u.RoleID);
        cmd.Parameters.AddWithValue("@l", u.LimitPerMonth);
        cmd.Parameters.AddWithValue("@s", u.Status);
        cmd.Parameters.AddWithValue("@id", u.UserID);
        return cmd.ExecuteNonQuery() > 0;
    }

    public static bool DeleteUser(int userId)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "UPDATE Users SET Status='Inactive' WHERE UserID=@id";
        cmd.Parameters.AddWithValue("@id", userId);
        return cmd.ExecuteNonQuery() > 0;
    }

    public static bool ChangePassword(int userId, string newPassword)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        string hash = BCrypt.Net.BCrypt.HashPassword(newPassword);
        cmd.CommandText = "UPDATE Users SET PasswordHash=@h WHERE UserID=@id";
        cmd.Parameters.AddWithValue("@h", hash);
        cmd.Parameters.AddWithValue("@id", userId);
        return cmd.ExecuteNonQuery() > 0;
    }

    public static User? GetUserById(int id)
    {
        using var conn = Database.GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT u.*, r.RoleName FROM Users u JOIN Roles r ON u.RoleID=r.RoleID WHERE u.UserID=@id";
        cmd.Parameters.AddWithValue("@id", id);
        using var reader = cmd.ExecuteReader();
        return reader.Read() ? MapUser(reader) : null;
    }

    private static User MapUser(Microsoft.Data.Sqlite.SqliteDataReader r) => new User
    {
        UserID = Convert.ToInt32(r["UserID"]),
        Name = r["Name"].ToString()!,
        Email = r["Email"].ToString()!,
        PasswordHash = r["PasswordHash"].ToString()!,
        Phone = r["Phone"]?.ToString() ?? "",
        RoleID = Convert.ToInt32(r["RoleID"]),
        RoleName = r["RoleName"]?.ToString() ?? "",
        LimitPerMonth = Convert.ToDecimal(r["LimitPerMonth"]),
        Status = r["Status"].ToString()!,
        CreatedAt = DateTime.Parse(r["CreatedAt"].ToString()!)
    };
}
