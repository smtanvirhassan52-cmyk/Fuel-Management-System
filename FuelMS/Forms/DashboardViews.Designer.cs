namespace FuelMS.Forms;

partial class DashboardView
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
    private System.Windows.Forms.Panel cardTotalUsers = null!;
    private System.Windows.Forms.Label lblTotalUsersTitle = null!;
    private System.Windows.Forms.Label lblTotalUsersValue = null!;
    private System.Windows.Forms.Panel barTotalUsers = null!;
    private System.Windows.Forms.Panel cardTotalAdmins = null!;
    private System.Windows.Forms.Label lblTotalAdminsTitle = null!;
    private System.Windows.Forms.Label lblTotalAdminsValue = null!;
    private System.Windows.Forms.Panel barTotalAdmins = null!;
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
    private System.Windows.Forms.Label lblRecentOrdersTitle = null!;
    private System.Windows.Forms.Label lblFuelStockTitle = null!;
    private System.Windows.Forms.Panel panelFuelStock = null!;
    private System.Windows.Forms.DataGridView gridRecentOrders = null!;

    private void InitializeComponent()
    {
        lblTitle = new Label();
        btnRefresh = new Button();
        cardTotalUsers = new Panel();
        barTotalUsers = new Panel();
        lblTotalUsersTitle = new Label();
        lblTotalUsersValue = new Label();
        cardTotalAdmins = new Panel();
        barTotalAdmins = new Panel();
        lblTotalAdminsTitle = new Label();
        lblTotalAdminsValue = new Label();
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
        lblRecentOrdersTitle = new Label();
        gridRecentOrders = new DataGridView();
        lblFuelStockTitle = new Label();
        panelFuelStock = new Panel();
        cardTotalUsers.SuspendLayout();
        cardTotalAdmins.SuspendLayout();
        cardTotalOrders.SuspendLayout();
        cardRevenue.SuspendLayout();
        cardPending.SuspendLayout();
        cardTodaySales.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridRecentOrders).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(302, 46);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Dashboard Overview";
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.FromArgb(30, 40, 58);
        btnRefresh.Cursor = Cursors.Hand;
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRefresh.ForeColor = Color.FromArgb(230, 240, 255);
        btnRefresh.Location = new Point(320, 10);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(110, 40);
        btnRefresh.TabIndex = 1;
        btnRefresh.Text = "↺ Refresh";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // cardTotalUsers
        // 
        cardTotalUsers.BackColor = Color.FromArgb(30, 40, 58);
        cardTotalUsers.Controls.Add(barTotalUsers);
        cardTotalUsers.Controls.Add(lblTotalUsersTitle);
        cardTotalUsers.Controls.Add(lblTotalUsersValue);
        cardTotalUsers.Location = new Point(10, 60);
        cardTotalUsers.Name = "cardTotalUsers";
        cardTotalUsers.Size = new Size(180, 90);
        cardTotalUsers.TabIndex = 2;
        // 
        // barTotalUsers
        // 
        barTotalUsers.BackColor = Color.FromArgb(0, 120, 215);
        barTotalUsers.Location = new Point(0, 0);
        barTotalUsers.Name = "barTotalUsers";
        barTotalUsers.Size = new Size(4, 90);
        // 
        // lblTotalUsersTitle
        // 
        lblTotalUsersTitle.AutoSize = true;
        lblTotalUsersTitle.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
        lblTotalUsersTitle.ForeColor = Color.FromArgb(130, 150, 180);
        lblTotalUsersTitle.Location = new Point(14, 14);
        lblTotalUsersTitle.Name = "lblTotalUsersTitle";
        lblTotalUsersTitle.Size = new Size(86, 17);
        lblTotalUsersTitle.TabIndex = 1;
        lblTotalUsersTitle.Text = "TOTAL USERS";
        // 
        // lblTotalUsersValue
        // 
        lblTotalUsersValue.AutoSize = true;
        lblTotalUsersValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTotalUsersValue.ForeColor = Color.FromArgb(0, 120, 215);
        lblTotalUsersValue.Location = new Point(14, 36);
        lblTotalUsersValue.Name = "lblTotalUsersValue";
        lblTotalUsersValue.Size = new Size(34, 41);
        lblTotalUsersValue.TabIndex = 2;
        lblTotalUsersValue.Text = "0";
        // 
        // cardTotalAdmins
        // 
        cardTotalAdmins.BackColor = Color.FromArgb(30, 40, 58);
        cardTotalAdmins.Controls.Add(barTotalAdmins);
        cardTotalAdmins.Controls.Add(lblTotalAdminsTitle);
        cardTotalAdmins.Controls.Add(lblTotalAdminsValue);
        cardTotalAdmins.Location = new Point(205, 60);
        cardTotalAdmins.Name = "cardTotalAdmins";
        cardTotalAdmins.Size = new Size(180, 90);
        cardTotalAdmins.TabIndex = 3;
        // 
        // barTotalAdmins
        // 
        barTotalAdmins.BackColor = Color.FromArgb(255, 140, 0);
        barTotalAdmins.Location = new Point(0, 0);
        barTotalAdmins.Name = "barTotalAdmins";
        barTotalAdmins.Size = new Size(4, 90);
        // 
        // lblTotalAdminsTitle
        // 
        lblTotalAdminsTitle.AutoSize = true;
        lblTotalAdminsTitle.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
        lblTotalAdminsTitle.ForeColor = Color.FromArgb(130, 150, 180);
        lblTotalAdminsTitle.Location = new Point(14, 14);
        lblTotalAdminsTitle.Name = "lblTotalAdminsTitle";
        lblTotalAdminsTitle.Size = new Size(103, 17);
        lblTotalAdminsTitle.TabIndex = 1;
        lblTotalAdminsTitle.Text = "TOTAL ADMINS";
        // 
        // lblTotalAdminsValue
        // 
        lblTotalAdminsValue.AutoSize = true;
        lblTotalAdminsValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTotalAdminsValue.ForeColor = Color.FromArgb(255, 140, 0);
        lblTotalAdminsValue.Location = new Point(14, 36);
        lblTotalAdminsValue.Name = "lblTotalAdminsValue";
        lblTotalAdminsValue.Size = new Size(34, 41);
        lblTotalAdminsValue.TabIndex = 2;
        lblTotalAdminsValue.Text = "0";
        // 
        // cardTotalOrders
        // 
        cardTotalOrders.BackColor = Color.FromArgb(30, 40, 58);
        cardTotalOrders.Controls.Add(barTotalOrders);
        cardTotalOrders.Controls.Add(lblTotalOrdersTitle);
        cardTotalOrders.Controls.Add(lblTotalOrdersValue);
        cardTotalOrders.Location = new Point(400, 60);
        cardTotalOrders.Name = "cardTotalOrders";
        cardTotalOrders.Size = new Size(180, 90);
        cardTotalOrders.TabIndex = 4;
        // 
        // barTotalOrders
        // 
        barTotalOrders.BackColor = Color.FromArgb(40, 200, 120);
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
        lblTotalOrdersTitle.Size = new Size(107, 17);
        lblTotalOrdersTitle.TabIndex = 1;
        lblTotalOrdersTitle.Text = "TOTAL ORDERS";
        // 
        // lblTotalOrdersValue
        // 
        lblTotalOrdersValue.AutoSize = true;
        lblTotalOrdersValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTotalOrdersValue.ForeColor = Color.FromArgb(40, 200, 120);
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
        cardRevenue.Location = new Point(595, 60);
        cardRevenue.Name = "cardRevenue";
        cardRevenue.Size = new Size(180, 90);
        cardRevenue.TabIndex = 5;
        // 
        // barRevenue
        // 
        barRevenue.BackColor = Color.FromArgb(255, 193, 7);
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
        lblRevenueTitle.Size = new Size(96, 17);
        lblRevenueTitle.TabIndex = 1;
        lblRevenueTitle.Text = "REVENUE (৳)";
        // 
        // lblRevenueValue
        // 
        lblRevenueValue.AutoSize = true;
        lblRevenueValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblRevenueValue.ForeColor = Color.FromArgb(255, 193, 7);
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
        cardPending.Location = new Point(790, 60);
        cardPending.Name = "cardPending";
        cardPending.Size = new Size(180, 90);
        cardPending.TabIndex = 6;
        // 
        // barPending
        // 
        barPending.BackColor = Color.FromArgb(220, 53, 69);
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
        lblPendingValue.ForeColor = Color.FromArgb(220, 53, 69);
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
        cardTodaySales.Location = new Point(985, 60);
        cardTodaySales.Name = "cardTodaySales";
        cardTodaySales.Size = new Size(180, 90);
        cardTodaySales.TabIndex = 7;
        // 
        // barTodaySales
        // 
        barTodaySales.BackColor = Color.FromArgb(40, 200, 120);
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
        lblTodaySalesValue.ForeColor = Color.FromArgb(40, 200, 120);
        lblTodaySalesValue.Location = new Point(14, 36);
        lblTodaySalesValue.Name = "lblTodaySalesValue";
        lblTodaySalesValue.Size = new Size(45, 41);
        lblTodaySalesValue.TabIndex = 2;
        lblTodaySalesValue.Text = "৳0";
        // 
        // lblRecentOrdersTitle
        // 
        lblRecentOrdersTitle.AutoSize = true;
        lblRecentOrdersTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblRecentOrdersTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblRecentOrdersTitle.Location = new Point(10, 175);
        lblRecentOrdersTitle.Name = "lblRecentOrdersTitle";
        lblRecentOrdersTitle.Size = new Size(165, 30);
        lblRecentOrdersTitle.TabIndex = 8;
        lblRecentOrdersTitle.Text = "Recent Orders";
        // 
        // gridRecentOrders
        // 
        gridRecentOrders.BackgroundColor = Color.FromArgb(30, 40, 58);
        gridRecentOrders.BorderStyle = BorderStyle.None;
        gridRecentOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridRecentOrders.ColumnHeadersHeight = 36;
        gridRecentOrders.Font = new Font("Segoe UI", 9.5F);
        gridRecentOrders.ForeColor = Color.FromArgb(230, 240, 255);
        gridRecentOrders.GridColor = Color.FromArgb(45, 60, 85);
        gridRecentOrders.Location = new Point(10, 215);
        gridRecentOrders.Name = "gridRecentOrders";
        gridRecentOrders.ReadOnly = true;
        gridRecentOrders.RowHeadersVisible = false;
        gridRecentOrders.RowTemplate.Height = 30;
        gridRecentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridRecentOrders.Size = new Size(750, 250);
        gridRecentOrders.TabIndex = 9;
        gridRecentOrders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        // 
        // lblFuelStockTitle
        // 
        lblFuelStockTitle.AutoSize = true;
        lblFuelStockTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblFuelStockTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblFuelStockTitle.Location = new Point(780, 175);
        lblFuelStockTitle.Name = "lblFuelStockTitle";
        lblFuelStockTitle.Size = new Size(126, 30);
        lblFuelStockTitle.TabIndex = 10;
        lblFuelStockTitle.Text = "Fuel Stock";
        // 
        // panelFuelStock
        // 
        panelFuelStock.AutoScroll = true;
        panelFuelStock.Location = new Point(780, 215);
        panelFuelStock.Name = "panelFuelStock";
        panelFuelStock.Size = new Size(260, 250);
        panelFuelStock.TabIndex = 11;
        // 
        // DashboardView
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 20, 30);
        Controls.Add(lblTitle);
        Controls.Add(btnRefresh);
        Controls.Add(cardTotalUsers);
        Controls.Add(cardTotalAdmins);
        Controls.Add(cardTotalOrders);
        Controls.Add(cardRevenue);
        Controls.Add(cardPending);
        Controls.Add(cardTodaySales);
        Controls.Add(lblRecentOrdersTitle);
        Controls.Add(gridRecentOrders);
        Controls.Add(lblFuelStockTitle);
        Controls.Add(panelFuelStock);
        Name = "DashboardView";
        Size = new Size(1200, 500);
        Padding = new Padding(10);
        cardTotalUsers.ResumeLayout(false);
        cardTotalUsers.PerformLayout();
        cardTotalAdmins.ResumeLayout(false);
        cardTotalAdmins.PerformLayout();
        cardTotalOrders.ResumeLayout(false);
        cardTotalOrders.PerformLayout();
        cardRevenue.ResumeLayout(false);
        cardRevenue.PerformLayout();
        cardPending.ResumeLayout(false);
        cardPending.PerformLayout();
        cardTodaySales.ResumeLayout(false);
        cardTodaySales.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridRecentOrders).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
