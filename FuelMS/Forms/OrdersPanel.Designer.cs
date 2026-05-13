namespace FuelMS.Forms;

partial class OrdersPanel
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private System.Windows.Forms.Label lblTitle = null!;
    private System.Windows.Forms.Button btnApprove = null!;
    private System.Windows.Forms.Button btnReject = null!;
    private System.Windows.Forms.Button btnCancelAdmin = null!;
    private System.Windows.Forms.Button btnCancelUser = null!;
    private System.Windows.Forms.Label lblFilter = null!;
    private System.Windows.Forms.ComboBox cmbFilter = null!;

    private void InitializeComponent()
    {
        lblTitle = new Label();
        btnApprove = new Button();
        btnReject = new Button();
        btnCancelAdmin = new Button();
        btnCancelUser = new Button();
        lblFilter = new Label();
        cmbFilter = new ComboBox();
        grid = new DataGridView();
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
        lblTitle.Size = new Size(155, 46);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "All Orders";
        // 
        // btnApprove
        // 
        btnApprove.BackColor = Color.FromArgb(40, 200, 120);
        btnApprove.Cursor = Cursors.Hand;
        btnApprove.FlatAppearance.BorderSize = 0;
        btnApprove.FlatStyle = FlatStyle.Flat;
        btnApprove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnApprove.ForeColor = Color.White;
        btnApprove.Location = new Point(0, 50);
        btnApprove.Name = "btnApprove";
        btnApprove.Size = new Size(120, 40);
        btnApprove.TabIndex = 1;
        btnApprove.Text = "✔ Approve";
        btnApprove.UseVisualStyleBackColor = false;
        btnApprove.Click += btnApprove_Click;
        // 
        // btnReject
        // 
        btnReject.BackColor = Color.FromArgb(220, 53, 69);
        btnReject.Cursor = Cursors.Hand;
        btnReject.FlatAppearance.BorderSize = 0;
        btnReject.FlatStyle = FlatStyle.Flat;
        btnReject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnReject.ForeColor = Color.White;
        btnReject.Location = new Point(130, 50);
        btnReject.Name = "btnReject";
        btnReject.Size = new Size(110, 40);
        btnReject.TabIndex = 2;
        btnReject.Text = "✘ Reject";
        btnReject.UseVisualStyleBackColor = false;
        btnReject.Click += btnReject_Click;
        // 
        // btnCancelAdmin
        // 
        btnCancelAdmin.BackColor = Color.FromArgb(255, 140, 0);
        btnCancelAdmin.Cursor = Cursors.Hand;
        btnCancelAdmin.FlatAppearance.BorderSize = 0;
        btnCancelAdmin.FlatStyle = FlatStyle.Flat;
        btnCancelAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnCancelAdmin.ForeColor = Color.White;
        btnCancelAdmin.Location = new Point(250, 50);
        btnCancelAdmin.Name = "btnCancelAdmin";
        btnCancelAdmin.Size = new Size(110, 40);
        btnCancelAdmin.TabIndex = 3;
        btnCancelAdmin.Text = "⊘ Cancel";
        btnCancelAdmin.UseVisualStyleBackColor = false;
        btnCancelAdmin.Click += btnCancelAdmin_Click;
        // 
        // btnCancelUser
        // 
        btnCancelUser.BackColor = Color.FromArgb(220, 53, 69);
        btnCancelUser.Cursor = Cursors.Hand;
        btnCancelUser.FlatAppearance.BorderSize = 0;
        btnCancelUser.FlatStyle = FlatStyle.Flat;
        btnCancelUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnCancelUser.ForeColor = Color.White;
        btnCancelUser.Location = new Point(0, 50);
        btnCancelUser.Name = "btnCancelUser";
        btnCancelUser.Size = new Size(120, 40);
        btnCancelUser.TabIndex = 4;
        btnCancelUser.Text = "⊘ Cancel";
        btnCancelUser.UseVisualStyleBackColor = false;
        btnCancelUser.Click += btnCancelUser_Click;
        // 
        // lblFilter
        // 
        lblFilter.AutoSize = true;
        lblFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblFilter.ForeColor = Color.FromArgb(130, 150, 180);
        lblFilter.Location = new Point(500, 58);
        lblFilter.Name = "lblFilter";
        lblFilter.Size = new Size(56, 20);
        lblFilter.TabIndex = 5;
        lblFilter.Text = "Filter:";
        // 
        // cmbFilter
        // 
        cmbFilter.BackColor = Color.FromArgb(20, 28, 42);
        cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFilter.Font = new Font("Segoe UI", 9.5F);
        cmbFilter.ForeColor = Color.FromArgb(230, 240, 255);
        cmbFilter.FormattingEnabled = true;
        cmbFilter.Items.AddRange(new object[] { "All", "Pending", "Approved", "Rejected", "Cancelled" });
        cmbFilter.Location = new Point(560, 55);
        cmbFilter.Name = "cmbFilter";
        cmbFilter.Size = new Size(140, 29);
        cmbFilter.TabIndex = 6;
        cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
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
        grid.Location = new Point(0, 100);
        grid.Name = "grid";
        grid.ReadOnly = true;
        grid.RowHeadersVisible = false;
        grid.RowTemplate.Height = 30;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.Size = new Size(1000, 500);
        grid.TabIndex = 7;
        grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        // 
        // OrdersPanel
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 20, 30);
        Controls.Add(lblTitle);
        Controls.Add(btnApprove);
        Controls.Add(btnReject);
        Controls.Add(btnCancelAdmin);
        Controls.Add(btnCancelUser);
        Controls.Add(lblFilter);
        Controls.Add(cmbFilter);
        Controls.Add(grid);
        Name = "OrdersPanel";
        Size = new Size(1000, 600);
        ((System.ComponentModel.ISupportInitialize)grid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
