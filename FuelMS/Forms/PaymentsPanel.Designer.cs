namespace FuelMS.Forms;

partial class PaymentsPanel
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
    private System.Windows.Forms.DataGridView grid = null!;

    private void InitializeComponent()
    {
        lblTitle = new Label();
        btnRefresh = new Button();
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
        lblTitle.Text = "Payments";
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
        grid.TabIndex = 2;
        grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        // 
        // PaymentsPanel
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 20, 30);
        Controls.Add(lblTitle);
        Controls.Add(btnRefresh);
        Controls.Add(grid);
        Name = "PaymentsPanel";
        Size = new Size(1000, 600);
        ((System.ComponentModel.ISupportInitialize)grid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
