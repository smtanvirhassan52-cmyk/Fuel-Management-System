using FuelMS.Helpers;
using FuelMS.Models;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class FuelEditDialog : Form
{
    private Fuel? existing;
    private TextBox txtName = null!, txtPrice = null!, txtQty = null!;
    private ComboBox cmbStatus = null!;

    public FuelEditDialog(Fuel? fuel)
    {
        InitializeComponent();
        existing = fuel;
        Text = fuel == null ? "Add Fuel" : "Edit Fuel";
        lblTitle.Text = Text;

        if (fuel != null) { txtName.Text = fuel.FuelName; txtPrice.Text = fuel.PricePerLiter.ToString(); txtQty.Text = fuel.Quantity.ToString(); cmbStatus.SelectedIndex = fuel.Status == "Available" ? 0 : 1; }
        else { cmbStatus.SelectedIndex = 0; txtQty.Text = "0"; }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtName.Text) || !decimal.TryParse(txtPrice.Text, out var price))
        { lblErr.Text = "Name and valid price required."; return; }
        decimal qty = decimal.TryParse(txtQty.Text, out var q) ? q : 0;
        var f = new Fuel { FuelName = txtName.Text.Trim(), PricePerLiter = price, Quantity = qty, Status = cmbStatus.SelectedItem?.ToString() ?? "Available" };
        if (existing == null) FuelService.Add(f);
        else { f.FuelID = existing.FuelID; FuelService.Update(f); }
        LogService.Log(Session.CurrentUser!.UserID, existing == null ? "AddFuel" : "EditFuel", $"{f.FuelName}");
        DialogResult = DialogResult.OK; Close();
    }
}
