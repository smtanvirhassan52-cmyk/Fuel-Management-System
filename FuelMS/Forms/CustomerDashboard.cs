using System.ComponentModel;
using FuelMS.Helpers;

namespace FuelMS.Forms;

public partial class CustomerDashboard : BaseDashboard
{
    public CustomerDashboard()
    {
        menuItems = new()
        {
            ("🏠", "Dashboard",    "dashboard"),
            ("⛽", "Fuel List",    "fuel"),
            ("🛒", "Place Order",  "order"),
            ("📋", "Order History","orders"),
            ("💳", "Payments",     "payments"),
            ("📊", "My Limit",     "limit"),
            ("⭐", "Reviews",      "reviews"),
        };
        BuildShell("Customer", UIHelper.AccentGreen);
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
            "dashboard" => new CustomerDashboardView(),
            "fuel"      => new FuelListView(),
            "order"     => new PlaceOrderView(),
            "orders"    => new OrdersPanel(adminView: false),
            "payments"  => new PaymentsPanel(userOnly: true),
            "limit"     => new LimitView(),
            "reviews"   => new ReviewsPanel(userOnly: true),
            _           => new CustomerDashboardView()
        };
        LoadContent(view);
    }
}
