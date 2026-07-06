using PayrollManager.Data;

namespace PayrollManager;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Automatically create the database and tables on mobile storage if they don't exist
        using (var context = new PayrollDbContext())
        {
            context.Database.EnsureCreated();
        }

        MainPage = new AppShell();
    }
}