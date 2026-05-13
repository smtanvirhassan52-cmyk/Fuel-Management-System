using Microsoft.Data.Sqlite;

namespace FuelMS.Data;

public static class Database
{
    private static string _connectionString = "";

    public static void Initialize()
    {
        string dbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "FuelMS", "fuelms.db");
        Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);
        _connectionString = $"Data Source={dbPath}";
        CreateTables();
        SeedData();
    }

    public static SqliteConnection GetConnection()
    {
        var conn = new SqliteConnection(_connectionString);
        conn.Open();
        return conn;
    }

    private static void CreateTables()
    {
        using var conn = GetConnection();
        var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            PRAGMA foreign_keys = ON;

            CREATE TABLE IF NOT EXISTS Roles (
                RoleID INTEGER PRIMARY KEY,
                RoleName TEXT NOT NULL
            );

            CREATE TABLE IF NOT EXISTS Users (
                UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Email TEXT UNIQUE NOT NULL,
                PasswordHash TEXT NOT NULL,
                Phone TEXT,
                RoleID INTEGER NOT NULL DEFAULT 3,
                LimitPerMonth REAL NOT NULL DEFAULT 100,
                Status TEXT NOT NULL DEFAULT 'Active',
                CreatedAt TEXT NOT NULL DEFAULT (datetime('now')),
                FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
            );

            CREATE TABLE IF NOT EXISTS Fuel (
                FuelID INTEGER PRIMARY KEY AUTOINCREMENT,
                FuelName TEXT NOT NULL,
                PricePerLiter REAL NOT NULL,
                Quantity REAL NOT NULL DEFAULT 0,
                Status TEXT NOT NULL DEFAULT 'Available',
                CreatedAt TEXT NOT NULL DEFAULT (datetime('now'))
            );

            CREATE TABLE IF NOT EXISTS Orders (
                OrderID INTEGER PRIMARY KEY AUTOINCREMENT,
                UserID INTEGER NOT NULL,
                FuelID INTEGER NOT NULL,
                Quantity REAL NOT NULL,
                TotalPrice REAL NOT NULL,
                Status TEXT NOT NULL DEFAULT 'Pending',
                CreatedAt TEXT NOT NULL DEFAULT (datetime('now')),
                FOREIGN KEY (UserID) REFERENCES Users(UserID),
                FOREIGN KEY (FuelID) REFERENCES Fuel(FuelID)
            );

            CREATE TABLE IF NOT EXISTS Payments (
                PaymentID INTEGER PRIMARY KEY AUTOINCREMENT,
                OrderID INTEGER NOT NULL,
                UserID INTEGER NOT NULL,
                Amount REAL NOT NULL,
                PaymentMethod TEXT NOT NULL DEFAULT 'Cash',
                Status TEXT NOT NULL DEFAULT 'Pending',
                PaymentDate TEXT NOT NULL DEFAULT (datetime('now')),
                FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
                FOREIGN KEY (UserID) REFERENCES Users(UserID)
            );

            CREATE TABLE IF NOT EXISTS Reviews (
                ReviewID INTEGER PRIMARY KEY AUTOINCREMENT,
                UserID INTEGER NOT NULL,
                OrderID INTEGER NOT NULL,
                Rating INTEGER NOT NULL CHECK(Rating BETWEEN 1 AND 5),
                Comment TEXT,
                ReviewDate TEXT NOT NULL DEFAULT (datetime('now')),
                FOREIGN KEY (UserID) REFERENCES Users(UserID),
                FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
            );

            CREATE TABLE IF NOT EXISTS ActivityLogs (
                LogID INTEGER PRIMARY KEY AUTOINCREMENT,
                UserID INTEGER NOT NULL,
                Action TEXT NOT NULL,
                Details TEXT,
                LogDate TEXT NOT NULL DEFAULT (datetime('now')),
                IPAddress TEXT DEFAULT '127.0.0.1',
                FOREIGN KEY (UserID) REFERENCES Users(UserID)
            );
        ";
        cmd.ExecuteNonQuery();
    }

    private static void SeedData()
    {
        using var conn = GetConnection();

        // Roles
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT COUNT(*) FROM Roles";
        long count = (long)(cmd.ExecuteScalar() ?? 0L);
        if (count == 0)
        {
            cmd.CommandText = @"
                INSERT INTO Roles VALUES (1,'SuperAdmin');
                INSERT INTO Roles VALUES (2,'Admin');
                INSERT INTO Roles VALUES (3,'User');
            ";
            cmd.ExecuteNonQuery();
        }

        // Super Admin
        cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE RoleID=1";
        count = (long)(cmd.ExecuteScalar() ?? 0L);
        if (count == 0)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword("Admin@123");
            cmd.CommandText = $@"
                INSERT INTO Users (Name,Email,PasswordHash,Phone,RoleID,LimitPerMonth,Status)
                VALUES ('Super Admin','admin@fuelms.com','{hash}','01700000000',1,9999,'Active');
            ";
            cmd.ExecuteNonQuery();
        }

        // Sample Admin
        cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE RoleID=2";
        count = (long)(cmd.ExecuteScalar() ?? 0L);
        if (count == 0)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword("Admin@123");
            cmd.CommandText = $@"
                INSERT INTO Users (Name,Email,PasswordHash,Phone,RoleID,LimitPerMonth,Status)
                VALUES ('John Admin','john@fuelms.com','{hash}','01711111111',2,9999,'Active');
            ";
            cmd.ExecuteNonQuery();
        }

        // Sample Customer
        cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE RoleID=3";
        count = (long)(cmd.ExecuteScalar() ?? 0L);
        if (count == 0)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword("User@123");
            cmd.CommandText = $@"
                INSERT INTO Users (Name,Email,PasswordHash,Phone,RoleID,LimitPerMonth,Status)
                VALUES ('John Doe','john@example.com','{hash}','01722222222',3,100,'Active');
            ";
            cmd.ExecuteNonQuery();
        }

        // Fuel types
        cmd.CommandText = "SELECT COUNT(*) FROM Fuel";
        count = (long)(cmd.ExecuteScalar() ?? 0L);
        if (count == 0)
        {
            cmd.CommandText = @"
                INSERT INTO Fuel (FuelName,PricePerLiter,Quantity,Status) VALUES ('Petrol',110.00,2500,'Available');
                INSERT INTO Fuel (FuelName,PricePerLiter,Quantity,Status) VALUES ('Diesel',100.00,2500,'Available');
                INSERT INTO Fuel (FuelName,PricePerLiter,Quantity,Status) VALUES ('Octane',130.00,800,'Available');
            ";
            cmd.ExecuteNonQuery();
        }
    }
}
