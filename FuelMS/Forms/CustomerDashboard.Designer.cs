namespace FuelMS.Forms;

partial class CustomerDashboard
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
        this.SuspendLayout();
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1200, 750);
        this.MinimumSize = new System.Drawing.Size(1000, 650);
        this.Name = "CustomerDashboard";
        this.Text = "CustomerDashboard";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.ResumeLayout(false);
    }
}
