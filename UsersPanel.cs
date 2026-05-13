using FuelMS.Helpers;
using FuelMS.Models;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class UsersPanel : UserControl
{
    private int roleFilter;
    private string panelTitle;
    private bool canSetRole;

    public UsersPanel(int roleFilter = 0, string title = "Users", bool canSetRole = true)
    {
        InitializeComponent();
        this.roleFilter = roleFilter;
        this.panelTitle = title;
        this.canSetRole = canSetRole;
        lblTitle.Text = panelTitle;
        LoadGrid();
    }

    private void btnAdd_Click(object sender, EventArgs e) => OpenAddEdit(null);
    private void btnEdit_Click(object sender, EventArgs e) => OpenAddEdit(GetSelected());
    private void btnDel_Click(object sender, EventArgs e) => DeleteSelected();
    private void btnRefresh_Click(object sender, EventArgs e) => LoadGrid();

    private void LoadGrid()
    {
        var users = UserService.GetAllUsers(roleFilter);
        grid.DataSource = users.Select(u => new
        {
            ID = u.UserID,
            Name = u.Name,
            Email = u.Email,
            Phone = u.Phone,
            Role = u.RoleName,
            Limit = $"{u.LimitPerMonth}L",
            Status = u.Status,
            Joined = u.CreatedAt.ToString("dd-MM-yyyy")
        }).ToList();
    }

    private User? GetSelected()
    {
        if (grid.SelectedRows.Count == 0) { MessageBox.Show("Select a row first."); return null; }
        int id = Convert.ToInt32(grid.SelectedRows[0].Cells["ID"].Value);
        return UserService.GetUserById(id);
    }

    private void OpenAddEdit(User? user)
    {
        var dlg = new UserEditDialog(user, canSetRole, roleFilter);
        if (dlg.ShowDialog() == DialogResult.OK) LoadGrid();
    }

    private void DeleteSelected()
    {
        var user = GetSelected();
        if (user == null) return;
        if (MessageBox.Show($"Deactivate {user.Name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            UserService.DeleteUser(user.UserID);
            LogService.Log(Session.CurrentUser!.UserID, "DeleteUser", $"Deactivated user: {user.Name}");
            LoadGrid();
        }
    }
}
