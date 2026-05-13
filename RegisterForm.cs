using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class RegisterForm : Form
{
    public RegisterForm()
    {
        InitializeComponent();
    }

    private void btnCreateAccount_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        string name  = txtName.Text.Trim();
        string email = txtEmail.Text.Trim();
        string phone = txtPhone.Text.Trim();
        string pass  = txtPassword.Text;
        string conf  = txtConfirm.Text;

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
        { lblError.Text = "All fields are required."; return; }
        if (pass != conf) { lblError.Text = "Passwords do not match."; return; }
        if (pass.Length < 6) { lblError.Text = "Password must be at least 6 characters."; return; }

        bool ok = UserService.Register(name, email, pass, phone);
        if (ok)
        {
            MessageBox.Show("Account created! You can now login.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        else lblError.Text = "Email already exists.";
    }
}
