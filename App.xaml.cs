using PayrollManager.Data;

namespace PayrollManager;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Force Light Mode execution immediately on startup
        Application.Current.UserAppTheme = AppTheme.Light;

        // Automatically create the database and tables on mobile storage if they don't exist
        using (var context = new PayrollManager.Data.PayrollDbContext())
        {
            context.Database.EnsureCreated();
        }

        MainPage = new AppShell();
    }
}