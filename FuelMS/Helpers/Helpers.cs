using FuelMS.Models;

namespace FuelMS.Helpers;

public static class Session
{
    public static User? CurrentUser { get; set; }

    public static bool IsLoggedIn => CurrentUser != null;
    public static bool IsSuperAdmin => CurrentUser?.RoleID == 1;
    public static bool IsAdmin => CurrentUser?.RoleID == 2;
    public static bool IsUser => CurrentUser?.RoleID == 3;

    public static void Logout() => CurrentUser = null;
}

public static class UIHelper
{
    // Dark industrial color scheme
    public static Color PrimaryBg = Color.FromArgb(15, 20, 30);
    public static Color SecondaryBg = Color.FromArgb(22, 30, 44);
    public static Color CardBg = Color.FromArgb(30, 40, 58);
    public static Color AccentBlue = Color.FromArgb(0, 120, 215);
    public static Color AccentGreen = Color.FromArgb(40, 200, 120);
    public static Color AccentOrange = Color.FromArgb(255, 140, 0);
    public static Color AccentRed = Color.FromArgb(220, 53, 69);
    public static Color AccentYellow = Color.FromArgb(255, 193, 7);
    public static Color TextPrimary = Color.FromArgb(230, 240, 255);
    public static Color TextSecondary = Color.FromArgb(130, 150, 180);
    public static Color BorderColor = Color.FromArgb(45, 60, 85);

    public static Font TitleFont = new Font("Segoe UI", 20, FontStyle.Bold);
    public static Font HeadingFont = new Font("Segoe UI", 13, FontStyle.Bold);
    public static Font NormalFont = new Font("Segoe UI", 9.5f);
    public static Font SmallFont = new Font("Segoe UI", 8.5f);
    public static Font LabelFont = new Font("Segoe UI", 9f, FontStyle.Bold);

    public static Button CreateButton(string text, Color backColor, int width = 120, int height = 36)
    {
        return new Button
        {
            Text = text,
            BackColor = backColor,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Font = LabelFont,
            Size = new Size(width, height),
            Cursor = Cursors.Hand,
            FlatAppearance = { BorderSize = 0 }
        };
    }

    public static Panel CreateCard(int x, int y, int w, int h, string title = "")
    {
        var panel = new Panel
        {
            Location = new Point(x, y),
            Size = new Size(w, h),
            BackColor = CardBg,
            Padding = new Padding(15)
        };
        if (!string.IsNullOrEmpty(title))
        {
            panel.Controls.Add(new Label
            {
                Text = title,
                Font = HeadingFont,
                ForeColor = TextPrimary,
                AutoSize = true,
                Location = new Point(15, 12)
            });
        }
        return panel;
    }

    public static DataGridView CreateGrid()
    {
        var grid = new DataGridView
        {
            BackgroundColor = CardBg,
            ForeColor = TextPrimary,
            GridColor = BorderColor,
            BorderStyle = BorderStyle.None,
            RowHeadersVisible = false,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            ReadOnly = true,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            Font = NormalFont,
            ColumnHeadersHeight = 36,
            RowTemplate = { Height = 30 },
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
        };
        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 28, 42);
        grid.ColumnHeadersDefaultCellStyle.ForeColor = TextSecondary;
        grid.ColumnHeadersDefaultCellStyle.Font = LabelFont;
        grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 28, 42);
        grid.DefaultCellStyle.BackColor = CardBg;
        grid.DefaultCellStyle.ForeColor = TextPrimary;
        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 80, 160);
        grid.DefaultCellStyle.SelectionForeColor = TextPrimary;
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 35, 52);
        return grid;
    }

    public static TextBox CreateTextBox(int x, int y, int w = 220)
    {
        return new TextBox
        {
            Location = new Point(x, y),
            Size = new Size(w, 28),
            BackColor = Color.FromArgb(20, 28, 42),
            ForeColor = TextPrimary,
            BorderStyle = BorderStyle.FixedSingle,
            Font = NormalFont
        };
    }

    public static Label CreateLabel(string text, int x, int y, Color? color = null)
    {
        return new Label
        {
            Text = text,
            Location = new Point(x, y),
            AutoSize = true,
            ForeColor = color ?? TextSecondary,
            Font = SmallFont
        };
    }

    public static Panel CreateStatCard(int x, int y, string title, string value, Color accent)
    {
        var card = new Panel
        {
            Location = new Point(x, y),
            Size = new Size(170, 90),
            BackColor = CardBg,
            Cursor = Cursors.Default
        };
        // Left accent bar
        var bar = new Panel { Location = new Point(0, 0), Size = new Size(4, 90), BackColor = accent };
        var lbl1 = new Label { Text = title.ToUpper(), Font = new Font("Segoe UI", 7.5f, FontStyle.Bold), ForeColor = TextSecondary, Location = new Point(14, 14), AutoSize = true };
        var lbl2 = new Label { Text = value, Font = new Font("Segoe UI", 18, FontStyle.Bold), ForeColor = accent, Location = new Point(14, 36), AutoSize = true };
        card.Controls.AddRange(new Control[] { bar, lbl1, lbl2 });
        return card;
    }
}
