# ⛽ FuelMS — Fuel Management System

> **Course:** CSC2210 – Object Oriented Programming 2 | Spring 2025-2026  
> **Institution:** American International University–Bangladesh (AIUB)  
> **Department:** Computer Science, Faculty of Science and Technology  
> **Section:** EE | 
> **Supervised By:** Dr. Md. Iftekharul Mobin

---

## 👥 Team Members

| Name | Student ID |
|------|------------|
| S. M. Tanvir Hassan | 24-58617-2 |
| Kazi Sajidul Islam | 24-58645-2 |

---

## 📌 Project Overview

**FuelMS** (Fuel Management System) is a comprehensive **Windows desktop application** designed to automate and streamline fuel station operations. The system provides a **role-based management platform** that handles fuel inventory, customer orders, payments, and administrative tasks through an intuitive graphical user interface.

### Background

Traditional fuel station management often relies on manual processes or disconnected systems, leading to inefficiencies in inventory tracking, order processing, and customer management. FuelMS addresses these challenges by providing a **centralized digital solution** that integrates all aspects of fuel station operations.

---

## 🎯 Objectives

- Automate fuel inventory management with real-time stock tracking
- Provide role-based access control (Super Admin, Admin, Customer)
- Enable online fuel ordering for registered customers
- Track monthly fuel limits per customer
- Generate comprehensive reports and activity logs
- Facilitate digital payments and order approvals

---

## 📋 Case Study

In FuelMS, users can view available fuel types, place orders based on quantity, and make payments using cash or online methods. Each user is identified by user ID, name, email, phone number, and address. Each fuel type has a unique ID with information like name, price per liter, and available stock. The system automatically updates stock after each transaction. Orders are recorded with details such as order ID, user ID, fuel type, quantity, total price, and status (pending, approved, or rejected). Administrators manage fuel prices, update stock, approve orders, and generate reports. Users can also provide reviews and track their order history.

---

## ⚙️ Functionalities

### 👤 Customer
1. View available fuel types with price and quantity
2. Place an order by selecting fuel type and quantity
3. System calculates total price based on quantity and price per liter
4. Make payment for the order
5. View order status (Pending, Completed)
6. View order and payment history
7. Give rating and review for an order

### 🛠️ Admin
8. Add and manage fuel types (price, quantity, status)
9. Monitor and update order status
10. Track and manage payments
11. View and manage users

### 👑 Super Admin
12. Full control over all users and admins
13. Monitor overall system activities and data

### 🤖 System
14. Record activity logs of user actions
15. Automatically store date and time for orders, payments, and logs

---

## 🗄️ Database Schema

The system uses **SQLite** with the following tables:

### Tables Overview

| Table | Description |
|-------|-------------|
| `Roles` | Defines user roles (SuperAdmin, Admin, User) |
| `Users` | Stores user accounts with role and monthly limit |
| `Fuel` | Fuel types with price, quantity, and status |
| `Orders` | Customer fuel orders and their statuses |
| `Payments` | Payment records linked to orders |
| `Reviews` | Customer ratings and comments on orders |
| `ActivityLogs` | Audit trail of all user actions |

---

## 🧱 Table Creation Queries

### Roles Table
```sql
CREATE TABLE IF NOT EXISTS Roles (
    RoleID INTEGER PRIMARY KEY,
    RoleName TEXT NOT NULL
);
```

### Users Table
```sql
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
```

### Fuel Table
```sql
CREATE TABLE IF NOT EXISTS Fuel (
    FuelID INTEGER PRIMARY KEY AUTOINCREMENT,
    FuelName TEXT NOT NULL,
    PricePerLiter REAL NOT NULL,
    Quantity REAL NOT NULL DEFAULT 0,
    Status TEXT NOT NULL DEFAULT 'Available',
    CreatedAt TEXT NOT NULL DEFAULT (datetime('now'))
);
```

### Orders Table
```sql
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
```

### Payments Table
```sql
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
```

### Reviews Table
```sql
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
```

### ActivityLogs Table
```sql
CREATE TABLE IF NOT EXISTS ActivityLogs (
    LogID INTEGER PRIMARY KEY AUTOINCREMENT,
    UserID INTEGER NOT NULL,
    Action TEXT NOT NULL,
    Details TEXT,
    LogDate TEXT NOT NULL DEFAULT (datetime('now')),
    IPAddress TEXT DEFAULT '127.0.0.1',
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
```

---

## 🌱 Seed Data

### Default Roles
```sql
INSERT INTO Roles VALUES (1, 'SuperAdmin');
INSERT INTO Roles VALUES (2, 'Admin');
INSERT INTO Roles VALUES (3, 'User');
```

### Default Users
```sql
-- Super Admin
INSERT INTO Users (Name, Email, PasswordHash, Phone, RoleID, LimitPerMonth, Status)
VALUES ('Super Admin', 'admin@fuelms.com', '[hashed_password]', '01700000000', 1, 9999, 'Active');

-- Sample Admin
INSERT INTO Users (Name, Email, PasswordHash, Phone, RoleID, LimitPerMonth, Status)
VALUES ('John Admin', 'john@fuelms.com', '[hashed_password]', '01711111111', 2, 9999, 'Active');

-- Sample Customer
INSERT INTO Users (Name, Email, PasswordHash, Phone, RoleID, LimitPerMonth, Status)
VALUES ('John Doe', 'john@example.com', '[hashed_password]', '01722222222', 3, 100, 'Active');
```

