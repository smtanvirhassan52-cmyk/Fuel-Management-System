namespace FuelMS.Forms;

partial class SettingsPanel
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private System.Windows.Forms.Label lblTitle = null!;
    private System.Windows.Forms.Panel cardPassword = null!;
    private System.Windows.Forms.Label lblPasswordTitle = null!;
    private System.Windows.Forms.Label lblOld = null!;
    private System.Windows.Forms.TextBox txtOld = null!;
    private System.Windows.Forms.Label lblNew = null!;
    private System.Windows.Forms.TextBox txtNew = null!;
    private System.Windows.Forms.Label lblConf = null!;
    private System.Windows.Forms.TextBox txtConf = null!;
    private System.Windows.Forms.Label lblErr = null!;
    private System.Windows.Forms.Button btnUpdatePassword = null!;
    private System.Windows.Forms.Panel cardInfo = null!;
    private System.Windows.Forms.Label lblInfoTitle = null!;
    private System.Windows.Forms.Label lblDbPath = null!;
    private System.Windows.Forms.Label lblAppVersion = null!;

    private void InitializeComponent()
    {
        lblTitle = new Label();
        cardPassword = new Panel();
        lblPasswordTitle = new Label();
        lblOld = new Label();
        txtOld = new TextBox();
        lblNew = new Label();
        txtNew = new TextBox();
        lblConf = new Label();
        txtConf = new TextBox();
        lblErr = new Label();
        btnUpdatePassword = new Button();
        cardInfo = new Panel();
        lblInfoTitle = new Label();
        lblDbPath = new Label();
        lblAppVersion = new Label();
        cardPassword.SuspendLayout();
        cardInfo.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(261, 46);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "System Settings";
        // 
        // cardPassword
        // 
        cardPassword.BackColor = Color.FromArgb(30, 40, 58);
        cardPassword.Controls.Add(lblPasswordTitle);
        cardPassword.Controls.Add(lblOld);
        cardPassword.Controls.Add(txtOld);
        cardPassword.Controls.Add(lblNew);
        cardPassword.Controls.Add(txtNew);
        cardPassword.Controls.Add(lblConf);
        cardPassword.Controls.Add(txtConf);
        cardPassword.Controls.Add(lblErr);
        cardPassword.Controls.Add(btnUpdatePassword);
        cardPassword.Location = new Point(0, 60);
        cardPassword.Name = "cardPassword";
        cardPassword.Padding = new Padding(15);
        cardPassword.Size = new Size(500, 320);
        cardPassword.TabIndex = 1;
        // 
        // lblPasswordTitle
        // 
        lblPasswordTitle.AutoSize = true;
        lblPasswordTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblPasswordTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblPasswordTitle.Location = new Point(15, 12);
        lblPasswordTitle.Name = "lblPasswordTitle";
        lblPasswordTitle.Size = new Size(238, 30);
        lblPasswordTitle.TabIndex = 0;
        lblPasswordTitle.Text = "Change My Password";
        // 
        // lblOld
        // 
        lblOld.AutoSize = true;
        lblOld.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
        lblOld.ForeColor = Color.FromArgb(130, 150, 180);
        lblOld.Location = new Point(15, 55);
        lblOld.Name = "lblOld";
        lblOld.Size = new Size(146, 17);
        lblOld.TabIndex = 1;
        lblOld.Text = "CURRENT PASSWORD";
        // 
        // txtOld
        // 
        txtOld.BackColor = Color.FromArgb(20, 28, 42);
        txtOld.BorderStyle = BorderStyle.FixedSingle;
        txtOld.Font = new Font("Segoe UI", 9.5F);
        txtOld.ForeColor = Color.FromArgb(230, 240, 255);
        txtOld.Location = new Point(15, 73);
        txtOld.Name = "txtOld";
        txtOld.PasswordChar = '●';
        txtOld.Size = new Size(450, 29);
        txtOld.TabIndex = 2;
        // 
        // lblNew
        // 
        lblNew.AutoSize = true;
        lblNew.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
        lblNew.ForeColor = Color.FromArgb(130, 150, 180);
        lblNew.Location = new Point(15, 118);
        lblNew.Name = "lblNew";
        lblNew.Size = new Size(128, 17);
        lblNew.TabIndex = 3;
        lblNew.Text = "NEW PASSWORD";
        // 
        // txtNew
        // 
        txtNew.BackColor = Color.FromArgb(20, 28, 42);
        txtNew.BorderStyle = BorderStyle.FixedSingle;
        txtNew.Font = new Font("Segoe UI", 9.5F);
        txtNew.ForeColor = Color.FromArgb(230, 240, 255);
        txtNew.Location = new Point(15, 136);
        txtNew.Name = "txtNew";
        txtNew.PasswordChar = '●';
        txtNew.Size = new Size(450, 29);
        txtNew.TabIndex = 4;
        // 
        // lblConf
        // 
        lblConf.AutoSize = true;
        lblConf.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
        lblConf.ForeColor = Color.FromArgb(130, 150, 180);
        lblConf.Location = new Point(15, 178);
        lblConf.Name = "lblConf";
        lblConf.Size = new Size(158, 17);
        lblConf.TabIndex = 5;
        lblConf.Text = "CONFIRM PASSWORD";
        // 
        // txtConf
        // 
        txtConf.BackColor = Color.FromArgb(20, 28, 42);
        txtConf.BorderStyle = BorderStyle.FixedSingle;
        txtConf.Font = new Font("Segoe UI", 9.5F);
        txtConf.ForeColor = Color.FromArgb(230, 240, 255);
        txtConf.Location = new Point(15, 196);
        txtConf.Name = "txtConf";
        txtConf.PasswordChar = '●';
        txtConf.Size = new Size(450, 29);
        txtConf.TabIndex = 6;
        // 
        // lblErr
        // 
        lblErr.AutoSize = true;
        lblErr.Font = new Font("Segoe UI", 8.5F);
        lblErr.ForeColor = Color.FromArgb(220, 53, 69);
        lblErr.Location = new Point(15, 238);
        lblErr.Name = "lblErr";
        lblErr.Size = new Size(0, 19);
        lblErr.TabIndex = 7;
        // 
        // btnUpdatePassword
        // 
        btnUpdatePassword.BackColor = Color.FromArgb(40, 200, 120);
        btnUpdatePassword.Cursor = Cursors.Hand;
        btnUpdatePassword.FlatAppearance.BorderSize = 0;
        btnUpdatePassword.FlatStyle = FlatStyle.Flat;
        btnUpdatePassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnUpdatePassword.ForeColor = Color.White;
        btnUpdatePassword.Location = new Point(15, 260);
        btnUpdatePassword.Name = "btnUpdatePassword";
        btnUpdatePassword.Size = new Size(450, 42);
        btnUpdatePassword.TabIndex = 8;
        btnUpdatePassword.Text = "UPDATE PASSWORD";
        btnUpdatePassword.UseVisualStyleBackColor = false;
        btnUpdatePassword.Click += btnUpdatePassword_Click;
        // 
        // cardInfo
        // 
        cardInfo.BackColor = Color.FromArgb(30, 40, 58);
        cardInfo.Controls.Add(lblInfoTitle);
        cardInfo.Controls.Add(lblDbPath);
        cardInfo.Controls.Add(lblAppVersion);
        cardInfo.Location = new Point(0, 400);
        cardInfo.Name = "cardInfo";
        cardInfo.Padding = new Padding(15);
        cardInfo.Size = new Size(500, 120);
        cardInfo.TabIndex = 2;
        // 
        // lblInfoTitle
        // 
        lblInfoTitle.AutoSize = true;
        lblInfoTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblInfoTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblInfoTitle.Location = new Point(15, 12);
        lblInfoTitle.Name = "lblInfoTitle";
        lblInfoTitle.Size = new Size(159, 30);
        lblInfoTitle.TabIndex = 0;
        lblInfoTitle.Text = "Database Info";
        // 
        // lblDbPath
        // 
        lblDbPath.AutoSize = true;
        lblDbPath.Font = new Font("Segoe UI", 8.5F);
        lblDbPath.ForeColor = Color.FromArgb(130, 150, 180);
        lblDbPath.Location = new Point(15, 50);
        lblDbPath.Name = "lblDbPath";
        lblDbPath.Size = new Size(101, 19);
        lblDbPath.TabIndex = 1;
        lblDbPath.Text = "Database: -";
        // 
        // lblAppVersion
        // 
        lblAppVersion.AutoSize = true;
        lblAppVersion.Font = new Font("Segoe UI", 8.5F);
        lblAppVersion.ForeColor = Color.FromArgb(130, 150, 180);
        lblAppVersion.Location = new Point(15, 75);
        lblAppVersion.Name = "lblAppVersion";
        lblAppVersion.Size = new Size(243, 19);
        lblAppVersion.TabIndex = 2;
        lblAppVersion.Text = "App Version: 1.0.0  |  .NET 8  |  SQLite";
        // 
        // SettingsPanel
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 20, 30);
        Controls.Add(lblTitle);
        Controls.Add(cardPassword);
        Controls.Add(cardInfo);
        Name = "SettingsPanel";
        Size = new Size(1000, 600);
        cardPassword.ResumeLayout(false);
        cardPassword.PerformLayout();
        cardInfo.ResumeLayout(false);
        cardInfo.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
