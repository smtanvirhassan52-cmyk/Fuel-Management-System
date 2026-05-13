using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class OrdersPanel : UserControl
{
    private DataGridView grid = null!;
    private bool adminView;

    public OrdersPanel(bool adminView = false)
    {
        InitializeComponent();
        this.adminView = adminView;
        ConfigureButtons();
        LoadGrid();
    }

    private void ConfigureButtons()
    {
        if (adminView)
        {
            lblTitle.Text = "All Orders";
            btnApprove.Visible = true;
            btnReject.Visible = true;
            btnCancelAdmin.Visible = true;
            btnCancelUser.Visible = false;
        }
        else
        {
            lblTitle.Text = "My Orders";
            btnApprove.Visible = false;
            btnReject.Visible = false;
            btnCancelAdmin.Visible = false;
            btnCancelUser.Visible = true;
        }
    }

    private void btnApprove_Click(object sender, EventArgs e) => ChangeOrderStatus("Approved");
    private void btnReject_Click(object sender, EventArgs e) => ChangeOrderStatus("Rejected");
    private void btnCancelAdmin_Click(object sender, EventArgs e) => ChangeOrderStatus("Cancelled");
    private void btnCancelUser_Click(object sender, EventArgs e) => ChangeOrderStatus("Cancelled");

    private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadGrid(cmbFilter.SelectedItem?.ToString() == "All" ? "" : cmbFilter.SelectedItem?.ToString() ?? "");
    }

    private void LoadGrid(string statusFilter = "")
    {
        int userId = adminView ? 0 : Session.CurrentUser!.UserID;
        var orders = OrderService.GetOrders(userId, statusFilter);
        grid.DataSource = orders.Select(o => new
        {
            ID = o.OrderID,
            User = o.UserName,
            Fuel = o.FuelName,
            Qty = $"{o.Quantity}L",
            Total = $"৳{o.TotalPrice:F2}",
            Status = o.Status,
            Paid = PaymentService.HasPayment(o.OrderID) ? "Yes" : "No",
            Date = o.CreatedAt.ToString("dd-MM-yyyy HH:mm")
        }).ToList();

        if (!adminView && grid.Rows.Count > 0)
        {
            grid.Columns["User"].Visible = false;
        }
    }

    private void ChangeOrderStatus(string status)
    {
        if (grid.SelectedRows.Count == 0) { MessageBox.Show("Select an order first."); return; }
        int id = Convert.ToInt32(grid.SelectedRows[0].Cells["ID"].Value);
        string curStatus = grid.SelectedRows[0].Cells["Status"].Value?.ToString() ?? "";
        if (curStatus == status) return;
        if (curStatus != "Pending" && !Session.CurrentUser!.RoleID.Equals(1))
        { MessageBox.Show("Only pending orders can be changed."); return; }

        OrderService.UpdateOrderStatus(id, status);
        LogService.Log(Session.CurrentUser!.UserID, $"Order{status}", $"OrderID: {id}");
        LoadGrid();
    }
}
