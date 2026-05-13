namespace FuelMS.Forms;

partial class PlaceOrderView
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private System.Windows.Forms.Label lblTitle = null!;
    private System.Windows.Forms.Panel cardOrder = null!;
    private System.Windows.Forms.Label lblOrderTitle = null!;
    private System.Windows.Forms.Label lblLimitInfo = null!;
    private System.Windows.Forms.Label lblFuel = null!;
    private System.Windows.Forms.ComboBox cmbFuel = null!;
    private System.Windows.Forms.Label lblQty = null!;
    private System.Windows.Forms.TextBox txtQty = null!;
    private System.Windows.Forms.Label lblCalc = null!;
    private System.Windows.Forms.Label lblPayment = null!;
    private System.Windows.Forms.ComboBox cmbPayment = null!;
    private System.Windows.Forms.Label lblErr = null!;
    private System.Windows.Forms.Label lblSuccess = null!;
    private System.Windows.Forms.Button btnOrder = null!;
    private System.Windows.Forms.Panel cardPriceList = null!;
    private System.Windows.Forms.Label lblPriceListTitle = null!;
    private System.Windows.Forms.Panel panelPriceList = null!;

    private void InitializeComponent()
    {
        lblTitle = new Label();
        cardOrder = new Panel();
        lblOrderTitle = new Label();
        lblLimitInfo = new Label();
        lblFuel = new Label();
        cmbFuel = new ComboBox();
        lblQty = new Label();
        txtQty = new TextBox();
        lblCalc = new Label();
        lblPayment = new Label();
        cmbPayment = new ComboBox();
        lblErr = new Label();
        lblSuccess = new Label();
        btnOrder = new Button();
        cardPriceList = new Panel();
        lblPriceListTitle = new Label();
        panelPriceList = new Panel();
        cardOrder.SuspendLayout();
        cardPriceList.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(286, 46);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Place New Order";
        // 
        // cardOrder
        // 
        cardOrder.BackColor = Color.FromArgb(30, 40, 58);
        cardOrder.Controls.Add(lblOrderTitle);
        cardOrder.Controls.Add(lblLimitInfo);
        cardOrder.Controls.Add(lblFuel);
        cardOrder.Controls.Add(cmbFuel);
        cardOrder.Controls.Add(lblQty);
        cardOrder.Controls.Add(txtQty);
        cardOrder.Controls.Add(lblCalc);
        cardOrder.Controls.Add(lblPayment);
        cardOrder.Controls.Add(cmbPayment);
        cardOrder.Controls.Add(lblErr);
        cardOrder.Controls.Add(lblSuccess);
        cardOrder.Controls.Add(btnOrder);
        cardOrder.Location = new Point(0, 50);
        cardOrder.Name = "cardOrder";
        cardOrder.Padding = new Padding(15);
        cardOrder.Size = new Size(480, 440);
        cardOrder.TabIndex = 1;
        // 
        // lblOrderTitle
        // 
        lblOrderTitle.AutoSize = true;
        lblOrderTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblOrderTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblOrderTitle.Location = new Point(15, 12);
        lblOrderTitle.Name = "lblOrderTitle";
        lblOrderTitle.Size = new Size(151, 30);
        lblOrderTitle.TabIndex = 0;
        lblOrderTitle.Text = "Order Details";
        // 
        // lblLimitInfo
        // 
        lblLimitInfo.AutoSize = true;
        lblLimitInfo.Font = new Font("Segoe UI", 9.5F);
        lblLimitInfo.ForeColor = Color.FromArgb(40, 200, 120);
        lblLimitInfo.Location = new Point(15, 45);
        lblLimitInfo.Name = "lblLimitInfo";
        lblLimitInfo.Size = new Size(329, 21);
        lblLimitInfo.TabIndex = 1;
        lblLimitInfo.Text = "Monthly Limit: 0L  |  Used: 0L  |  Remaining: 0L";
        // 
        // lblFuel
        // 
        lblFuel.AutoSize = true;
        lblFuel.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
        lblFuel.ForeColor = Color.FromArgb(130, 150, 180);
        lblFuel.Location = new Point(15, 80);
        lblFuel.Name = "lblFuel";
        lblFuel.Size = new Size(121, 17);
        lblFuel.TabIndex = 2;
        lblFuel.Text = "SELECT FUEL TYPE";
        // 
        // cmbFuel
        // 
        cmbFuel.BackColor = Color.FromArgb(20, 28, 42);
        cmbFuel.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFuel.Font = new Font("Segoe UI", 9.5F);
        cmbFuel.ForeColor = Color.FromArgb(230, 240, 255);
        cmbFuel.FormattingEnabled = true;
        cmbFuel.Location = new Point(15, 98);
        cmbFuel.Name = "cmbFuel";
        cmbFuel.Size = new Size(440, 29);
        cmbFuel.TabIndex = 3;
        cmbFuel.SelectedIndexChanged += cmbFuel_SelectedIndexChanged;
        // 
        // lblQty
        // 
        lblQty.AutoSize = true;
        lblQty.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
        lblQty.ForeColor = Color.FromArgb(130, 150, 180);
        lblQty.Location = new Point(15, 140);
        lblQty.Name = "lblQty";
        lblQty.Size = new Size(122, 17);
        lblQty.TabIndex = 4;
        lblQty.Text = "QUANTITY (Liters)";
        // 
        // txtQty
        // 
        txtQty.BackColor = Color.FromArgb(20, 28, 42);
        txtQty.BorderStyle = BorderStyle.FixedSingle;
        txtQty.Font = new Font("Segoe UI", 9.5F);
        txtQty.ForeColor = Color.FromArgb(230, 240, 255);
        txtQty.Location = new Point(15, 158);
        txtQty.Name = "txtQty";
        txtQty.Size = new Size(160, 29);
        txtQty.TabIndex = 5;
        txtQty.Text = "10";
        txtQty.TextChanged += txtQty_TextChanged;
        // 
        // lblCalc
        // 
        lblCalc.AutoSize = true;
        lblCalc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblCalc.ForeColor = Color.FromArgb(255, 140, 0);
        lblCalc.Location = new Point(200, 160);
        lblCalc.Name = "lblCalc";
        lblCalc.Size = new Size(130, 28);
        lblCalc.TabIndex = 6;
        lblCalc.Text = "Total: ৳0.00";
        // 
        // lblPayment
        // 
        lblPayment.AutoSize = true;
        lblPayment.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
        lblPayment.ForeColor = Color.FromArgb(130, 150, 180);
        lblPayment.Location = new Point(15, 205);
        lblPayment.Name = "lblPayment";
        lblPayment.Size = new Size(151, 17);
        lblPayment.TabIndex = 10;
        lblPayment.Text = "PAYMENT METHOD";
        // 
        // cmbPayment
        // 
        cmbPayment.BackColor = Color.FromArgb(20, 28, 42);
        cmbPayment.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPayment.Font = new Font("Segoe UI", 9.5F);
        cmbPayment.ForeColor = Color.FromArgb(230, 240, 255);
        cmbPayment.FormattingEnabled = true;
        cmbPayment.Location = new Point(15, 223);
        cmbPayment.Name = "cmbPayment";
        cmbPayment.Size = new Size(440, 29);
        cmbPayment.TabIndex = 11;
        // 
        // lblErr
        // 
        lblErr.AutoSize = true;
        lblErr.Font = new Font("Segoe UI", 9.5F);
        lblErr.ForeColor = Color.FromArgb(220, 53, 69);
        lblErr.Location = new Point(15, 270);
        lblErr.Name = "lblErr";
        lblErr.Size = new Size(0, 21);
        lblErr.TabIndex = 7;
        // 
        // lblSuccess
        // 
        lblSuccess.AutoSize = true;
        lblSuccess.Font = new Font("Segoe UI", 9.5F);
        lblSuccess.ForeColor = Color.FromArgb(40, 200, 120);
        lblSuccess.Location = new Point(15, 270);
        lblSuccess.Name = "lblSuccess";
        lblSuccess.Size = new Size(0, 21);
        lblSuccess.TabIndex = 8;
        // 
        // btnOrder
        // 
        btnOrder.BackColor = Color.FromArgb(40, 200, 120);
        btnOrder.Cursor = Cursors.Hand;
        btnOrder.FlatAppearance.BorderSize = 0;
        btnOrder.FlatStyle = FlatStyle.Flat;
        btnOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnOrder.ForeColor = Color.White;
        btnOrder.Location = new Point(15, 315);
        btnOrder.Name = "btnOrder";
        btnOrder.Size = new Size(440, 50);
        btnOrder.TabIndex = 9;
        btnOrder.Text = "\U0001f6d2  PLACE ORDER & PAY";
        btnOrder.UseVisualStyleBackColor = false;
        btnOrder.Click += btnOrder_Click;
        // 
        // cardPriceList
        // 
        cardPriceList.BackColor = Color.FromArgb(30, 40, 58);
        cardPriceList.Controls.Add(lblPriceListTitle);
        cardPriceList.Controls.Add(panelPriceList);
        cardPriceList.Location = new Point(500, 50);
        cardPriceList.Name = "cardPriceList";
        cardPriceList.Padding = new Padding(15);
        cardPriceList.Size = new Size(280, 220);
        cardPriceList.TabIndex = 2;
        // 
        // lblPriceListTitle
        // 
        lblPriceListTitle.AutoSize = true;
        lblPriceListTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblPriceListTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblPriceListTitle.Location = new Point(15, 12);
        lblPriceListTitle.Name = "lblPriceListTitle";
        lblPriceListTitle.Size = new Size(155, 30);
        lblPriceListTitle.TabIndex = 0;
        lblPriceListTitle.Text = "Fuel Price List";
        // 
        // panelPriceList
        // 
        panelPriceList.AutoScroll = true;
        panelPriceList.Location = new Point(15, 45);
        panelPriceList.Name = "panelPriceList";
        panelPriceList.Size = new Size(250, 160);
        panelPriceList.TabIndex = 1;
        // 
        // PlaceOrderView
        // 
        BackColor = Color.FromArgb(15, 20, 30);
        Controls.Add(lblTitle);
        Controls.Add(cardOrder);
        Controls.Add(cardPriceList);
        Name = "PlaceOrderView";
        Size = new Size(1869, 623);
        cardOrder.ResumeLayout(false);
        cardOrder.PerformLayout();
        cardPriceList.ResumeLayout(false);
        cardPriceList.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
