namespace FuelMS.Forms;

partial class FuelEditDialog
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
    private System.Windows.Forms.Label lblPrice = null!;
    private System.Windows.Forms.Label lblQty = null!;
    private System.Windows.Forms.Label lblStatus = null!;
    private System.Windows.Forms.Label lblErr = null!;
    private System.Windows.Forms.Button btnSave = null!;

    private void InitializeComponent()
    {
        this.card = new System.Windows.Forms.Panel();
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblName = new System.Windows.Forms.Label();
        this.txtName = new System.Windows.Forms.TextBox();
        this.lblPrice = new System.Windows.Forms.Label();
        this.txtPrice = new System.Windows.Forms.TextBox();
        this.lblQty = new System.Windows.Forms.Label();
        this.txtQty = new System.Windows.Forms.TextBox();
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
        this.lblTitle.Text = "Add Fuel";
        this.lblTitle.TabIndex = 0;

        this.lblName.AutoSize = true;
        this.lblName.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblName.ForeColor = FuelMS.Helpers.UIHelper.TextSecondary;
        this.lblName.Location = new System.Drawing.Point(20, 55);
        this.lblName.Name = "lblName";
        this.lblName.Text = "FUEL NAME";
        this.lblName.TabIndex = 1;

        this.txtName.BackColor = System.Drawing.Color.FromArgb(20, 28, 42);
        this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtName.ForeColor = FuelMS.Helpers.UIHelper.TextPrimary;
        this.txtName.Location = new System.Drawing.Point(20, 73);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(320, 24);
        this.txtName.TabIndex = 2;

        this.lblPrice.AutoSize = true;
        this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblPrice.ForeColor = FuelMS.Helpers.UIHelper.TextSecondary;
        this.lblPrice.Location = new System.Drawing.Point(20, 113);
        this.lblPrice.Name = "lblPrice";
        this.lblPrice.Text = "PRICE PER LITER (৳)";
        this.lblPrice.TabIndex = 3;

        this.txtPrice.BackColor = System.Drawing.Color.FromArgb(20, 28, 42);
        this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtPrice.ForeColor = FuelMS.Helpers.UIHelper.TextPrimary;
        this.txtPrice.Location = new System.Drawing.Point(20, 131);
        this.txtPrice.Name = "txtPrice";
        this.txtPrice.Size = new System.Drawing.Size(150, 24);
        this.txtPrice.TabIndex = 4;

        this.lblQty.AutoSize = true;
        this.lblQty.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblQty.ForeColor = FuelMS.Helpers.UIHelper.TextSecondary;
        this.lblQty.Location = new System.Drawing.Point(20, 171);
        this.lblQty.Name = "lblQty";
        this.lblQty.Text = "INITIAL STOCK (L)";
        this.lblQty.TabIndex = 5;

        this.txtQty.BackColor = System.Drawing.Color.FromArgb(20, 28, 42);
        this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtQty.ForeColor = FuelMS.Helpers.UIHelper.TextPrimary;
        this.txtQty.Location = new System.Drawing.Point(20, 189);
        this.txtQty.Name = "txtQty";
        this.txtQty.Size = new System.Drawing.Size(150, 24);
        this.txtQty.TabIndex = 6;

        this.lblStatus.AutoSize = true;
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblStatus.ForeColor = FuelMS.Helpers.UIHelper.TextSecondary;
        this.lblStatus.Location = new System.Drawing.Point(20, 229);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Text = "STATUS";
        this.lblStatus.TabIndex = 7;

        this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(20, 28, 42);
        this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cmbStatus.ForeColor = FuelMS.Helpers.UIHelper.TextPrimary;
        this.cmbStatus.FormattingEnabled = true;
        this.cmbStatus.Items.AddRange(new object[] { "Available", "Unavailable" });
        this.cmbStatus.Location = new System.Drawing.Point(20, 247);
        this.cmbStatus.Name = "cmbStatus";
        this.cmbStatus.Size = new System.Drawing.Size(160, 28);
        this.cmbStatus.TabIndex = 8;

        this.lblErr.AutoSize = true;
        this.lblErr.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblErr.ForeColor = FuelMS.Helpers.UIHelper.AccentRed;
        this.lblErr.Location = new System.Drawing.Point(20, 280);
        this.lblErr.Name = "lblErr";
        this.lblErr.Size = new System.Drawing.Size(320, 20);
        this.lblErr.Text = "";
        this.lblErr.TabIndex = 9;

        this.btnSave.BackColor = FuelMS.Helpers.UIHelper.AccentGreen;
        this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnSave.FlatAppearance.BorderSize = 0;
        this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnSave.ForeColor = System.Drawing.Color.White;
        this.btnSave.Location = new System.Drawing.Point(20, 298);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(320, 42);
        this.btnSave.Text = "SAVE";
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        this.btnSave.TabIndex = 10;

        this.card.Controls.Add(this.lblTitle);
        this.card.Controls.Add(this.lblName);
        this.card.Controls.Add(this.txtName);
        this.card.Controls.Add(this.lblPrice);
        this.card.Controls.Add(this.txtPrice);
        this.card.Controls.Add(this.lblQty);
        this.card.Controls.Add(this.txtQty);
        this.card.Controls.Add(this.lblStatus);
        this.card.Controls.Add(this.cmbStatus);
        this.card.Controls.Add(this.lblErr);
        this.card.Controls.Add(this.btnSave);

        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = FuelMS.Helpers.UIHelper.PrimaryBg;
        this.ClientSize = new System.Drawing.Size(380, 360);
        this.Controls.Add(this.card);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FuelEditDialog";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "FuelEditDialog";
        this.card.ResumeLayout(false);
        this.card.PerformLayout();
        this.ResumeLayout(false);
    }
}
