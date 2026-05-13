using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class FuelListView : UserControl
{
    public FuelListView()
    {
        InitializeComponent();
        LoadGrid();
    }

    private void btnRefresh_Click(object sender, EventArgs e) => LoadGrid();

    private void LoadGrid()
    {
        var fuels = FuelService.GetAll().Where(f => f.Status == "Available").ToList();
        grid.DataSource = fuels.Select(f => new
        {
            Name = f.FuelName,
            Price = $"৳{f.PricePerLiter:F2}/L",
            Stock = $"{f.Quantity}L",
            Status = f.Status
        }).ToList();
    }
}
