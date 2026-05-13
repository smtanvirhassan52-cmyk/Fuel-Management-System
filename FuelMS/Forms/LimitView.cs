using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class LimitView : UserControl
{
    public LimitView()
    {
        InitializeComponent();
        LoadView();
    }

    private void LoadView()
    {
        var user = Session.CurrentUser!;
        var (limit, used, remaining) = OrderService.GetUserLimit(user.UserID);
        int pct = limit > 0 ? (int)((used / limit) * 100) : 0;

        lblLimit.Text = $"Limit:     {limit} L";
        lblUsed.Text = $"Used:      {used} L";
        lblRemaining.Text = $"Remaining: {remaining} L";
        lblPercent.Text = $"{pct}% used this month";

        int barWidth = Math.Max(0, Math.Min(430, (int)(430 * used / Math.Max(1, limit))));
        barFill.Size = new Size(barWidth, 18);
        barFill.BackColor = remaining < 10 ? UIHelper.AccentRed : pct > 70 ? UIHelper.AccentOrange : UIHelper.AccentGreen;
    }
}
