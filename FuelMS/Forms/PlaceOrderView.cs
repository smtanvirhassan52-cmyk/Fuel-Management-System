using FuelMS.Helpers;
using FuelMS.Models;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class PlaceOrderView : UserControl
{
    private List<Fuel> fuels = new();

    public PlaceOrderView()
    {
        InitializeComponent();
        LoadForm();
    }

    private void LoadForm()
    {
        var user = Session.CurrentUser!;
        var (limit, used, remaining) = OrderService.GetUserLimit(user.UserID);

        lblLimitInfo.Text = $"Monthly Limit: {limit}L  |  Used: {used}L  |  Remaining: {remaining}L";
        lblLimitInfo.ForeColor = remaining < 20 ? UIHelper.AccentRed : UIHelper.AccentGreen;

        fuels = FuelService.GetAll().Where(f => f.Status == "Available").ToList();
        cmbFuel.Items.Clear();
        foreach (var f in fuels) cmbFuel.Items.Add($"{f.FuelName}  —  ৳{f.PricePerLiter}/L  (Stock: {f.Quantity}L)");
        if (fuels.Count > 0) cmbFuel.SelectedIndex = 0;

        cmbPayment.Items.Clear();
        foreach (var m in PaymentService.GetPaymentMethods()) cmbPayment.Items.Add(m);
        cmbPayment.SelectedIndex = 0;

        txtQty.Text = "10";
        UpdateCalc(null, EventArgs.Empty);
        LoadPriceList();
    }

    private void LoadPriceList()
    {
        panelPriceList.Controls.Clear();
        int fy = 45;
        foreach (var f in fuels)
        {
            Color c = f.FuelName.Contains("Petrol") ? UIHelper.AccentOrange : f.FuelName.Contains("Diesel") ? UIHelper.AccentBlue : UIHelper.AccentGreen;
            var lblName = new Label { Text = f.FuelName, Font = UIHelper.LabelFont, ForeColor = c, Location = new Point(15, fy), AutoSize = true };
            var lblPrice = new Label { Text = $"৳{f.PricePerLiter}/L  |  {f.Quantity}L", Font = UIHelper.SmallFont, ForeColor = UIHelper.TextSecondary, Location = new Point(15, fy + 20), AutoSize = true };
            panelPriceList.Controls.Add(lblName);
            panelPriceList.Controls.Add(lblPrice);
            fy += 50;
        }
    }

    private void UpdateCalc(object? sender, EventArgs e)
    {
        if (cmbFuel.SelectedIndex < 0 || !decimal.TryParse(txtQty.Text, out decimal q)) return;
        decimal price = fuels[cmbFuel.SelectedIndex].PricePerLiter;
        lblCalc.Text = $"Total: ৳{(q * price):F2}";
    }

    private void cmbFuel_SelectedIndexChanged(object sender, EventArgs e) => UpdateCalc(sender, e);
    private void txtQty_TextChanged(object sender, EventArgs e) => UpdateCalc(sender, e);

    private void btnOrder_Click(object sender, EventArgs e)
    {
        lblErr.Text = ""; lblSuccess.Text = "";
        var user = Session.CurrentUser!;
        if (cmbFuel.SelectedIndex < 0) { lblErr.Text = "Select a fuel type."; return; }
        if (!decimal.TryParse(txtQty.Text, out decimal qty) || qty <= 0) { lblErr.Text = "Enter a valid quantity."; return; }

        var fuel = fuels[cmbFuel.SelectedIndex];
        var (ok, msg) = OrderService.PlaceOrder(user.UserID, fuel.FuelID, qty);
        if (ok)
        {
            string method = cmbPayment.SelectedItem?.ToString() ?? "Cash";
            var orders = OrderService.GetOrders(userId: user.UserID);
            var lastOrder = orders.FirstOrDefault();
            if (lastOrder != null)
            {
                PaymentService.MakePayment(lastOrder.OrderID, user.UserID, lastOrder.TotalPrice, method);
                PaymentService.ApproveOrder(lastOrder.OrderID);
            }
            lblSuccess.Text = msg + "\nPaid via " + method;
            txtQty.Text = "10";
            LoadForm();
        }
        else lblErr.Text = msg;
    }
}
