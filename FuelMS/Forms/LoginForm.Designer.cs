namespace FuelMS.Forms;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.pnlLogo = new System.Windows.Forms.Panel();
        this.lblLogoTitle = new System.Windows.Forms.Label();
        this.lblLogoSub = new System.Windows.Forms.Label();
        this.pnlCard = new System.Windows.Forms.Panel();
        this.lblSignIn = new System.Windows.Forms.Label();
        this.lblEmailHeader = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.lblPasswordHeader = new System.Windows.Forms.Label();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.lblError = new System.Windows.Forms.Label();
        this.btnLogin = new System.Windows.Forms.Button();
        this.btnForgot = new System.Windows.Forms.Button();
        this.lblRegisterPrompt = new System.Windows.Forms.Label();
        this.btnRegister = new System.Windows.Forms.Button();
        this.pnlLogo.SuspendLayout();
        this.pnlCard.SuspendLayout();
        this.SuspendLayout();

        // pnlLogo
        this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(22, 30, 44);
        this.pnlLogo.Controls.Add(this.lblLogoTitle);
        this.pnlLogo.Controls.Add(this.lblLogoSub);
        this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlLogo.Height = 120;
        this.pnlLogo.Name = "pnlLogo";
        this.pnlLogo.TabIndex = 0;

        // lblLogoTitle
        this.lblLogoTitle.AutoSize = true;
        this.lblLogoTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
        this.lblLogoTitle.ForeColor = System.Drawing.Color.FromArgb(255, 140, 0);
        this.lblLogoTitle.Location = new System.Drawing.Point(130, 20);
        this.lblLogoTitle.Name = "lblLogoTitle";
        this.lblLogoTitle.Text = "⛽ FuelMS";

        // lblLogoSub
        this.lblLogoSub.AutoSize = true;
        this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
        this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.lblLogoSub.Location = new System.Drawing.Point(130, 72);
        this.lblLogoSub.Name = "lblLogoSub";
        this.lblLogoSub.Text = "FUEL MANAGEMENT SYSTEM";

        // pnlCard
        this.pnlCard.BackColor = System.Drawing.Color.FromArgb(30, 40, 58);
        this.pnlCard.Controls.Add(this.lblSignIn);
        this.pnlCard.Controls.Add(this.lblEmailHeader);
        this.pnlCard.Controls.Add(this.txtEmail);
        this.pnlCard.Controls.Add(this.lblPasswordHeader);
        this.pnlCard.Controls.Add(this.txtPassword);
        this.pnlCard.Controls.Add(this.lblError);
        this.pnlCard.Controls.Add(this.btnLogin);
        this.pnlCard.Controls.Add(this.btnForgot);
        this.pnlCard.Location = new System.Drawing.Point(50, 140);
        this.pnlCard.Name = "pnlCard";
        this.pnlCard.Size = new System.Drawing.Size(360, 300);
        this.pnlCard.TabIndex = 1;

        // lblSignIn
        this.lblSignIn.AutoSize = true;
        this.lblSignIn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblSignIn.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
        this.lblSignIn.Location = new System.Drawing.Point(20, 20);
        this.lblSignIn.Name = "lblSignIn";
        this.lblSignIn.Text = "Sign In";

        // lblEmailHeader
        this.lblEmailHeader.AutoSize = true;
        this.lblEmailHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblEmailHeader.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.lblEmailHeader.Location = new System.Drawing.Point(20, 60);
        this.lblEmailHeader.Name = "lblEmailHeader";
        this.lblEmailHeader.Text = "EMAIL ADDRESS";

        // txtEmail
        this.txtEmail.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
        this.txtEmail.Location = new System.Drawing.Point(20, 78);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(320, 24);
        this.txtEmail.TabIndex = 0;
        this.txtEmail.Text = "admin@fuelms.com";

        // lblPasswordHeader
        this.lblPasswordHeader.AutoSize = true;
        this.lblPasswordHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblPasswordHeader.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.lblPasswordHeader.Location = new System.Drawing.Point(20, 116);
        this.lblPasswordHeader.Name = "lblPasswordHeader";
        this.lblPasswordHeader.Text = "PASSWORD";

        // txtPassword
        this.txtPassword.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
        this.txtPassword.Location = new System.Drawing.Point(20, 134);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '●';
        this.txtPassword.Size = new System.Drawing.Size(320, 24);
        this.txtPassword.TabIndex = 1;
        this.txtPassword.Text = "Admin@123";
        this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);

        // lblError
        this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblError.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
        this.lblError.Location = new System.Drawing.Point(20, 172);
        this.lblError.Name = "lblError";
        this.lblError.Size = new System.Drawing.Size(320, 20);
        this.lblError.Text = "";

        // btnLogin
        this.btnLogin.BackColor = System.Drawing.Color.FromArgb(255, 140, 0);
        this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnLogin.FlatAppearance.BorderSize = 0;
        this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnLogin.ForeColor = System.Drawing.Color.White;
        this.btnLogin.Location = new System.Drawing.Point(20, 200);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(320, 42);
        this.btnLogin.TabIndex = 2;
        this.btnLogin.Text = "SIGN IN";
        this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

        // btnForgot
        this.btnForgot.BackColor = System.Drawing.Color.Transparent;
        this.btnForgot.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnForgot.FlatAppearance.BorderSize = 0;
        this.btnForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnForgot.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.btnForgot.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
        this.btnForgot.Location = new System.Drawing.Point(20, 256);
        this.btnForgot.Name = "btnForgot";
        this.btnForgot.AutoSize = true;
        this.btnForgot.Text = "Forgot Password?";
        this.btnForgot.Click += new System.EventHandler(this.btnForgot_Click);

        // lblRegisterPrompt
        this.lblRegisterPrompt.AutoSize = true;
        this.lblRegisterPrompt.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblRegisterPrompt.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.lblRegisterPrompt.Location = new System.Drawing.Point(130, 455);
        this.lblRegisterPrompt.Name = "lblRegisterPrompt";
        this.lblRegisterPrompt.Text = "Don't have an account?";

        // btnRegister
        this.btnRegister.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnRegister.FlatAppearance.BorderSize = 0;
        this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnRegister.ForeColor = System.Drawing.Color.White;
        this.btnRegister.Location = new System.Drawing.Point(130, 478);
        this.btnRegister.Name = "btnRegister";
        this.btnRegister.Size = new System.Drawing.Size(200, 36);
        this.btnRegister.TabIndex = 3;
        this.btnRegister.Text = "Create Account";
        this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

        // LoginForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.ClientSize = new System.Drawing.Size(460, 540);
        this.Controls.Add(this.pnlLogo);
        this.Controls.Add(this.pnlCard);
        this.Controls.Add(this.lblRegisterPrompt);
        this.Controls.Add(this.btnRegister);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "LoginForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Fuel Management System — Login";
        this.pnlLogo.ResumeLayout(false);
        this.pnlLogo.PerformLayout();
        this.pnlCard.ResumeLayout(false);
        this.pnlCard.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Panel pnlLogo;
    private System.Windows.Forms.Label lblLogoTitle;
    private System.Windows.Forms.Label lblLogoSub;
    private System.Windows.Forms.Panel pnlCard;
    private System.Windows.Forms.Label lblSignIn;
    private System.Windows.Forms.Label lblEmailHeader;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblPasswordHeader;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblError;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnForgot;
    private System.Windows.Forms.Label lblRegisterPrompt;
    private System.Windows.Forms.Button btnRegister;
}
