using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class BaseDashboard : Form
{
    protected Label lblUserName = null!;
    protected string activeMenu = "";
    protected Color sidebarColor;
    protected List<(string icon, string label, string key)> menuItems = new();

    protected BaseDashboard()
    {
        InitializeComponent();
    }

    protected virtual void NavigateTo(string key) { }

    protected void BuildShell(string role, Color accent)
    {
        if (DesignMode) return;

        sidebarColor = accent;
        Text = $"FuelMS — {role} Dashboard";
        Size = new Size(1200, 750);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = UIHelper.PrimaryBg;

        logo.Text = "⛽ FuelMS";
        roleLabel.Text = role.ToUpper();
        roleLabel.ForeColor = accent;

        lblUserName.Text = $"👤 {Session.CurrentUser?.Name ?? ""}";
        userRoleLabel.Text = Session.CurrentUser?.RoleName ?? "";

        BuildMenu();

        logoutBtn.Click += (s, e) => { LogService.Log(Session.CurrentUser!.UserID, "Logout", "User logged out"); Session.Logout(); Close(); };
    }

    private void BuildMenu()
    {
        menuContainer.Controls.Clear();
        foreach (var (icon, label, key) in menuItems)
        {
            CreateSidebarButton(icon, label, key);
        }
    }

    protected void CreateSidebarButton(string icon, string label, string key)
    {
        var btn = new Button
        {
            Text = $"  {icon}  {label}",
            Size = new Size(210, 42),
            BackColor = UIHelper.SecondaryBg,
            ForeColor = UIHelper.TextSecondary,
            FlatStyle = FlatStyle.Flat,
            Font = UIHelper.NormalFont,
            TextAlign = ContentAlignment.MiddleLeft,
            Cursor = Cursors.Hand,
            Tag = key,
            Padding = new Padding(8, 0, 0, 0)
        };
        btn.FlatAppearance.BorderSize = 0;
        btn.MouseEnter += (s, e) => { if (btn.Tag?.ToString() != activeMenu) btn.BackColor = Color.FromArgb(30, 40, 58); };
        btn.MouseLeave += (s, e) => { if (btn.Tag?.ToString() != activeMenu) btn.BackColor = UIHelper.SecondaryBg; };
        btn.Click += (s, e) => { NavigateTo(key); SetActiveMenu(key); };
        menuContainer.Controls.Add(btn);
    }

    protected void SetActiveMenu(string key)
    {
        activeMenu = key;
        foreach (Control c in GetAllControls(sidePanel))
        {
            if (c is Button b && b.Tag is string tag && menuItems.Any(m => m.key == tag))
            {
                b.BackColor = tag == key ? Color.FromArgb(30, 40, 58) : UIHelper.SecondaryBg;
                b.ForeColor = tag == key ? UIHelper.TextPrimary : UIHelper.TextSecondary;
            }
        }
    }

    private IEnumerable<Control> GetAllControls(Control root)
    {
        foreach (Control c in root.Controls)
        {
            yield return c;
            foreach (var sub in GetAllControls(c)) yield return sub;
        }
    }

    protected void LoadContent(Control ctrl)
    {
        contentPanel.Controls.Clear();
        ctrl.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(ctrl);
    }
}
