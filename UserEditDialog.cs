using FuelMS.Helpers;
using FuelMS.Models;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class UserEditDialog : Form
{
    private User? existing;
    private bool canSetRole;
    private int defaultRole;

    public UserEditDialog(User? user, bool canRole, int defRole)
    {
        InitializeComponent();
        existing = user;
        canSetRole = canRole;
        defaultRole = defRole;
        Text = user == null ? "Add User" : "Edit User";
        lblTitle.Text = Text;

        cmbRole.Enabled = canSetRole || Session.CurrentUser?.RoleID == 1;

        if (user != null)
        {
            txtName.Text = user.Name; txtEmail.Text = user.Email; txtPhone.Text = user.Phone;
            txtLimit.Text = user.LimitPerMonth.ToString();
            cmbRole.SelectedIndex = user.RoleID - 1;
            cmbStatus.SelectedIndex = user.Status == "Active" ? 0 : 1;
        }
        else
        {
            cmbRole.SelectedIndex = Math.Max(0, defaultRole - 1);
            cmbStatus.SelectedIndex = 0;
            txtLimit.Text = "100";
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        lblErr.Text = "";
        if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text))
        { lblErr.Text = "Name and Email required."; return; }

        int roleId = (cmbRole.SelectedIndex + 1);
        decimal limit = decimal.TryParse(txtLimit.Text, out var l) ? l : 100;

        if (existing == null)
        {
            if (string.IsNullOrEmpty(txtPass.Text)) { lblErr.Text = "Password required."; return; }
            var newUser = new User { Name = txtName.Text.Trim(), Email = txtEmail.Text.Trim(), Phone = txtPhone.Text.Trim(), RoleID = roleId, LimitPerMonth = limit, Status = "Active" };
            bool ok = UserService.AddUser(newUser, txtPass.Text);
            if (!ok) { lblErr.Text = "Email already exists."; return; }
            LogService.Log(Session.CurrentUser!.UserID, "AddUser", $"Added: {newUser.Name}");
        }
        else
        {
            existing.Name = txtName.Text.Trim(); existing.Email = txtEmail.Text.Trim();
            existing.Phone = txtPhone.Text.Trim(); existing.RoleID = roleId;
            existing.LimitPerMonth = limit; existing.Status = cmbStatus.SelectedItem?.ToString() ?? "Active";
            UserService.UpdateUser(existing);
            LogService.Log(Session.CurrentUser!.UserID, "EditUser", $"Edited: {existing.Name}");
        }
        DialogResult = DialogResult.OK;
        Close();
    }
}
