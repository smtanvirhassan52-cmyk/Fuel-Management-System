namespace FuelMS.Forms;

partial class ChangePasswordForm
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
        this.lblEmail       = new System.Windows.Forms.Label();
        this.txtEmail       = new System.Windows.Forms.TextBox();
        this.lblNewPassword = new System.Windows.Forms.Label();
        this.txtNewPassword = new System.Windows.Forms.TextBox();
        this.lblConfirm     = new System.Windows.Forms.Label();
        this.txtConfirm     = new System.Windows.Forms.TextBox();
        this.lblError       = new System.Windows.Forms.Label();
        this.btnUpdate      = new System.Windows.Forms.Button();
        this.pnlCard.SuspendLayout();
        this.SuspendLayout();

        // pnlCard
        this.pnlCard.BackColor = System.Drawing.Color.FromArgb(30, 40, 58);
        this.pnlCard.Controls.Add(this.lblTitle);
        this.pnlCard.Controls.Add(this.lblEmail);
        this.pnlCard.Controls.Add(this.txtEmail);
        this.pnlCard.Controls.Add(this.lblNewPassword);
        this.pnlCard.Controls.Add(this.txtNewPassword);
        this.pnlCard.Controls.Add(this.lblConfirm);
        this.pnlCard.Controls.Add(this.txtConfirm);
        this.pnlCard.Controls.Add(this.lblError);
        this.pnlCard.Controls.Add(this.btnUpdate);
        this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlCard.Name = "pnlCard";

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 140, 0);
        this.lblTitle.Location = new System.Drawing.Point(30, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Text = "Reset Password";

        // lblEmail
        this.lblEmail.AutoSize = true;
        this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.lblEmail.Location = new System.Drawing.Point(30, 65);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Text = "EMAIL ADDRESS";

        // txtEmail
        this.txtEmail.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
        this.txtEmail.Location = new System.Drawing.Point(30, 83);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(320, 24);

        // lblNewPassword
        this.lblNewPassword.AutoSize = true;
        this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.lblNewPassword.Location = new System.Drawing.Point(30, 137);
        this.lblNewPassword.Name = "lblNewPassword";
        this.lblNewPassword.Text = "NEW PASSWORD";

        // txtNewPassword
        this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
        this.txtNewPassword.Location = new System.Drawing.Point(30, 155);
        this.txtNewPassword.Name = "txtNewPassword";
        this.txtNewPassword.PasswordChar = '●';
        this.txtNewPassword.Size = new System.Drawing.Size(320, 24);

        // lblConfirm
        this.lblConfirm.AutoSize = true;
        this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
        this.lblConfirm.Location = new System.Drawing.Point(30, 209);
        this.lblConfirm.Name = "lblConfirm";
        this.lblConfirm.Text = "CONFIRM PASSWORD";

        // txtConfirm
        this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
        this.txtConfirm.Location = new System.Drawing.Point(30, 227);
        this.txtConfirm.Name = "txtConfirm";
        this.txtConfirm.PasswordChar = '●';
        this.txtConfirm.Size = new System.Drawing.Size(320, 24);

        // lblError
        this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblError.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
        this.lblError.Location = new System.Drawing.Point(30, 280);
        this.lblError.Name = "lblError";
        this.lblError.Size = new System.Drawing.Size(320, 20);
        this.lblError.Text = "";

        // btnUpdate
        this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnUpdate.FlatAppearance.BorderSize = 0;
        this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnUpdate.ForeColor = System.Drawing.Color.White;
        this.btnUpdate.Location = new System.Drawing.Point(30, 305);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(320, 42);
        this.btnUpdate.Text = "UPDATE PASSWORD";
        this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

        // ChangePasswordForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(15, 20, 30);
        this.ClientSize = new System.Drawing.Size(400, 370);
        this.Controls.Add(this.pnlCard);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "ChangePasswordForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Reset Password";
        this.pnlCard.ResumeLayout(false);
        this.pnlCard.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlCard;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblNewPassword;
    private System.Windows.Forms.TextBox txtNewPassword;
    private System.Windows.Forms.Label lblConfirm;
    private System.Windows.Forms.TextBox txtConfirm;
    private System.Windows.Forms.Label lblError;
    private System.Windows.Forms.Button btnUpdate;
}
