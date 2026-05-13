using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class PaymentsPanel : UserControl
{
    private bool userOnly;

    public PaymentsPanel(bool userOnly = false)
    {
        InitializeComponent();
        this.userOnly = userOnly;
        if (userOnly) lblTitle.Text = "My Payments";
        LoadGrid();
    }

    private void btnRefresh_Click(object sender, EventArgs e) => LoadGrid();

    private void LoadGrid()
    {
        int uid = userOnly ? Session.CurrentUser!.UserID : 0;
        var payments = PaymentService.GetPayments(uid);
        grid.DataSource = payments.Select(p => new
        {
            ID = p.PaymentID,
            OrderID = p.OrderID,
            User = p.UserName,
            Amount = $"৳{p.Amount:F2}",
            Method = p.PaymentMethod,
            Status = p.Status,
            Date = p.PaymentDate.ToString("dd-MM-yyyy HH:mm")
        }).ToList();

        if (userOnly && grid.Columns.Contains("User"))
        {
            grid.Columns["User"].Visible = false;
        }
    }
}
