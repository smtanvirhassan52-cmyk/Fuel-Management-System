using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        string email = txtEmail.Text.Trim();
        string pass = txtPassword.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
        {
            lblError.Text = "Please enter email and password.";
            return;
        }

        btnLogin.Enabled = false;
        btnLogin.Text = "Signing in...";

        var user = UserService.Login(email, pass);

        btnLogin.Enabled = true;
        btnLogin.Text = "SIGN IN";

        if (user == null)
        {
            lblError.Text = "Invalid email or password.";
            return;
        }

        Session.CurrentUser = user;
        LogService.Log(user.UserID, "Login", $"Logged in as {user.RoleName}");

        Form dashboard = user.RoleID switch
        {
            1 => new SuperAdminDashboard(),
            2 => new AdminDashboard(),
            _ => new CustomerDashboard()
        };

        Hide();
        dashboard.ShowDialog();
        Show();
        Session.Logout();
        txtPassword.Text = "";
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        new RegisterForm().ShowDialog();
    }

    private void btnForgot_Click(object sender, EventArgs e)
    {
        new ChangePasswordForm().ShowDialog();
    }

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            btnLogin_Click(sender, e);
    }
}
