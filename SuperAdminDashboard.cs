using System.ComponentModel;
using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class SuperAdminDashboard : BaseDashboard
{
    public SuperAdminDashboard()
    {
        menuItems = new()
        {
            ("📊", "Dashboard",    "dashboard"),
            ("👥", "Manage Admins","admins"),
            ("👤", "Manage Users", "users"),
            ("⛽", "Fuel Mgmt",    "fuel"),
            ("📋", "Orders",       "orders"),
            ("💳", "Payments",     "payments"),
            ("📈", "Reports",      "reports"),
            ("⚙️", "System Settings","settings"),
            ("📝", "Activity Logs","logs"),
        };
        BuildShell("Super Admin", UIHelper.AccentOrange);
        if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
        {
            NavigateTo("dashboard");
            SetActiveMenu("dashboard");
        }
    }

    protected override void NavigateTo(string key)
    {
        Control view = key switch
        {
            "dashboard" => new DashboardView(),
            "admins"    => new UsersPanel(roleFilter: 2, title: "Manage Admins", canSetRole: false),
            "users"     => new UsersPanel(roleFilter: 3, title: "Manage Users", canSetRole: false),
            "fuel"      => new FuelPanel(),
            "orders"    => new OrdersPanel(adminView: true),
            "payments"  => new PaymentsPanel(),
            "reports"   => new ReportsPanel(),
            "settings"  => new SettingsPanel(),
            "logs"      => new LogsPanel(),
            _           => new DashboardView()
        };
        LoadContent(view);
    }
}
