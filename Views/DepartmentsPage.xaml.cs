namespace PayrollManager.Views;

public partial class DepartmentsPage : ContentPage
{
    public DepartmentsPage()
    {
        InitializeComponent();
    }

    private async void OnAddDepartmentTapped(object sender, EventArgs e)
    {
        // Passing id = 0 to denote insert mode
        await Shell.Current.GoToAsync($"{nameof(DepartmentEditorPage)}?id=0");
    }

    private async void OnEditTapped(object sender, EventArgs e)
    {
        // For now passing a static id or bound entity item id
        // In production we will bind it to the clicked list item id dynamically
        int selectedId = 1; // Change based on dynamic clicked row context later
        await Shell.Current.GoToAsync($"{nameof(DepartmentEditorPage)}?id={selectedId}");
    }
}