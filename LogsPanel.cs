using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class LogsPanel : UserControl
{
    public LogsPanel()
    {
        InitializeComponent();
        LoadGrid();
    }

    private void btnRefresh_Click(object sender, EventArgs e) => LoadGrid();

    private void LoadGrid()
    {
        var logs = LogService.GetLogs(500);
        grid.DataSource = logs.Select(l => new
        {
            ID = l.LogID,
            User = l.UserName,
            Action = l.Action,
            Details = l.Details,
            Date = l.LogDate.ToString("dd-MM-yyyy HH:mm:ss"),
            IP = l.IPAddress
        }).ToList();
    }
}
