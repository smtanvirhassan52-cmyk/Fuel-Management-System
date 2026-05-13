using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class DashboardView : UserControl
{
    public DashboardView()
    {
        InitializeComponent();
        LoadDashboard();
    }

    private void btnRefresh_Click(object sender, EventArgs e) => LoadDashboard();

    private void LoadDashboard()
    {
        var stats = DashboardService.GetStats();

        lblTotalUsersValue.Text = stats.TotalUsers.ToString();
        lblTotalAdminsValue.Text = stats.TotalAdmins.ToString();
        lblTotalOrdersValue.Text = stats.TotalOrders.ToString();
        lblRevenueValue.Text = $"৳{stats.TotalRevenue:N0}";
        lblPendingValue.Text = stats.PendingOrders.ToString();
        lblTodaySalesValue.Text = $"৳{stats.TodaySales:N0}";

        var orders = OrderService.GetOrders().Take(10).ToList();
        gridRecentOrders.DataSource = orders.Select(o => new
        {
            ID = o.OrderID,
            User = o.UserName,
            Fuel = o.FuelName,
            Qty = $"{o.Quantity}L",
            Total = $"৳{o.TotalPrice:F2}",
            Status = o.Status,
            Date = o.CreatedAt.ToString("dd-MM-yyyy")
        }).ToList();

        LoadFuelStock();
    }

    private void LoadFuelStock()
    {
        var fuels = FuelService.GetAll();
        int fy = 0;
        panelFuelStock.Controls.Clear();
        foreach (var f in fuels)
        {
            var fCard = new Panel
            {
                BackColor = Color.FromArgb(30, 40, 58),
                Location = new Point(0, fy),
                Size = new Size(240, 55),
            };
            Color c = f.FuelName.Contains("Petrol") ? Color.FromArgb(255, 140, 0) :
                      f.FuelName.Contains("Diesel") ? Color.FromArgb(0, 120, 215) : Color.FromArgb(40, 200, 120);
            fCard.Controls.Add(new Panel { Size = new Size(4, 55), BackColor = c, Location = new Point(0, 0) });
            fCard.Controls.Add(new Label { Text = f.FuelName, Font = new Font("Segoe UI", 9f, FontStyle.Bold), ForeColor = Color.FromArgb(230, 240, 255), Location = new Point(14, 8), AutoSize = true });
            fCard.Controls.Add(new Label { Text = $"{f.Quantity}L  |  ৳{f.PricePerLiter}/L", Font = new Font("Segoe UI", 8.5f), ForeColor = Color.FromArgb(130, 150, 180), Location = new Point(14, 30), AutoSize = true });
            panelFuelStock.Controls.Add(fCard);
            fy += 65;
        }
    }
}
