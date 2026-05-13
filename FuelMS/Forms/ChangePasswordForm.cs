using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class ChangePasswordForm : Form
{
    private readonly bool _isLoggedIn;

    public ChangePasswordForm(bool isLoggedIn = false)
    {
        _isLoggedIn = isLoggedIn;
        InitializeComponent();

        if (isLoggedIn && Session.CurrentUser != null)
        {
            txtEmail.Text = Session.CurrentUser.Email;
            txtEmail.ReadOnly = true;
            Text = "Change Password";
            lblTitle.Text = "Change Password";
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        string email = txtEmail.Text.Trim();
        string pass  = txtNewPassword.Text;
        string conf  = txtConfirm.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
        { lblError.Text = "All fields required."; return; }
        if (pass != conf) { lblError.Text = "Passwords do not match."; return; }
        if (pass.Length < 6) { lblError.Text = "Password must be at least 6 characters."; return; }
        if (!UserService.EmailExists(email)) { lblError.Text = "Email not found."; return; }

        var users = UserService.GetAllUsers();
        var user = users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        if (user == null) { lblError.Text = "User not found."; return; }

        UserService.ChangePassword(user.UserID, pass);
        MessageBox.Show("Password updated successfully!", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        Close();
    }
}
