namespace FuelMS.Forms;

partial class RegisterForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.pnlCard        = new System.Windows.Forms.Panel();
        this.lblTitle       = new System.Windows.Forms.Label();
        this.lblName        = new System.Windows.Forms.Label();
        this.txtName        = new System.Windows.Forms.TextBox();
        this.lblEmail       = new System.Windows.Forms.Label();
        this.txtEmail       = new System.Windows.Forms.TextBox();
        this.lblPhone       = new System.Windows.Forms.Label();
        this.txtPhone       = new System.Windows.Forms.TextBox();
        this.lblPassword    = new System.Windows.Forms.Label();
        this.txtPassword    = new System.Windows.Forms.TextBox();
        this.lblConfirm     = new System.Windows.Forms.Label();
        this.txtConfirm     = new System.Windows.Forms.TextBox();
        this.lblError       = new System.Windows.Forms.Label();
        this.btnCreateAccount = new System.Windows.Forms.Button();
        this.pnlCard.SuspendLayout();
        this.SuspendLayout();

        // pnlCard
        this.pnlCard.BackColor = System.Drawing.Color.FromArgb(30, 40, 58);
        this.pnlCard.Controls.Add(this.lblTitle);
        this.pnlCard.Controls.Add(this.lblName);
        this.pnlCard.Controls.Add(this.txtName);
        this.pnlCard.Controls.Add(this.lblEmail);
        this.pnlCard.Controls.Add(this.txtEmail);
        this.pnlCard.Controls.Add(this.lblPhone);
        this.pnlCard.Controls.Add(this.txtPhone);
        this.pnlCard.Controls.Add(this.lblPassword);
        this.pnlCard.Controls.Add(this.txtPassword);
        this.pnlCard.Controls.Add(this.lblConfirm);
        this.pnlCard.Controls.Add(this.txtConfirm);
        this.pnlCard.Controls.Add(this.lblError);
        this.pnlCard.Controls.Add(this.btnCreateAccount);
        this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlCard.Name = "pnlCard";

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 140, 0);
        this.lblTitle.Location = new System.Drawing.Point(30, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Text = "Create Account";

        // lblName
        this.lblName.AutoSize = true;
        this.lblName.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblName.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.lblName.Location = new System.Drawing.Point(30, 72);
        this.lblName.Name = "lblName";
        this.lblName.Text = "FULL NAME";

        // txtName
        this.txtName.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtName.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
        this.txtName.Location = new System.Drawing.Point(30, 90);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(330, 24);

        // lblEmail
        this.lblEmail.AutoSize = true;
        this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.lblEmail.Location = new System.Drawing.Point(30, 132);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Text = "EMAIL ADDRESS";

        // txtEmail
        this.txtEmail.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
        this.txtEmail.Location = new System.Drawing.Point(30, 150);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(330, 24);

        // lblPhone
        this.lblPhone.AutoSize = true;
        this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.lblPhone.Location = new System.Drawing.Point(30, 192);
        this.lblPhone.Name = "lblPhone";
        this.lblPhone.Text = "PHONE NUMBER";

        // txtPhone
        this.txtPhone.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
        this.txtPhone.Location = new System.Drawing.Point(30, 210);
        this.txtPhone.Name = "txtPhone";
        this.txtPhone.Size = new System.Drawing.Size(330, 24);

        // lblPassword
        this.lblPassword.AutoSize = true;
        this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.lblPassword.Location = new System.Drawing.Point(30, 252);
        this.lblPassword.Name = "lblPassword";
        this.lblPassword.Text = "PASSWORD";

        // txtPassword
        this.txtPassword.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
        this.txtPassword.Location = new System.Drawing.Point(30, 270);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '●';
        this.txtPassword.Size = new System.Drawing.Size(330, 24);

        // lblConfirm
        this.lblConfirm.AutoSize = true;
        this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.lblConfirm.Location = new System.Drawing.Point(30, 312);
        this.lblConfirm.Name = "lblConfirm";
        this.lblConfirm.Text = "CONFIRM PASSWORD";

        // txtConfirm
        this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
        this.txtConfirm.Location = new System.Drawing.Point(30, 330);
        this.txtConfirm.Name = "txtConfirm";
        this.txtConfirm.PasswordChar = '●';
        this.txtConfirm.Size = new System.Drawing.Size(330, 24);

        // lblError
        this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblError.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
        this.lblError.Location = new System.Drawing.Point(30, 368);
        this.lblError.Name = "lblError";
        this.lblError.Size = new System.Drawing.Size(330, 20);
        this.lblError.Text = "";

        // btnCreateAccount
        this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(40, 200, 120);
        this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCreateAccount.FlatAppearance.BorderSize = 0;
        this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
        this.btnCreateAccount.Location = new System.Drawing.Point(30, 395);
        this.btnCreateAccount.Name = "btnCreateAccount";
        this.btnCreateAccount.Size = new System.Drawing.Size(330, 42);
        this.btnCreateAccount.Text = "CREATE ACCOUNT";
        this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);

        // RegisterForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.ClientSize = new System.Drawing.Size(420, 460);
        this.Controls.Add(this.pnlCard);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "RegisterForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Register New Account";
        this.pnlCard.ResumeLayout(false);
        this.pnlCard.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlCard;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblConfirm;
    private System.Windows.Forms.TextBox txtConfirm;
    private System.Windows.Forms.Label lblError;
    private System.Windows.Forms.Button btnCreateAccount;
}
