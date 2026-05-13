namespace FuelMS.Forms;

partial class CustomerDashboardView
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private System.Windows.Forms.Label lblWelcome = null!;
    private System.Windows.Forms.Button btnRefresh = null!;
    private System.Windows.Forms.Panel cardLimit = null!;
    private System.Windows.Forms.Label lblLimitTitle = null!;
    private System.Windows.Forms.Label lblLimit = null!;
    private System.Windows.Forms.Label lblUsed = null!;
    private System.Windows.Forms.Label lblRemaining = null!;
    private System.Windows.Forms.Panel progressBarBg = null!;
    private System.Windows.Forms.Panel progressBarFill = null!;
    private System.Windows.Forms.Panel cardQuickActions = null!;
    private System.Windows.Forms.Label lblQuickActionsTitle = null!;
    private System.Windows.Forms.Button btnPlaceOrder = null!;
    private System.Windows.Forms.Button btnOrderHistory = null!;
    private System.Windows.Forms.Label lblMyOrdersTitle = null!;
    private System.Windows.Forms.Panel panelLastOrder = null!;
    private System.Windows.Forms.Label lblLastOrderTitle = null!;
    private System.Windows.Forms.Label lblLastFuel = null!;
    private System.Windows.Forms.Label lblLastQty = null!;
    private System.Windows.Forms.Label lblLastAmount = null!;
    private System.Windows.Forms.Label lblLastStatus = null!;
    private System.Windows.Forms.Label lblLastDate = null!;
    private System.Windows.Forms.DataGridView gridMyOrders = null!;

    private void InitializeComponent()
    {
        lblWelcome = new Label();
        btnRefresh = new Button();
        cardLimit = new Panel();
        lblLimitTitle = new Label();
        lblLimit = new Label();
        lblUsed = new Label();
        lblRemaining = new Label();
        progressBarBg = new Panel();
        progressBarFill = new Panel();
        cardQuickActions = new Panel();
        lblQuickActionsTitle = new Label();
        btnPlaceOrder = new Button();
        btnOrderHistory = new Button();
        lblMyOrdersTitle = new Label();
        gridMyOrders = new DataGridView();
        panelLastOrder = new Panel();
        lblLastOrderTitle = new Label();
        lblLastFuel = new Label();
        lblLastQty = new Label();
        lblLastAmount = new Label();
        lblLastStatus = new Label();
        lblLastDate = new Label();
        cardLimit.SuspendLayout();
        cardQuickActions.SuspendLayout();
        progressBarBg.SuspendLayout();
        panelLastOrder.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridMyOrders).BeginInit();
        SuspendLayout();
        // 
        // lblWelcome
        // 
        lblWelcome.AutoSize = true;
        lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblWelcome.ForeColor = Color.FromArgb(230, 240, 255);
        lblWelcome.Location = new Point(10, 10);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new Size(275, 46);
        lblWelcome.TabIndex = 0;
        lblWelcome.Text = "Welcome, User!";
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.FromArgb(30, 40, 58);
        btnRefresh.Cursor = Cursors.Hand;
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRefresh.ForeColor = Color.FromArgb(230, 240, 255);
        btnRefresh.Location = new Point(300, 18);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(110, 40);
        btnRefresh.TabIndex = 1;
        btnRefresh.Text = "↺ Refresh";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // cardLimit
        // 
        cardLimit.BackColor = Color.FromArgb(30, 40, 58);
        cardLimit.Controls.Add(lblLimitTitle);
        cardLimit.Controls.Add(lblLimit);
        cardLimit.Controls.Add(lblUsed);
        cardLimit.Controls.Add(lblRemaining);
        cardLimit.Controls.Add(progressBarBg);
        cardLimit.Location = new Point(10, 70);
        cardLimit.Name = "cardLimit";
        cardLimit.Padding = new Padding(15);
        cardLimit.Size = new Size(360, 180);
        cardLimit.TabIndex = 2;
        // 
        // lblLimitTitle
        // 
        lblLimitTitle.AutoSize = true;
        lblLimitTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblLimitTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblLimitTitle.Location = new Point(15, 12);
        lblLimitTitle.Name = "lblLimitTitle";
        lblLimitTitle.Size = new Size(156, 30);
        lblLimitTitle.TabIndex = 0;
        lblLimitTitle.Text = "Monthly Limit";
        // 
        // lblLimit
        // 
        lblLimit.AutoSize = true;
        lblLimit.Font = new Font("Segoe UI", 9.5F);
        lblLimit.ForeColor = Color.FromArgb(230, 240, 255);
        lblLimit.Location = new Point(15, 50);
        lblLimit.Name = "lblLimit";
        lblLimit.Size = new Size(84, 21);
        lblLimit.TabIndex = 1;
        lblLimit.Text = "Limit: 0L";
        // 
        // lblUsed
        // 
        lblUsed.AutoSize = true;
        lblUsed.Font = new Font("Segoe UI", 9.5F);
        lblUsed.ForeColor = Color.FromArgb(255, 140, 0);
        lblUsed.Location = new Point(15, 80);
        lblUsed.Name = "lblUsed";
        lblUsed.Size = new Size(76, 21);
        lblUsed.TabIndex = 2;
        lblUsed.Text = "Used: 0L";
        // 
        // lblRemaining
        // 
        lblRemaining.AutoSize = true;
        lblRemaining.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblRemaining.ForeColor = Color.FromArgb(40, 200, 120);
        lblRemaining.Location = new Point(15, 115);
        lblRemaining.Name = "lblRemaining";
        lblRemaining.Size = new Size(172, 28);
        lblRemaining.TabIndex = 3;
        lblRemaining.Text = "Remaining: 0L";
        // 
        // progressBarBg
        // 
        progressBarBg.BackColor = Color.FromArgb(45, 60, 85);
        progressBarBg.Controls.Add(progressBarFill);
        progressBarBg.Location = new Point(15, 150);
        progressBarBg.Name = "progressBarBg";
        progressBarBg.Size = new Size(320, 12);
        progressBarBg.TabIndex = 4;
        // 
        // progressBarFill
        // 
        progressBarFill.BackColor = Color.FromArgb(40, 200, 120);
        progressBarFill.Location = new Point(0, 0);
        progressBarFill.Name = "progressBarFill";
        progressBarFill.Size = new Size(0, 12);
        // 
        // cardQuickActions
        // 
        cardQuickActions.BackColor = Color.FromArgb(30, 40, 58);
        cardQuickActions.Controls.Add(lblQuickActionsTitle);
        cardQuickActions.Controls.Add(btnPlaceOrder);
        cardQuickActions.Controls.Add(btnOrderHistory);
        cardQuickActions.Location = new Point(385, 70);
        cardQuickActions.Name = "cardQuickActions";
        cardQuickActions.Padding = new Padding(15);
        cardQuickActions.Size = new Size(300, 180);
        cardQuickActions.TabIndex = 3;
        // 
        // lblQuickActionsTitle
        // 
        lblQuickActionsTitle.AutoSize = true;
        lblQuickActionsTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblQuickActionsTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblQuickActionsTitle.Location = new Point(15, 12);
        lblQuickActionsTitle.Name = "lblQuickActionsTitle";
        lblQuickActionsTitle.Size = new Size(165, 30);
        lblQuickActionsTitle.TabIndex = 0;
        lblQuickActionsTitle.Text = "Quick Actions";
        // 
        // btnPlaceOrder
        // 
        btnPlaceOrder.BackColor = Color.FromArgb(40, 200, 120);
        btnPlaceOrder.Cursor = Cursors.Hand;
        btnPlaceOrder.FlatAppearance.BorderSize = 0;
        btnPlaceOrder.FlatStyle = FlatStyle.Flat;
        btnPlaceOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnPlaceOrder.ForeColor = Color.White;
        btnPlaceOrder.Location = new Point(15, 55);
        btnPlaceOrder.Name = "btnPlaceOrder";
        btnPlaceOrder.Size = new Size(260, 45);
        btnPlaceOrder.TabIndex = 1;
        btnPlaceOrder.Text = "\U0001f6d2 Place Order";
        btnPlaceOrder.UseVisualStyleBackColor = false;
        btnPlaceOrder.Click += btnPlaceOrder_Click;
        // 
        // btnOrderHistory
        // 
        btnOrderHistory.BackColor = Color.FromArgb(0, 120, 215);
        btnOrderHistory.Cursor = Cursors.Hand;
        btnOrderHistory.FlatAppearance.BorderSize = 0;
        btnOrderHistory.FlatStyle = FlatStyle.Flat;
        btnOrderHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnOrderHistory.ForeColor = Color.White;
        btnOrderHistory.Location = new Point(15, 115);
        btnOrderHistory.Name = "btnOrderHistory";
        btnOrderHistory.Size = new Size(260, 45);
        btnOrderHistory.TabIndex = 2;
        btnOrderHistory.Text = "\U0001f4cb Order History";
        btnOrderHistory.UseVisualStyleBackColor = false;
        btnOrderHistory.Click += btnOrderHistory_Click;
        // 
        // lblMyOrdersTitle
        // 
        lblMyOrdersTitle.AutoSize = true;
        lblMyOrdersTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblMyOrdersTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblMyOrdersTitle.Location = new Point(10, 270);
        lblMyOrdersTitle.Name = "lblMyOrdersTitle";
        lblMyOrdersTitle.Size = new Size(199, 30);
        lblMyOrdersTitle.TabIndex = 4;
        lblMyOrdersTitle.Text = "My Recent Orders";
        // 
        // gridMyOrders
        // 
        gridMyOrders.BackgroundColor = Color.FromArgb(30, 40, 58);
        gridMyOrders.BorderStyle = BorderStyle.None;
        gridMyOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridMyOrders.ColumnHeadersHeight = 36;
        gridMyOrders.Font = new Font("Segoe UI", 9.5F);
        gridMyOrders.ForeColor = Color.FromArgb(230, 240, 255);
        gridMyOrders.GridColor = Color.FromArgb(45, 60, 85);
        gridMyOrders.Location = new Point(10, 310);
        gridMyOrders.Name = "gridMyOrders";
        gridMyOrders.ReadOnly = true;
        gridMyOrders.RowHeadersVisible = false;
        gridMyOrders.RowTemplate.Height = 30;
        gridMyOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridMyOrders.Size = new Size(675, 220);
        gridMyOrders.TabIndex = 5;
        gridMyOrders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        // 
        // panelLastOrder
        // 
        panelLastOrder.BackColor = Color.FromArgb(30, 40, 58);
        panelLastOrder.Controls.Add(lblLastOrderTitle);
        panelLastOrder.Controls.Add(lblLastFuel);
        panelLastOrder.Controls.Add(lblLastQty);
        panelLastOrder.Controls.Add(lblLastAmount);
        panelLastOrder.Controls.Add(lblLastStatus);
        panelLastOrder.Controls.Add(lblLastDate);
        panelLastOrder.Location = new Point(700, 270);
        panelLastOrder.Name = "panelLastOrder";
        panelLastOrder.Padding = new Padding(15);
        panelLastOrder.Size = new Size(270, 200);
        panelLastOrder.TabIndex = 6;
        // 
        // lblLastOrderTitle
        // 
        lblLastOrderTitle.AutoSize = true;
        lblLastOrderTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblLastOrderTitle.ForeColor = Color.FromArgb(230, 240, 255);
        lblLastOrderTitle.Location = new Point(15, 12);
        lblLastOrderTitle.Name = "lblLastOrderTitle";
        lblLastOrderTitle.Size = new Size(126, 30);
        lblLastOrderTitle.TabIndex = 0;
        lblLastOrderTitle.Text = "Last Order";
        // 
        // lblLastFuel
        // 
        lblLastFuel.AutoSize = true;
        lblLastFuel.Font = new Font("Segoe UI", 8.5F);
        lblLastFuel.ForeColor = Color.FromArgb(130, 150, 180);
        lblLastFuel.Location = new Point(15, 50);
        lblLastFuel.Name = "lblLastFuel";
        lblLastFuel.Size = new Size(69, 19);
        lblLastFuel.TabIndex = 1;
        lblLastFuel.Text = "Fuel:    -";
        // 
        // lblLastQty
        // 
        lblLastQty.AutoSize = true;
        lblLastQty.Font = new Font("Segoe UI", 8.5F);
        lblLastQty.ForeColor = Color.FromArgb(130, 150, 180);
        lblLastQty.Location = new Point(15, 75);
        lblLastQty.Name = "lblLastQty";
        lblLastQty.Size = new Size(65, 19);
        lblLastQty.TabIndex = 2;
        lblLastQty.Text = "Qty:     -";
        // 
        // lblLastAmount
        // 
        lblLastAmount.AutoSize = true;
        lblLastAmount.Font = new Font("Segoe UI", 8.5F);
        lblLastAmount.ForeColor = Color.FromArgb(130, 150, 180);
        lblLastAmount.Location = new Point(15, 100);
        lblLastAmount.Name = "lblLastAmount";
        lblLastAmount.Size = new Size(96, 19);
        lblLastAmount.TabIndex = 3;
        lblLastAmount.Text = "Amount:  ৳0.00";
        // 
        // lblLastStatus
        // 
        lblLastStatus.AutoSize = true;
        lblLastStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblLastStatus.ForeColor = Color.FromArgb(130, 150, 180);
        lblLastStatus.Location = new Point(15, 130);
        lblLastStatus.Name = "lblLastStatus";
        lblLastStatus.Size = new Size(77, 20);
        lblLastStatus.TabIndex = 4;
        lblLastStatus.Text = "Status:  -";
        // 
        // lblLastDate
        // 
        lblLastDate.AutoSize = true;
        lblLastDate.Font = new Font("Segoe UI", 8.5F);
        lblLastDate.ForeColor = Color.FromArgb(130, 150, 180);
        lblLastDate.Location = new Point(15, 160);
        lblLastDate.Name = "lblLastDate";
        lblLastDate.Size = new Size(66, 19);
        lblLastDate.TabIndex = 5;
        lblLastDate.Text = "Date:    -";
        // 
        // CustomerDashboardView
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 20, 30);
        Controls.Add(lblWelcome);
        Controls.Add(btnRefresh);
        Controls.Add(cardLimit);
        Controls.Add(cardQuickActions);
        Controls.Add(lblMyOrdersTitle);
        Controls.Add(gridMyOrders);
        Controls.Add(panelLastOrder);
        Name = "CustomerDashboardView";
        Size = new Size(1000, 550);
        Padding = new Padding(10);
        cardLimit.ResumeLayout(false);
        cardLimit.PerformLayout();
        cardQuickActions.ResumeLayout(false);
        cardQuickActions.PerformLayout();
        progressBarBg.ResumeLayout(false);
        panelLastOrder.ResumeLayout(false);
        panelLastOrder.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridMyOrders).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
