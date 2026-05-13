namespace FuelMS.Forms;

partial class ReportsPanel
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private System.Windows.Forms.Label lblTitle = null!;
    private System.Windows.Forms.Button btnRefresh = null!;
    private System.Windows.Forms.Panel cardTotalOrders = null!;
    private System.Windows.Forms.Label lblTotalOrdersTitle = null!;
    private System.Windows.Forms.Label lblTotalOrdersValue = null!;
    private System.Windows.Forms.Panel barTotalOrders = null!;
    private System.Windows.Forms.Panel cardRevenue = null!;
    private System.Windows.Forms.Label lblRevenueTitle = null!;
    private System.Windows.Forms.Label lblRevenueValue = null!;
    private System.Windows.Forms.Panel barRevenue = null!;
    private System.Windows.Forms.Panel cardPending = null!;
    private System.Windows.Forms.Label lblPendingTitle = null!;
    private System.Windows.Forms.Label lblPendingValue = null!;
    private System.Windows.Forms.Panel barPending = null!;
    private System.Windows.Forms.Panel cardTodaySales = null!;
    private System.Windows.Forms.Label lblTodaySalesTitle = null!;
    private System.Windows.Forms.Label lblTodaySalesValue = null!;
    private System.Windows.Forms.Panel barTodaySales = null!;
    private System.Windows.Forms.Label lblMonthlyTitle = null!;
    private System.Windows.Forms.DataGridView grid = null!;

    private void InitializeComponent()
    {
        lblTitle = new Label();
        btnRefresh = new Button();
        cardTotalOrders = new Panel();
        barTotalOrders = new Panel();
        lblTotalOrdersTitle = new Label();
        lblTotalOrdersValue = new Label();
        cardRevenue = new Panel();
        barRevenue = new Panel();
        lblRevenueTitle = new Label();
        lblRevenueValue = new Label();
        cardPending = new Panel();
        barPending = new Panel();
        lblPendingTitle = new Label();
        lblPendingValue = new Label();
        cardTodaySales = new Panel();
        barTodaySales = new Panel();
        lblTodaySalesTitle = new Label();
        lblTodaySalesValue = new Label();
        lblMonthlyTitle = new Label();
        grid = new DataGridView();
        cardTotalOrders.SuspendLayout();
        cardRevenue.SuspendLayout();
        cardPending.SuspendLayout();
        cardTodaySales.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(143, 46);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Reports";
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.FromArgb(30, 40, 58);
        btnRefresh.Cursor = Cursors.Hand;
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRefresh.ForeColor = Color.FromArgb(230, 240, 255);
        btnRefresh.Location = new Point(0, 50);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(110, 40);
        btnRefresh.TabIndex = 1;
        btnRefresh.Text = "↺ Refresh";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // cardTotalOrders
        // 
        cardTotalOrders.BackColor = Color.FromArgb(30, 40, 58);
        cardTotalOrders.Controls.Add(barTotalOrders);
        cardTotalOrders.Controls.Add(lblTotalOrdersTitle);
        cardTotalOrders.Controls.Add(lblTotalOrdersValue);
        cardTotalOrders.Location = new Point(130, 50);
        cardTotalOrders.Name = "cardTotalOrders";
        cardTotalOrders.Size = new Size(180, 90);
        cardTotalOrders.TabIndex = 2;
        // 
        // barTotalOrders
        // 
        barTotalOrders.BackColor = Color.FromArgb(0, 120, 215);
        barTotalOrders.Location = new Point(0, 0);
        barTotalOrders.Name = "barTotalOrders";
        barTotalOrders.Size = new Size(4, 90);
        // 
        // lblTotalOrdersTitle
        // 
        lblTotalOrdersTitle.AutoSize = true;
        lblTotalOrdersTitle.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
        lblTotalOrdersTitle.ForeColor = Color.FromArgb(130, 150, 180);
        lblTotalOrdersTitle.Location = new Point(14, 14);
        lblTotalOrdersTitle.Name = "lblTotalOrdersTitle";
        lblTotalOrdersTitle.Size = new Size(103, 17);
        lblTotalOrdersTitle.TabIndex = 1;
        lblTotalOrdersTitle.Text = "TOTAL ORDERS";
        // 
        // lblTotalOrdersValue
        // 
        lblTotalOrdersValue.AutoSize = true;
        lblTotalOrdersValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTotalOrdersValue.ForeColor = Color.FromArgb(0, 120, 215);
        lblTotalOrdersValue.Location = new Point(14, 36);
        lblTotalOrdersValue.Name = "lblTotalOrdersValue";
        lblTotalOrdersValue.Size = new Size(34, 41);
        lblTotalOrdersValue.TabIndex = 2;
        lblTotalOrdersValue.Text = "0";
        // 
        // cardRevenue
        // 
        cardRevenue.BackColor = Color.FromArgb(30, 40, 58);
        cardRevenue.Controls.Add(barRevenue);
        cardRevenue.Controls.Add(lblRevenueTitle);
        cardRevenue.Controls.Add(lblRevenueValue);
        cardRevenue.Location = new Point(325, 50);
        cardRevenue.Name = "cardRevenue";
        cardRevenue.Size = new Size(180, 90);
        cardRevenue.TabIndex = 3;
        // 
        // barRevenue
        // 
        barRevenue.BackColor = Color.FromArgb(40, 200, 120);
        barRevenue.Location = new Point(0, 0);
        barRevenue.Name = "barRevenue";
        barRevenue.Size = new Size(4, 90);
        // 
        // lblRevenueTitle
        // 
        lblRevenueTitle.AutoSize = true;
        lblRevenueTitle.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
        lblRevenueTitle.ForeColor = Color.FromArgb(130, 150, 180);
        lblRevenueTitle.Location = new Point(14, 14);
        lblRevenueTitle.Name = "lblRevenueTitle";
        lblRevenueTitle.Size = new Size(81, 17);
        lblRevenueTitle.TabIndex = 1;
        lblRevenueTitle.Text = "REVENUE";
        // 
        // lblRevenueValue
        // 
        lblRevenueValue.AutoSize = true;
        lblRevenueValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblRevenueValue.ForeColor = Color.FromArgb(40, 200, 120);
        lblRevenueValue.Location = new Point(14, 36);
        lblRevenueValue.Name = "lblRevenueValue";
        lblRevenueValue.Size = new Size(45, 41);
        lblRevenueValue.TabIndex = 2;
        lblRevenueValue.Text = "৳0";
        // 
        // cardPending
        // 
        cardPending.BackColor = Color.FromArgb(30, 40, 58);
        cardPending.Controls.Add(barPending);
        cardPending.Controls.Add(lblPendingTitle);
        cardPending.Controls.Add(lblPendingValue);
        cardPending.Location = new Point(520, 50);
        cardPending.Name = "cardPending";
        cardPending.Size = new Size(180, 90);
        cardPending.TabIndex = 4;
        // 
        // barPending
        // 
        barPending.BackColor = Color.FromArgb(255, 140, 0);
        barPending.Location = new Point(0, 0);
        barPending.Name = "barPending";
        barPending.Size = new Size(4, 90);
        // 
        // lblPendingTitle
        // 
        lblPendingTitle.AutoSize = true;
        lblPendingTitle.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
        lblPendingTitle.ForeColor = Color.FromArgb(130, 150, 180);
        lblPendingTitle.Location = new Point(14, 14);
        lblPendingTitle.Name = "lblPendingTitle";
        lblPendingTitle.Size = new Size(77, 17);
        lblPendingTitle.TabIndex = 1;
        lblPendingTitle.Text = "PENDING";
        // 
        // lblPendingValue
        // 
        lblPendingValue.AutoSize = true;
        lblPendingValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblPendingValue.ForeColor = Color.FromArgb(255, 140, 0);
        lblPendingValue.Location = new Point(14, 36);
        lblPendingValue.Name = "lblPendingValue";
        lblPendingValue.Size = new Size(34, 41);
        lblPendingValue.TabIndex = 2;
        lblPendingValue.Text = "0";
        // 
        // cardTodaySales
        // 
        cardTodaySales.BackColor = Color.FromArgb(30, 40, 58);
        cardTodaySales.Controls.Add(barTodaySales);
        cardTodaySales.Controls.Add(lblTodaySalesTitle);
        cardTodaySales.Controls.Add(lblTodaySalesValue);
        cardTodaySales.Location = new Point(715, 50);
        cardTodaySales.Name = "cardTodaySales";
        cardTodaySales.Size = new Size(180, 90);
        cardTodaySales.TabIndex = 5;
        // 
        // barTodaySales
        // 
        barTodaySales.BackColor = Color.FromArgb(255, 193, 7);
        barTodaySales.Location = new Point(0, 0);
        barTodaySales.Name = "barTodaySales";
        barTodaySales.Size = new Size(4, 90);
        // 
        // lblTodaySalesTitle
        // 
        lblTodaySalesTitle.AutoSize = true;
        lblTodaySalesTitle.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
        lblTodaySalesTitle.ForeColor = Color.FromArgb(130, 150, 180);
        lblTodaySalesTitle.Location = new Point(14, 14);
        lblTodaySalesTitle.Name = "lblTodaySalesTitle";
        lblTodaySalesTitle.Size = new Size(96, 17);
        lblTodaySalesTitle.TabIndex = 1;
        lblTodaySalesTitle.Text = "TODAY SALES";
        // 
        // lblTodaySalesValue
        // 
        lblTodaySalesValue.AutoSize = true;
        lblTodaySalesValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTodaySalesValue.ForeColor = Color.FromArgb(255, 193, 7);
        lblTodaySalesValue.Location = new Point(14, 36);
        lblTodaySalesValue.Name = "lblTodaySalesValue";
        lblTodaySalesValue.Size = new Size(45, 41);
        lblTodaySalesValue.TabIndex = 2;
        lblTodaySalesValue.Text = "৳0";
        // 
        // lblMonthlyTitle
        // 
        lblMonthlyTitle.AutoSize = true;
        lblMonthlyTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblMonthlyTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblMonthlyTitle.Location = new Point(0, 160);
        lblMonthlyTitle.Name = "lblMonthlyTitle";
        lblMonthlyTitle.Size = new Size(225, 30);
        lblMonthlyTitle.TabIndex = 6;
        lblMonthlyTitle.Text = "Monthly Sales Report";
        // 
        // grid
        // 
        grid.BackgroundColor = Color.FromArgb(30, 40, 58);
        grid.BorderStyle = BorderStyle.None;
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        grid.ColumnHeadersHeight = 36;
        grid.Font = new Font("Segoe UI", 9.5F);
        grid.ForeColor = Color.FromArgb(230, 240, 255);
        grid.GridColor = Color.FromArgb(45, 60, 85);
        grid.Location = new Point(0, 200);
        grid.Name = "grid";
        grid.ReadOnly = true;
        grid.RowHeadersVisible = false;
        grid.RowTemplate.Height = 30;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.Size = new Size(1000, 400);
        grid.TabIndex = 7;
        grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        // 
        // ReportsPanel
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 20, 30);
        Controls.Add(lblTitle);
        Controls.Add(btnRefresh);
        Controls.Add(cardTotalOrders);
        Controls.Add(cardRevenue);
        Controls.Add(cardPending);
        Controls.Add(cardTodaySales);
        Controls.Add(lblMonthlyTitle);
        Controls.Add(grid);
        Name = "ReportsPanel";
        Size = new Size(1000, 600);
        cardTotalOrders.ResumeLayout(false);
        cardTotalOrders.PerformLayout();
        cardRevenue.ResumeLayout(false);
        cardRevenue.PerformLayout();
        cardPending.ResumeLayout(false);
        cardPending.PerformLayout();
        cardTodaySales.ResumeLayout(false);
        cardTodaySales.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)grid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