### Default Fuel Types
```sql
INSERT INTO Fuel (FuelName, PricePerLiter, Quantity, Status) VALUES ('Petrol', 110.00, 2500, 'Available');
INSERT INTO Fuel (FuelName, PricePerLiter, Quantity, Status) VALUES ('Diesel', 100.00, 2500, 'Available');
INSERT INTO Fuel (FuelName, PricePerLiter, Quantity, Status) VALUES ('Octane', 130.00, 800, 'Available');
```

---

## 🔍 Key Database Queries

### Fuel Management
```sql
-- Get all fuel
SELECT * FROM Fuel ORDER BY FuelName;

-- Add new fuel
INSERT INTO Fuel (FuelName, PricePerLiter, Quantity, Status) VALUES (@n, @p, @q, @s);

-- Update fuel
UPDATE Fuel SET FuelName=@n, PricePerLiter=@p, Quantity=@q, Status=@s WHERE FuelID=@id;

-- Soft delete fuel
UPDATE Fuel SET Status='Unavailable' WHERE FuelID=@id;

-- Add stock
UPDATE Fuel SET Quantity = Quantity + @q WHERE FuelID=@id;
```

### Order Management
```sql
-- Place order (check stock → check monthly limit → insert order → deduct stock)
SELECT * FROM Fuel WHERE FuelID=@id AND Status='Available';
SELECT LimitPerMonth FROM Users WHERE UserID=@id;
SELECT COALESCE(SUM(o.Quantity), 0) FROM Orders o
WHERE o.UserID=@uid AND o.Status != 'Cancelled'
AND strftime('%Y-%m', o.CreatedAt) = strftime('%Y-%m', 'now');
INSERT INTO Orders (UserID, FuelID, Quantity, TotalPrice, Status) VALUES (@u, @f, @q, @t, 'Pending');
UPDATE Fuel SET Quantity = Quantity - @q WHERE FuelID=@id;

-- Get orders with user and fuel info
SELECT o.*, u.Name as UserName, f.FuelName
FROM Orders o
JOIN Users u ON o.UserID = u.UserID
JOIN Fuel f ON o.FuelID = f.FuelID
ORDER BY o.CreatedAt DESC;

-- Update order status
UPDATE Orders SET Status=@s WHERE OrderID=@id;
```

### Payment Management
```sql
-- Make payment
INSERT INTO Payments (OrderID, UserID, Amount, PaymentMethod, Status, PaymentDate)
VALUES (@oid, @uid, @amt, @mth, 'Completed', datetime('now'));

-- Approve order
UPDATE Orders SET Status='Approved' WHERE OrderID=@id AND Status='Pending';

-- Get payment history
SELECT p.*, u.Name as UserName
FROM Payments p
JOIN Users u ON p.UserID = u.UserID
ORDER BY p.PaymentDate DESC;
```

### Reviews
```sql
-- Add review (after duplicate check)
SELECT COUNT(*) FROM Reviews WHERE UserID=@u AND OrderID=@o;
INSERT INTO Reviews (UserID, OrderID, Rating, Comment) VALUES (@u, @o, @r, @c);

-- Get reviews
SELECT r.*, u.Name as UserName
FROM Reviews r
JOIN Users u ON r.UserID = u.UserID
ORDER BY r.ReviewDate DESC;
```

### Dashboard Statistics
```sql
SELECT
    (SELECT COUNT(*) FROM Users WHERE RoleID=3 AND Status='Active') AS TotalUsers,
    (SELECT COUNT(*) FROM Users WHERE RoleID IN (1,2) AND Status='Active') AS TotalAdmins,
    (SELECT COUNT(*) FROM Orders) AS TotalOrders,
    (SELECT COALESCE(SUM(Amount), 0) FROM Payments WHERE Status='Completed') AS TotalRevenue,
    (SELECT COUNT(*) FROM Orders WHERE Status='Pending') AS PendingOrders,
    (SELECT COALESCE(SUM(Amount), 0) FROM Payments
     WHERE Status='Completed' AND date(PaymentDate) = date('now')) AS TodaySales;
```

---

## 🔄 Application Screens (Transition Table)

The system includes the following UI screens:

- **Login** — Authentication for all user roles
- **Forgot Password** — Password recovery flow
- **Register New Account** — Customer self-registration
- **Customer Dashboard** — Order, payment, and review management
- **Admin Dashboard** — Fuel, order, user, and payment management
- **Super Admin Dashboard** — Full system control
- **Customer Order** — Fuel ordering interface
- **Customer Review** — Rating and review submission

---

## ✅ Conclusion

The Fuel Management System streamlines fuel-related processes by digitizing the entire workflow — from order placement to payment and reporting. Users can view fuel, place orders, make payments, and submit reviews, while admins manage fuel inventory, users, and transactions. The Super Admin maintains full control over the platform.

Overall, FuelMS reduces manual work, saves time, and improves accuracy, making it a reliable and effective solution for modern fuel station management.

---

*American International University–Bangladesh (AIUB) | Spring 2025-2026*
