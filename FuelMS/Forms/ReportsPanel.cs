using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class ReportsPanel : UserControl
{
    public ReportsPanel()
    {
        InitializeComponent();
        LoadReport();
    }

    private void btnRefresh_Click(object sender, EventArgs e) => LoadReport();

    private void LoadReport()
    {
        var stats = DashboardService.GetStats();

        lblTotalOrdersValue.Text = stats.TotalOrders.ToString();
        lblRevenueValue.Text = $"৳{stats.TotalRevenue:N0}";
        lblPendingValue.Text = stats.PendingOrders.ToString();
        lblTodaySalesValue.Text = $"৳{stats.TodaySales:N0}";

        var orders = OrderService.GetOrders();
        var monthly = orders.GroupBy(o => o.CreatedAt.ToString("yyyy-MM"))
            .Select(g => new
            {
                Month = g.Key,
                Orders = g.Count(),
                TotalLiters = $"{g.Sum(o => o.Quantity)}L",
                Revenue = $"৳{g.Sum(o => o.TotalPrice):F2}",
                Approved = g.Count(o => o.Status == "Approved"),
                Cancelled = g.Count(o => o.Status == "Cancelled")
            }).OrderByDescending(x => x.Month).ToList();

        grid.DataSource = monthly;
    }
}
