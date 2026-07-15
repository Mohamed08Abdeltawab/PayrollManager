using System;
using Microsoft.Maui.Controls;

namespace PayrollManager.Views
{
    public partial class PayrollTypePage : ContentPage
    {
        public PayrollTypePage()
        {
            InitializeComponent();
        }

        private async void OnAddPayrollTypeTapped(object sender, EventArgs e)
        {
            // Navigate to the payroll type editor in insert mode (id = 0)
            await Shell.Current.GoToAsync(nameof(PayrollTypeEditorPage));
        }

        private async void OnEditTapped(object sender, EventArgs e)
        {
            // Navigate to the payroll type editor in update mode
            await Shell.Current.GoToAsync(nameof(PayrollTypeEditorPage));
        }

        private async void OnExportTapped(object sender, EventArgs e)
        {
            // Statically handle Excel/CSV export click event for now
            await DisplayAlert("تصدير البيانات", "جاري تحضير ملف Excel/CSV...", "موافق");
        }
    }
}