using System.ComponentModel;
using FuelMS.Helpers;

namespace FuelMS.Forms;

public partial class AdminDashboard : BaseDashboard
{
    public AdminDashboard()
    {
        menuItems = new()
        {
            ("📊", "Dashboard",   "dashboard"),
            ("👥", "Users",       "users"),
            ("⛽", "Fuel Mgmt",   "fuel"),
            ("📋", "Orders",      "orders"),
            ("💳", "Payments",    "payments"),
            ("📈", "Reports",     "reports"),
            ("⭐", "Reviews",     "reviews"),
        };
        BuildShell("Admin", UIHelper.AccentBlue);
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
            "users"     => new UsersPanel(roleFilter: 3, title: "Manage Users", canSetRole: false),
            "fuel"      => new FuelPanel(),
            "orders"    => new OrdersPanel(adminView: true),
            "payments"  => new PaymentsPanel(),
            "reports"   => new ReportsPanel(),
            "reviews"   => new ReviewsPanel(),
            _           => new DashboardView()
        };
        LoadContent(view);
    }
}
