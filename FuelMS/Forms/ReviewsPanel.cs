using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class ReviewsPanel : UserControl
{
    private bool userOnly;

    public ReviewsPanel(bool userOnly = false)
    {
        InitializeComponent();
        this.userOnly = userOnly;
        btnAddReview.Visible = userOnly;
        LoadGrid();
    }

    private void btnAddReview_Click(object sender, EventArgs e) => OpenAddReview();
    private void btnRefresh_Click(object sender, EventArgs e) => LoadGrid();

    private void LoadGrid()
    {
        int uid = userOnly ? Session.CurrentUser!.UserID : 0;
        var reviews = ReviewService.GetReviews(uid);
        grid.DataSource = reviews.Select(r => new
        {
            ID = r.ReviewID,
            User = r.UserName,
            OrderID = r.OrderID,
            Rating = new string('★', r.Rating) + new string('☆', 5 - r.Rating),
            Comment = r.Comment,
            Date = r.ReviewDate.ToString("dd-MM-yyyy")
        }).ToList();
    }

    private void OpenAddReview()
    {
        var orders = OrderService.GetOrders(userId: Session.CurrentUser!.UserID, status: "Approved");
        var reviewedOrderIds = ReviewService.GetReviewedOrderIds(Session.CurrentUser!.UserID);
        var availableOrders = orders.Where(o => !reviewedOrderIds.Contains(o.OrderID)).ToList();

        if (!availableOrders.Any()) { MessageBox.Show("No approved orders available to review."); return; }

        var dlg = new Form
        {
            Text = "Add Review",
            Size = new Size(400, 360),
            BackColor = Color.FromArgb(15, 20, 30),
            StartPosition = FormStartPosition.CenterParent,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            MaximizeBox = false
        };

        var card = new Panel { BackColor = Color.FromArgb(30, 40, 58), Dock = DockStyle.Fill, Padding = new Padding(20) };
        var title = new Label { Text = "Write a Review", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.FromArgb(255, 140, 0), Location = new Point(20, 15), AutoSize = true };

        var lO = new Label { Text = "SELECT ORDER", Font = new Font("Segoe UI", 7.5f, FontStyle.Bold), ForeColor = Color.FromArgb(130, 150, 180), Location = new Point(20, 55), AutoSize = true };
        var cmbOrder = new ComboBox { Location = new Point(20, 73), Size = new Size(340, 28), DropDownStyle = ComboBoxStyle.DropDownList, BackColor = Color.FromArgb(20, 28, 42), ForeColor = Color.FromArgb(230, 240, 255), Font = new Font("Segoe UI", 9.5f) };
        foreach (var o in availableOrders) cmbOrder.Items.Add($"#{o.OrderID} — {o.FuelName} {o.Quantity}L — ৳{o.TotalPrice:F2}");
        cmbOrder.SelectedIndex = 0;

        var lR = new Label { Text = "RATING (1-5)", Font = new Font("Segoe UI", 7.5f, FontStyle.Bold), ForeColor = Color.FromArgb(130, 150, 180), Location = new Point(20, 115), AutoSize = true };
        var numRating = new NumericUpDown { Location = new Point(20, 133), Size = new Size(100, 28), Minimum = 1, Maximum = 5, Value = 5, BackColor = Color.FromArgb(20, 28, 42), ForeColor = Color.FromArgb(230, 240, 255), Font = new Font("Segoe UI", 9.5f) };

        var lC = new Label { Text = "COMMENT", Font = new Font("Segoe UI", 7.5f, FontStyle.Bold), ForeColor = Color.FromArgb(130, 150, 180), Location = new Point(20, 175), AutoSize = true };
        var txtComment = new TextBox { Location = new Point(20, 193), Size = new Size(340, 70), Multiline = true, BackColor = Color.FromArgb(20, 28, 42), ForeColor = Color.FromArgb(230, 240, 255), Font = new Font("Segoe UI", 9.5f), BorderStyle = BorderStyle.FixedSingle };

        var lblErr = new Label { ForeColor = Color.FromArgb(220, 53, 69), Font = new Font("Segoe UI", 8.5f), Location = new Point(20, 270), Size = new Size(340, 20) };
        var btnSave = new Button { Text = "SUBMIT REVIEW", BackColor = Color.FromArgb(40, 200, 120), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(20, 295), Size = new Size(340, 42), Cursor = Cursors.Hand };
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.Click += (s, e) =>
        {
            int orderId = availableOrders[cmbOrder.SelectedIndex].OrderID;
            bool ok = ReviewService.AddReview(Session.CurrentUser!.UserID, orderId, (int)numRating.Value, txtComment.Text.Trim());
            if (ok) { MessageBox.Show("Review submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); dlg.Close(); }
            else lblErr.Text = "Already reviewed this order.";
        };

        card.Controls.AddRange(new Control[] { title, lO, cmbOrder, lR, numRating, lC, txtComment, lblErr, btnSave });
        dlg.Controls.Add(card);
        dlg.ShowDialog();
        LoadGrid();
    }
}
