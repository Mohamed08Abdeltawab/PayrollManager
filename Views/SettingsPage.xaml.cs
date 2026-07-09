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
}