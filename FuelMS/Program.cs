using FuelMS.Data;
using FuelMS.Forms;

namespace FuelMS;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.SetHighDpiMode(HighDpiMode.SystemAware);

        try
        {
            Database.Initialize();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Database initialization failed:\n{ex.Message}", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Application.Run(new LoginForm());
    }
}
