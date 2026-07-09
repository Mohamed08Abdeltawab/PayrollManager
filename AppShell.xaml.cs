namespace PayrollManager
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // Force the app to always run in Light Mode, regardless of system settings
            Application.Current.UserAppTheme = AppTheme.Light;
            Routing.RegisterRoute(nameof(Views.SettingsPage), typeof(Views.SettingsPage));
            Routing.RegisterRoute(nameof(Views.DepartmentsPage), typeof(Views.DepartmentsPage));
        }
        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            // Close the flyout drawer first
            Shell.Current.FlyoutIsPresented = false;

            // Navigate to SettingsPage on top of the current main tabs
            await Shell.Current.GoToAsync(nameof(Views.SettingsPage));
        }
    }
}
