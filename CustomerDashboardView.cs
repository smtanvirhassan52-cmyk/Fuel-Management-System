using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class CustomerDashboardView : UserControl
{
    public CustomerDashboardView()
    {
        InitializeComponent();
        LoadDashboard();
    }

    private void btnRefresh_Click(object sender, EventArgs e) => LoadDashboard();
    private void btnPlaceOrder_Click(object sender, EventArgs e) => NavigateToPlaceOrder();
    private void btnOrderHistory_Click(object sender, EventArgs e) => NavigateToOrderHistory();

    private void NavigateToPlaceOrder()
    {
        var parent = FindForm();
        if (parent is CustomerDashboard dashboard)
        {
            dashboard.GetType().GetMethod("NavigateTo", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.Invoke(dashboard, new object[] { "order" });
        }
    }

    private void NavigateToOrderHistory()
    {
        var parent = FindForm();
        if (parent is CustomerDashboard dashboard)
        {
            dashboard.GetType().GetMethod("NavigateTo", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.Invoke(dashboard, new object[] { "orders" });
        }
    }

    private void LoadDashboard()
    {
        var user = Session.CurrentUser!;
        var (limit, used, remaining) = OrderService.GetUserLimit(user.UserID);

        lblWelcome.Text = $"Welcome, {user.Name}!";

        lblLimit.Text = $"Limit:     {limit}L";
        lblUsed.Text = $"Used:      {used}L";
        lblRemaining.Text = $"Remaining: {remaining}L";

        int pct = limit > 0 ? (int)((used / limit) * 100) : 0;
        int barWidth = Math.Max(0, Math.Min(300, (int)(300 * used / Math.Max(1, limit))));
        progressBarFill.Size = new Size(barWidth, 12);
        progressBarFill.BackColor = remaining < 20 ? Color.FromArgb(220, 53, 69) : Color.FromArgb(40, 200, 120);

        var myOrders = OrderService.GetOrders(userId: user.UserID).Take(10).ToList();
        gridMyOrders.DataSource = myOrders.Select(o => new
        {
            ID = o.OrderID,
            Fuel = o.FuelName,
            Qty = $"{o.Quantity}L",
            Total = $"৳{o.TotalPrice:F2}",
            Status = o.Status,
            Date = o.CreatedAt.ToString("dd-MM-yyyy")
        }).ToList();

        var last = myOrders.FirstOrDefault();
        if (last != null)
        {
            lblLastFuel.Text = $"Fuel:    {last.FuelName}";
            lblLastQty.Text = $"Qty:     {last.Quantity}L";
            lblLastAmount.Text = $"Amount:  ৳{last.TotalPrice:F2}";
            var statusColor = last.Status == "Approved" ? Color.FromArgb(40, 200, 120) : last.Status == "Pending" ? Color.FromArgb(255, 193, 7) : Color.FromArgb(220, 53, 69);
            lblLastStatus.ForeColor = statusColor;
            lblLastStatus.Text = $"Status:  {last.Status}";
            lblLastDate.Text = $"Date:    {last.CreatedAt:dd-MM-yyyy}";
            panelLastOrder.Visible = true;
        }
        else
        {
            panelLastOrder.Visible = false;
        }
    }
}
