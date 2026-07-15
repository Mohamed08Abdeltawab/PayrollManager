using Microsoft.EntityFrameworkCore;
using PayrollManager.Data;
using PayrollManager.Models;

namespace PayrollManager.Views;

[QueryProperty(nameof(DepartmentId), "id")]
public partial class DepartmentEditorPage : ContentPage
{
    private int _departmentId;
    private Department _currentDepartment;

    public int DepartmentId
    {
        get => _departmentId;
        set
        {
            _departmentId = value;
            LoadPageMode();
        }
    }

    public DepartmentEditorPage()
    {
        InitializeComponent();
    }

    private void LoadPageMode()
    {
        if (DepartmentId == 0)
        {
            // Add New Mode configuration
            Title = "إضافة قسم";
            _currentDepartment = new Department();
            DeleteButton.IsVisible = false;
        }
        else
        {
            // Update Mode configuration
            Title = "تعديل القسم";
            using (var context = new PayrollDbContext())
            {
                _currentDepartment = context.Departments.FirstOrDefault(d => d.Id == DepartmentId);
            }

            if (_currentDepartment != null)
            {
                NameEntry.Text = _currentDepartment.Name;
                DescriptionEntry.Text = _currentDepartment.Description;

                // Show delete button only if it is NOT the default main department (Id != 1)
                DeleteButton.IsVisible = (DepartmentId != 1);
            }
        }
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameEntry.Text))
        {
            await DisplayAlert("تنبيه", "برجاء إدخال اسم القسم الأساسي", "حسنًا");
            return;
        }

        _currentDepartment.Name = NameEntry.Text.Trim();
        _currentDepartment.Description = DescriptionEntry.Text?.Trim();

        using (var context = new PayrollDbContext())
        {
            if (DepartmentId == 0)
            {
                context.Departments.Add(_currentDepartment);
            }
            else
            {
                context.Entry(_currentDepartment).State = EntityState.Modified;
            }

            await context.SaveChangesAsync();
        }

        await Shell.Current.Navigation.PopAsync();
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert("تأكيد الحذف", "هل أنت متأكد من حذف هذا القسم نهائيًا؟", "نعم", "إلغاء");
        if (!confirm) return;

        using (var context = new PayrollDbContext())
        {
            var deptToDelete = context.Departments.FirstOrDefault(d => d.Id == DepartmentId);
            if (deptToDelete != null)
            {
                context.Departments.Remove(deptToDelete);
                await context.SaveChangesAsync();
            }
        }

        await Shell.Current.Navigation.PopAsync();
    }
}