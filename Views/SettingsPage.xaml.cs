namespace PayrollManager.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}
    private async void OnDepartmentsTapped(object sender, EventArgs e)
    {
        // Navigate to DepartmentsPage sequentially
        await Shell.Current.GoToAsync(nameof(DepartmentsPage));
    }
    private async void OnPositionsTapped(object sender, EventArgs e) =>
    await Shell.Current.GoToAsync(nameof(PositionsPage));

    private async void OnPayrollTypesTapped(object sender, EventArgs e) =>
        await Shell.Current.GoToAsync(nameof(PayrollTypesSetupPage));
}