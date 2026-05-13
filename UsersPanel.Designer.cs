namespace FuelMS.Forms;

partial class UsersPanel
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private System.Windows.Forms.Label lblTitle = null!;
    private System.Windows.Forms.Button btnAdd = null!;
    private System.Windows.Forms.Button btnEdit = null!;
    private System.Windows.Forms.Button btnDel = null!;
    private System.Windows.Forms.Button btnRefresh = null!;
    private System.Windows.Forms.DataGridView grid = null!;

    private void InitializeComponent()
    {
        lblTitle = new Label();
        btnAdd = new Button();
        btnEdit = new Button();
        btnDel = new Button();
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
        lblTitle.Size = new Size(100, 46);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Users";
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.FromArgb(40, 200, 120);
        btnAdd.Cursor = Cursors.Hand;
        btnAdd.FlatAppearance.BorderSize = 0;
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(0, 50);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(100, 40);
        btnAdd.TabIndex = 1;
        btnAdd.Text = "+ Add";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnEdit
        // 
        btnEdit.BackColor = Color.FromArgb(0, 120, 215);
        btnEdit.Cursor = Cursors.Hand;
        btnEdit.FlatAppearance.BorderSize = 0;
        btnEdit.FlatStyle = FlatStyle.Flat;
        btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnEdit.ForeColor = Color.White;
        btnEdit.Location = new Point(110, 50);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(100, 40);
        btnEdit.TabIndex = 2;
        btnEdit.Text = "✏ Edit";
        btnEdit.UseVisualStyleBackColor = false;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnDel
        // 
        btnDel.BackColor = Color.FromArgb(220, 53, 69);
        btnDel.Cursor = Cursors.Hand;
        btnDel.FlatAppearance.BorderSize = 0;
        btnDel.FlatStyle = FlatStyle.Flat;
        btnDel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDel.ForeColor = Color.White;
        btnDel.Location = new Point(220, 50);
        btnDel.Name = "btnDel";
        btnDel.Size = new Size(100, 40);
        btnDel.TabIndex = 3;
        btnDel.Text = "🗑 Delete";
        btnDel.UseVisualStyleBackColor = false;
        btnDel.Click += btnDel_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.FromArgb(30, 40, 58);
        btnRefresh.Cursor = Cursors.Hand;
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRefresh.ForeColor = Color.FromArgb(230, 240, 255);
        btnRefresh.Location = new Point(330, 50);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(110, 40);
        btnRefresh.TabIndex = 4;
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
        grid.TabIndex = 5;
        grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        // 
        // UsersPanel
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 20, 30);
        Controls.Add(lblTitle);
        Controls.Add(btnAdd);
        Controls.Add(btnEdit);
        Controls.Add(btnDel);
        Controls.Add(btnRefresh);
        Controls.Add(grid);
        Name = "UsersPanel";
        Size = new Size(1000, 600);
        ((System.ComponentModel.ISupportInitialize)grid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
