using FuelMS.Helpers;
using FuelMS.Models;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class FuelPanel : UserControl
{
    public FuelPanel()
    {
        InitializeComponent();
        bool isAdmin = Session.CurrentUser?.RoleID <= 2;
        btnAdd.Visible = isAdmin;
        btnEdit.Visible = isAdmin;
        btnStock.Visible = isAdmin;
        btnDel.Visible = isAdmin;
        grid.Location = new Point(0, isAdmin ? 100 : 50);
        LoadGrid();
    }

    private void btnAdd_Click(object sender, EventArgs e) => OpenAddEdit(null);
    private void btnEdit_Click(object sender, EventArgs e) => OpenAddEdit(GetSelected());
    private void btnStock_Click(object sender, EventArgs e) => AddStock();
    private void btnDel_Click(object sender, EventArgs e) => DeleteSelected();
    private void btnRefresh_Click(object sender, EventArgs e) => LoadGrid();

    private void LoadGrid()
    {
        var fuels = FuelService.GetAll();
        grid.DataSource = fuels.Select(f => new
        {
            ID = f.FuelID,
            Name = f.FuelName,
            PricePerLiter = $"৳{f.PricePerLiter:F2}",
            Stock = $"{f.Quantity}L",
            Status = f.Status,
            Added = f.CreatedAt.ToString("dd-MM-yyyy")
        }).ToList();
    }

    private Fuel? GetSelected()
    {
        if (grid.SelectedRows.Count == 0) { MessageBox.Show("Select a row first."); return null; }
        int id = Convert.ToInt32(grid.SelectedRows[0].Cells["ID"].Value);
        return FuelService.GetAll().FirstOrDefault(f => f.FuelID == id);
    }

    private void OpenAddEdit(Fuel? fuel)
    {
        var dlg = new FuelEditDialog(fuel);
        if (dlg.ShowDialog() == DialogResult.OK) LoadGrid();
    }

    private void AddStock()
    {
        var fuel = GetSelected();
        if (fuel == null) return;

        var dlg = new Form
        {
            Text = "Add Stock",
            Size = new Size(320, 160),
            BackColor = Color.FromArgb(15, 20, 30),
            StartPosition = FormStartPosition.CenterParent,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            MaximizeBox = false
        };
        var card = new Panel { BackColor = Color.FromArgb(30, 40, 58), Dock = DockStyle.Fill, Padding = new Padding(20) };
        var lbl = new Label { Text = $"Add quantity (L) for {fuel.FuelName}:", Font = new Font("Segoe UI", 9.5f), ForeColor = Color.FromArgb(230, 240, 255), Location = new Point(15, 15), AutoSize = true };
        var txt = new TextBox { Location = new Point(15, 40), Size = new Size(260, 28), BackColor = Color.FromArgb(20, 28, 42), ForeColor = Color.FromArgb(230, 240, 255), Font = new Font("Segoe UI", 9.5f), BorderStyle = BorderStyle.FixedSingle, Text = "100" };
        var btn = new Button { Text = "ADD STOCK", BackColor = Color.FromArgb(255, 140, 0), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(15, 75), Size = new Size(260, 38), Cursor = Cursors.Hand };
        btn.FlatAppearance.BorderSize = 0;
        btn.Click += (s2, e2) =>
        {
            if (decimal.TryParse(txt.Text, out decimal qty) && qty > 0)
            {
                FuelService.UpdateStock(fuel.FuelID, qty);
                LogService.Log(Session.CurrentUser!.UserID, "AddStock", $"Added {qty}L to {fuel.FuelName}");
                LoadGrid();
                dlg.Close();
            }
        };
        card.Controls.AddRange(new Control[] { lbl, txt, btn });
        dlg.Controls.Add(card);
        dlg.ShowDialog();
    }

    private void DeleteSelected()
    {
        var fuel = GetSelected();
        if (fuel == null) return;
        if (MessageBox.Show($"Mark {fuel.FuelName} as unavailable?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            FuelService.Delete(fuel.FuelID);
            LoadGrid();
        }
    }
}
