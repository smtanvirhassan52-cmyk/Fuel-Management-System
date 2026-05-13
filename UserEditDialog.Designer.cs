namespace FuelMS.Forms;

partial class UserEditDialog
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private System.Windows.Forms.Panel card = null!;
    private System.Windows.Forms.Label lblTitle = null!;
    private System.Windows.Forms.Label lblName = null!;
    protected System.Windows.Forms.TextBox txtName = null!;
    private System.Windows.Forms.Label lblEmail = null!;
    protected System.Windows.Forms.TextBox txtEmail = null!;
    private System.Windows.Forms.Label lblPhone = null!;
    protected System.Windows.Forms.TextBox txtPhone = null!;
    private System.Windows.Forms.Label lblPass = null!;
    protected System.Windows.Forms.TextBox txtPass = null!;
    private System.Windows.Forms.Label lblLimit = null!;
    protected System.Windows.Forms.TextBox txtLimit = null!;
    private System.Windows.Forms.Label lblRole = null!;
    protected System.Windows.Forms.ComboBox cmbRole = null!;
    private System.Windows.Forms.Label lblStatus = null!;
    protected System.Windows.Forms.ComboBox cmbStatus = null!;
    private System.Windows.Forms.Label lblErr = null!;
    private System.Windows.Forms.Button btnSave = null!;

    private void InitializeComponent()
    {
        this.card = new System.Windows.Forms.Panel();
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblName = new System.Windows.Forms.Label();
        this.txtName = new System.Windows.Forms.TextBox();
        this.lblEmail = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.lblPhone = new System.Windows.Forms.Label();
        this.txtPhone = new System.Windows.Forms.TextBox();
        this.lblPass = new System.Windows.Forms.Label();
        this.txtPass = new System.Windows.Forms.TextBox();
        this.lblLimit = new System.Windows.Forms.Label();
        this.txtLimit = new System.Windows.Forms.TextBox();
        this.lblRole = new System.Windows.Forms.Label();
        this.cmbRole = new System.Windows.Forms.ComboBox();
        this.lblStatus = new System.Windows.Forms.Label();
        this.cmbStatus = new System.Windows.Forms.ComboBox();
        this.lblErr = new System.Windows.Forms.Label();
        this.btnSave = new System.Windows.Forms.Button();
        this.card.SuspendLayout();
        this.SuspendLayout();

        this.card.BackColor = FuelMS.Helpers.UIHelper.CardBg;
        this.card.Dock = System.Windows.Forms.DockStyle.Fill;
        this.card.Padding = new System.Windows.Forms.Padding(20);
        this.card.TabIndex = 0;

        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = FuelMS.Helpers.UIHelper.AccentOrange;
        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Text = "Add User";
        this.lblTitle.TabIndex = 0;

        this.lblName.AutoSize = true;
        this.lblName.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblName.ForeColor = FuelMS.Helpers.UIHelper.TextSecondary;
        this.lblName.Location = new System.Drawing.Point(20, 55);
        this.lblName.Name = "lblName";
        this.lblName.Text = "FULL NAME";
        this.lblName.TabIndex = 1;

        this.txtName.BackColor = System.Drawing.Color.FromArgb(20, 28, 42);
        this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtName.ForeColor = FuelMS.Helpers.UIHelper.TextPrimary;
        this.txtName.Location = new System.Drawing.Point(20, 73);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(360, 24);
        this.txtName.TabIndex = 2;

        this.lblEmail.AutoSize = true;
        this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblEmail.ForeColor = FuelMS.Helpers.UIHelper.TextSecondary;
        this.lblEmail.Location = new System.Drawing.Point(20, 113);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Text = "EMAIL";
        this.lblEmail.TabIndex = 3;

        this.txtEmail.BackColor = System.Drawing.Color.FromArgb(20, 28, 42);
        this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtEmail.ForeColor = FuelMS.Helpers.UIHelper.TextPrimary;
        this.txtEmail.Location = new System.Drawing.Point(20, 131);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(360, 24);
        this.txtEmail.TabIndex = 4;

        this.lblPhone.AutoSize = true;
        this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblPhone.ForeColor = FuelMS.Helpers.UIHelper.TextSecondary;
        this.lblPhone.Location = new System.Drawing.Point(20, 171);
        this.lblPhone.Name = "lblPhone";
        this.lblPhone.Text = "PHONE";
        this.lblPhone.TabIndex = 5;

        this.txtPhone.BackColor = System.Drawing.Color.FromArgb(20, 28, 42);
        this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtPhone.ForeColor = FuelMS.Helpers.UIHelper.TextPrimary;
        this.txtPhone.Location = new System.Drawing.Point(20, 189);
        this.txtPhone.Name = "txtPhone";
        this.txtPhone.Size = new System.Drawing.Size(360, 24);
        this.txtPhone.TabIndex = 6;

        this.lblPass.AutoSize = true;
        this.lblPass.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblPass.ForeColor = FuelMS.Helpers.UIHelper.TextSecondary;
        this.lblPass.Location = new System.Drawing.Point(20, 229);
        this.lblPass.Name = "lblPass";
        this.lblPass.Text = "PASSWORD";
        this.lblPass.TabIndex = 7;

        this.txtPass.BackColor = System.Drawing.Color.FromArgb(20, 28, 42);
        this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtPass.ForeColor = FuelMS.Helpers.UIHelper.TextPrimary;
        this.txtPass.Location = new System.Drawing.Point(20, 247);
        this.txtPass.Name = "txtPass";
        this.txtPass.PasswordChar = '●';
        this.txtPass.Size = new System.Drawing.Size(360, 24);
        this.txtPass.TabIndex = 8;

        this.lblLimit.AutoSize = true;
        this.lblLimit.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblLimit.ForeColor = FuelMS.Helpers.UIHelper.TextSecondary;
        this.lblLimit.Location = new System.Drawing.Point(20, 287);
        this.lblLimit.Name = "lblLimit";
        this.lblLimit.Text = "MONTHLY LIMIT (L)";
        this.lblLimit.TabIndex = 9;

        this.txtLimit.BackColor = System.Drawing.Color.FromArgb(20, 28, 42);
        this.txtLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtLimit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtLimit.ForeColor = FuelMS.Helpers.UIHelper.TextPrimary;
        this.txtLimit.Location = new System.Drawing.Point(20, 305);
        this.txtLimit.Name = "txtLimit";
        this.txtLimit.Size = new System.Drawing.Size(150, 24);
        this.txtLimit.Text = "100";
        this.txtLimit.TabIndex = 10;

        this.lblRole.AutoSize = true;
        this.lblRole.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblRole.ForeColor = FuelMS.Helpers.UIHelper.TextSecondary;
        this.lblRole.Location = new System.Drawing.Point(20, 345);
        this.lblRole.Name = "lblRole";
        this.lblRole.Text = "ROLE";
        this.lblRole.TabIndex = 11;

        this.cmbRole.BackColor = System.Drawing.Color.FromArgb(20, 28, 42);
        this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cmbRole.ForeColor = FuelMS.Helpers.UIHelper.TextPrimary;
        this.cmbRole.FormattingEnabled = true;
        this.cmbRole.Items.AddRange(new object[] { "SuperAdmin (1)", "Admin (2)", "User (3)" });
        this.cmbRole.Location = new System.Drawing.Point(20, 363);
        this.cmbRole.Name = "cmbRole";
        this.cmbRole.Size = new System.Drawing.Size(160, 28);
        this.cmbRole.TabIndex = 12;

        this.lblStatus.AutoSize = true;
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblStatus.ForeColor = FuelMS.Helpers.UIHelper.TextSecondary;
        this.lblStatus.Location = new System.Drawing.Point(200, 345);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Text = "STATUS";
        this.lblStatus.TabIndex = 13;

        this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(20, 28, 42);
        this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cmbStatus.ForeColor = FuelMS.Helpers.UIHelper.TextPrimary;
        this.cmbStatus.FormattingEnabled = true;
        this.cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
        this.cmbStatus.Location = new System.Drawing.Point(200, 363);
        this.cmbStatus.Name = "cmbStatus";
        this.cmbStatus.Size = new System.Drawing.Size(180, 28);
        this.cmbStatus.TabIndex = 14;

        this.lblErr.AutoSize = true;
        this.lblErr.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblErr.ForeColor = FuelMS.Helpers.UIHelper.AccentRed;
        this.lblErr.Location = new System.Drawing.Point(20, 400);
        this.lblErr.Name = "lblErr";
        this.lblErr.Size = new System.Drawing.Size(360, 20);
        this.lblErr.Text = "";
        this.lblErr.TabIndex = 15;

        this.btnSave.BackColor = FuelMS.Helpers.UIHelper.AccentGreen;
        this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnSave.FlatAppearance.BorderSize = 0;
        this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnSave.ForeColor = System.Drawing.Color.White;
        this.btnSave.Location = new System.Drawing.Point(20, 425);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(360, 42);
        this.btnSave.Text = "SAVE";
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        this.btnSave.TabIndex = 16;

        this.card.Controls.Add(this.lblTitle);
        this.card.Controls.Add(this.lblName);
        this.card.Controls.Add(this.txtName);
        this.card.Controls.Add(this.lblEmail);
        this.card.Controls.Add(this.txtEmail);
        this.card.Controls.Add(this.lblPhone);
        this.card.Controls.Add(this.txtPhone);
        this.card.Controls.Add(this.lblPass);
        this.card.Controls.Add(this.txtPass);
        this.card.Controls.Add(this.lblLimit);
        this.card.Controls.Add(this.txtLimit);
        this.card.Controls.Add(this.lblRole);
        this.card.Controls.Add(this.cmbRole);
        this.card.Controls.Add(this.lblStatus);
        this.card.Controls.Add(this.cmbStatus);
        this.card.Controls.Add(this.lblErr);
        this.card.Controls.Add(this.btnSave);

        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = FuelMS.Helpers.UIHelper.PrimaryBg;
        this.ClientSize = new System.Drawing.Size(420, 500);
        this.Controls.Add(this.card);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "UserEditDialog";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "UserEditDialog";
        this.card.ResumeLayout(false);
        this.card.PerformLayout();
        this.ResumeLayout(false);
    }
}
