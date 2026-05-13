namespace FuelMS.Forms;

partial class LimitView
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private System.Windows.Forms.Label lblTitle = null!;
    private System.Windows.Forms.Panel cardLimit = null!;
    private System.Windows.Forms.Label lblLimitTitle = null!;
    private System.Windows.Forms.Label lblLimit = null!;
    private System.Windows.Forms.Label lblUsed = null!;
    private System.Windows.Forms.Label lblRemaining = null!;
    private System.Windows.Forms.Label lblPercent = null!;
    private System.Windows.Forms.Panel barBg = null!;
    private System.Windows.Forms.Panel barFill = null!;

    private void InitializeComponent()
    {
        lblTitle = new Label();
        cardLimit = new Panel();
        lblLimitTitle = new Label();
        lblLimit = new Label();
        lblUsed = new Label();
        lblRemaining = new Label();
        lblPercent = new Label();
        barBg = new Panel();
        barFill = new Panel();
        cardLimit.SuspendLayout();
        barBg.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(306, 46);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "My Monthly Limit";
        // 
        // cardLimit
        // 
        cardLimit.BackColor = Color.FromArgb(30, 40, 58);
        cardLimit.Controls.Add(lblLimitTitle);
        cardLimit.Controls.Add(lblLimit);
        cardLimit.Controls.Add(lblUsed);
        cardLimit.Controls.Add(lblRemaining);
        cardLimit.Controls.Add(lblPercent);
        cardLimit.Controls.Add(barBg);
        cardLimit.Location = new Point(0, 50);
        cardLimit.Name = "cardLimit";
        cardLimit.Padding = new Padding(15);
        cardLimit.Size = new Size(480, 260);
        cardLimit.TabIndex = 1;
        // 
        // lblLimitTitle
        // 
        lblLimitTitle.AutoSize = true;
        lblLimitTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblLimitTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblLimitTitle.Location = new Point(15, 12);
        lblLimitTitle.Name = "lblLimitTitle";
        lblLimitTitle.Size = new Size(170, 30);
        lblLimitTitle.TabIndex = 0;
        lblLimitTitle.Text = "Monthly Usage";
        // 
        // lblLimit
        // 
        lblLimit.AutoSize = true;
        lblLimit.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblLimit.ForeColor = Color.FromArgb(230, 240, 255);
        lblLimit.Location = new Point(20, 50);
        lblLimit.Name = "lblLimit";
        lblLimit.Size = new Size(146, 32);
        lblLimit.TabIndex = 1;
        lblLimit.Text = "Limit:     0 L";
        // 
        // lblUsed
        // 
        lblUsed.AutoSize = true;
        lblUsed.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblUsed.ForeColor = Color.FromArgb(255, 140, 0);
        lblUsed.Location = new Point(20, 90);
        lblUsed.Name = "lblUsed";
        lblUsed.Size = new Size(152, 32);
        lblUsed.TabIndex = 2;
        lblUsed.Text = "Used:      0 L";
        // 
        // lblRemaining
        // 
        lblRemaining.AutoSize = true;
        lblRemaining.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblRemaining.ForeColor = Color.FromArgb(40, 200, 120);
        lblRemaining.Location = new Point(20, 130);
        lblRemaining.Name = "lblRemaining";
        lblRemaining.Size = new Size(183, 32);
        lblRemaining.TabIndex = 3;
        lblRemaining.Text = "Remaining: 0 L";
        // 
        // lblPercent
        // 
        lblPercent.AutoSize = true;
        lblPercent.Font = new Font("Segoe UI", 9.5F);
        lblPercent.ForeColor = Color.FromArgb(130, 150, 180);
        lblPercent.Location = new Point(20, 175);
        lblPercent.Name = "lblPercent";
        lblPercent.Size = new Size(148, 21);
        lblPercent.TabIndex = 4;
        lblPercent.Text = "0% used this month";
        // 
        // barBg
        // 
        barBg.BackColor = Color.FromArgb(45, 60, 85);
        barBg.Controls.Add(barFill);
        barBg.Location = new Point(20, 205);
        barBg.Name = "barBg";
        barBg.Size = new Size(430, 18);
        barBg.TabIndex = 5;
        // 
        // barFill
        // 
        barFill.BackColor = Color.FromArgb(40, 200, 120);
        barFill.Location = new Point(0, 0);
        barFill.Name = "barFill";
        barFill.Size = new Size(0, 18);
        barFill.TabIndex = 0;
        // 
        // LimitView
        // 
        BackColor = Color.FromArgb(15, 20, 30);
        Controls.Add(lblTitle);
        Controls.Add(cardLimit);
        Name = "LimitView";
        Size = new Size(1835, 623);
        cardLimit.ResumeLayout(false);
        cardLimit.PerformLayout();
        barBg.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }
}
