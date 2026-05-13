# ⛽ Fuel Management System (FuelMS)

A complete multi-role desktop application built in **C# .NET 8 WinForms** with **SQLite** database.

---

## 🚀 Quick Start

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8) (Windows)
- Visual Studio 2022 **or** VS Code with C# extension

### Build & Run
```bash
cd FuelMS
dotnet restore
dotnet run --project FuelMS/FuelMS.csproj
```

Or open `FuelMS.sln` in Visual Studio → Press **F5**

---

## 🔑 Default Login Credentials

| Role        | Email               | Password    |
|-------------|---------------------|-------------|
| Super Admin | admin@fuelms.com    | Admin@123   |
| Admin       | john@fuelms.com     | Admin@123   |
| Customer    | john@example.com    | User@123    |

> Database is auto-created at `%APPDATA%\FuelMS\fuelms.db` on first run.

---

## 📐 Architecture

```
FuelMS/
├── Program.cs                    # Entry point
├── Data/
│   └── Database.cs               # SQLite init, seed data, connection factory
├── Models/
│   └── Models.cs                 # User, Fuel, Order, Payment, Review, Log, Stats
├── Services/
│   ├── UserService.cs            # Auth, CRUD users
│   └── Services.cs               # Fuel, Order, Payment, Review, Log, Dashboard
├── Helpers/
│   └── Helpers.cs                # Session, UIHelper (colors, fonts, factory methods)
└── Forms/
    ├── LoginForm.cs              # Login screen
    ├── AuthForms.cs              # Register + Change Password
    ├── BaseDashboard.cs          # Sidebar shell (all roles inherit)
    ├── SuperAdminDashboard.cs    # Super Admin router
    ├── AdminDashboard.cs         # Admin router
    ├── CustomerDashboard.cs      # Customer router
    ├── DashboardViews.cs         # Stat cards + recent orders
    ├── UsersPanel.cs             # User/Admin CRUD
    ├── FuelPanel.cs              # Fuel CRUD + stock management
    ├── OrdersPanel.cs            # Orders + Place Order + Limit view
    └── OtherPanels.cs            # Payments, Reviews, Reports, Logs, Settings
```

---

## 🗄️ Database Schema

```sql
Roles        → RoleID, RoleName
Users        → UserID, Name, Email, PasswordHash, Phone, RoleID, LimitPerMonth, Status
Fuel         → FuelID, FuelName, PricePerLiter, Quantity, Status
Orders       → OrderID, UserID, FuelID, Quantity, TotalPrice, Status
Payments     → PaymentID, OrderID, UserID, Amount, PaymentMethod, Status
Reviews      → ReviewID, UserID, OrderID, Rating, Comment
ActivityLogs → LogID, UserID, Action, Details, LogDate, IPAddress
```

---

## 👥 Role Capabilities

### Super Admin
- Full access to all modules
- Manage Admins & Users (add/edit/deactivate)
- Fuel management (add/edit/stock)
- View & update ALL orders
- View all payments & reports
- View activity logs
- System settings

### Admin
- Manage users (not admins)
- Fuel stock management
- Approve/Reject orders
- Confirm payments
- View customer reviews
- Monthly sales reports

### Customer (User)
- View available fuel list & prices
- Place orders (with monthly limit enforcement)
- View own order history
- Cancel pending orders
- Make payments
- View monthly limit usage
- Submit reviews for completed orders

---

## ✅ Business Rules Implemented

1. **Monthly Limit**: System checks `SUM(orders this month)` before placing order
2. **Stock Deduction**: Fuel stock decreases automatically on order placement
3. **Stock Restore**: Cancelled orders restore fuel stock
4. **Auto Payment**: Payment record created automatically when order is Approved
5. **Password Hashing**: BCrypt with salt (via BCrypt.Net-Next)
6. **Duplicate Review**: One review per order per user enforced
7. **Soft Delete**: Users/Fuel marked inactive, not physically deleted
8. **Activity Logging**: All key actions logged with timestamp

---

## 🎨 UI Design

- **Dark industrial theme** with sidebar navigation
- Color-coded roles: Orange (SuperAdmin), Blue (Admin), Green (Customer)
- Progress bar for monthly fuel limit
- Stat cards on all dashboards
- Responsive DataGridViews with alternating rows

---

## 📦 NuGet Dependencies

| Package              | Purpose              |
|----------------------|----------------------|
| Microsoft.Data.Sqlite | SQLite database driver |
| BCrypt.Net-Next      | Secure password hashing |
