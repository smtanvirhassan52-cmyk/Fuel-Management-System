namespace FuelMS.Forms;

partial class BaseDashboard
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    protected System.Windows.Forms.Panel logoPanel = null!;
    protected System.Windows.Forms.Label logo = null!;
    protected System.Windows.Forms.Label roleLabel = null!;
    protected System.Windows.Forms.Panel userPanel = null!;
    protected System.Windows.Forms.Label userRoleLabel = null!;
    protected System.Windows.Forms.FlowLayoutPanel menuContainer = null!;
    protected System.Windows.Forms.Panel logoutPanel = null!;
    protected System.Windows.Forms.Button logoutBtn = null!;
    protected System.Windows.Forms.Panel sidePanel = null!;
    protected System.Windows.Forms.Panel contentPanel = null!;

    private void InitializeComponent()
    {
        this.sidePanel = new System.Windows.Forms.Panel();
        this.logoPanel = new System.Windows.Forms.Panel();
        this.logo = new System.Windows.Forms.Label();
        this.roleLabel = new System.Windows.Forms.Label();
        this.userPanel = new System.Windows.Forms.Panel();
        this.lblUserName = new System.Windows.Forms.Label();
        this.userRoleLabel = new System.Windows.Forms.Label();
        this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
        this.logoutPanel = new System.Windows.Forms.Panel();
        this.logoutBtn = new System.Windows.Forms.Button();
        this.contentPanel = new System.Windows.Forms.Panel();
        this.sidePanel.SuspendLayout();
        this.logoPanel.SuspendLayout();
        this.userPanel.SuspendLayout();
        this.logoutPanel.SuspendLayout();
        this.SuspendLayout();

        // sidePanel
        this.sidePanel.BackColor = System.Drawing.Color.FromArgb(22, 30, 44);
        this.sidePanel.Controls.Add(this.contentPanel);
        this.sidePanel.Controls.Add(this.menuContainer);
        this.sidePanel.Controls.Add(this.logoutPanel);
        this.sidePanel.Controls.Add(this.userPanel);
        this.sidePanel.Controls.Add(this.logoPanel);
        this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
        this.sidePanel.Location = new System.Drawing.Point(0, 0);
        this.sidePanel.Name = "sidePanel";
        this.sidePanel.Size = new System.Drawing.Size(210, 750);
        this.sidePanel.TabIndex = 0;

        // logoPanel
        this.logoPanel.BackColor = System.Drawing.Color.FromArgb(10, 15, 25);
        this.logoPanel.Controls.Add(this.logo);
        this.logoPanel.Controls.Add(this.roleLabel);
        this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
        this.logoPanel.Location = new System.Drawing.Point(0, 0);
        this.logoPanel.Name = "logoPanel";
        this.logoPanel.Size = new System.Drawing.Size(210, 80);
        this.logoPanel.TabIndex = 0;

        // logo
        this.logo.AutoSize = true;
        this.logo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.logo.ForeColor = System.Drawing.Color.FromArgb(255, 140, 0);
        this.logo.Location = new System.Drawing.Point(20, 18);
        this.logo.Name = "logo";
        this.logo.Text = "⛽ FuelMS";
        this.logo.TabIndex = 0;

        // roleLabel
        this.roleLabel.AutoSize = true;
        this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
        this.roleLabel.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
        this.roleLabel.Location = new System.Drawing.Point(22, 52);
        this.roleLabel.Name = "roleLabel";
        this.roleLabel.Text = "ROLE";
        this.roleLabel.TabIndex = 1;

        // userPanel
        this.userPanel.BackColor = System.Drawing.Color.FromArgb(18, 24, 36);
        this.userPanel.Controls.Add(this.lblUserName);
        this.userPanel.Controls.Add(this.userRoleLabel);
        this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
        this.userPanel.Location = new System.Drawing.Point(0, 80);
        this.userPanel.Name = "userPanel";
        this.userPanel.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
        this.userPanel.Size = new System.Drawing.Size(210, 60);
        this.userPanel.TabIndex = 1;

        // lblUserName
        this.lblUserName.AutoSize = true;
        this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
        this.lblUserName.Location = new System.Drawing.Point(15, 10);
        this.lblUserName.Name = "lblUserName";
        this.lblUserName.Text = "👤 User";
        this.lblUserName.TabIndex = 0;

        // userRoleLabel
        this.userRoleLabel.AutoSize = true;
        this.userRoleLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.userRoleLabel.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.userRoleLabel.Location = new System.Drawing.Point(15, 32);
        this.userRoleLabel.Name = "userRoleLabel";
        this.userRoleLabel.Text = "Role";
        this.userRoleLabel.TabIndex = 1;

        // menuContainer
        this.menuContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        this.menuContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        this.menuContainer.Location = new System.Drawing.Point(0, 140);
        this.menuContainer.Name = "menuContainer";
        this.menuContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
        this.menuContainer.Size = new System.Drawing.Size(210, 560);
        this.menuContainer.TabIndex = 2;
        this.menuContainer.BackColor = System.Drawing.Color.FromArgb(22, 30, 44);
        this.menuContainer.AutoScroll = true;

        // logoutPanel
        this.logoutPanel.BackColor = System.Drawing.Color.FromArgb(22, 30, 44);
        this.logoutPanel.Controls.Add(this.logoutBtn);
        this.logoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.logoutPanel.Location = new System.Drawing.Point(0, 700);
        this.logoutPanel.Name = "logoutPanel";
        this.logoutPanel.Size = new System.Drawing.Size(210, 50);
        this.logoutPanel.TabIndex = 3;

        // logoutBtn
        this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(60, 20, 20);
        this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Fill;
        this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
        this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
        this.logoutBtn.FlatAppearance.BorderSize = 0;
        this.logoutBtn.Location = new System.Drawing.Point(0, 0);
        this.logoutBtn.Name = "logoutBtn";
        this.logoutBtn.Size = new System.Drawing.Size(210, 50);
        this.logoutBtn.TabIndex = 0;
        this.logoutBtn.Text = "⏻  Logout";

        // contentPanel
        this.contentPanel.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.contentPanel.Location = new System.Drawing.Point(210, 0);
        this.contentPanel.Name = "contentPanel";
        this.contentPanel.Padding = new System.Windows.Forms.Padding(20);
        this.contentPanel.Size = new System.Drawing.Size(990, 750);
        this.contentPanel.TabIndex = 1;

        // BaseDashboard
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.ClientSize = new System.Drawing.Size(1200, 750);
        this.Controls.Add(this.contentPanel);
        this.Controls.Add(this.sidePanel);
        this.MinimumSize = new System.Drawing.Size(1000, 650);
        this.Name = "BaseDashboard";
        this.Text = "BaseDashboard";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.sidePanel.ResumeLayout(false);
        this.logoPanel.ResumeLayout(false);
        this.logoPanel.PerformLayout();
        this.userPanel.ResumeLayout(false);
        this.userPanel.PerformLayout();
        this.logoutPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}
