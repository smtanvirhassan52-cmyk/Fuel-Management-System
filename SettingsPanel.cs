using FuelMS.Helpers;
using FuelMS.Services;

namespace FuelMS.Forms;

public partial class SettingsPanel : UserControl
{
    public SettingsPanel()
    {
        InitializeComponent();
        LoadSettings();
    }

    private void LoadSettings()
    {
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FuelMS", "fuelms.db");
        lblDbPath.Text = $"Database: {dbPath}";
    }

    private void btnUpdatePassword_Click(object sender, EventArgs e)
    {
        lblErr.Text = "";
        if (string.IsNullOrEmpty(txtOld.Text) || string.IsNullOrEmpty(txtNew.Text))
        { lblErr.Text = "All fields required."; return; }
        if (txtNew.Text != txtConf.Text) { lblErr.Text = "Passwords do not match."; return; }
        if (txtNew.Text.Length < 6) { lblErr.Text = "Min 6 characters."; return; }

        var user = UserService.Login(Session.CurrentUser!.Email, txtOld.Text);
        if (user == null) { lblErr.Text = "Current password is incorrect."; return; }

        UserService.ChangePassword(Session.CurrentUser.UserID, txtNew.Text);
        MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtOld.Text = txtNew.Text = txtConf.Text = "";
    }
}
