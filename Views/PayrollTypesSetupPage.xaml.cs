using System;
using Microsoft.Maui.Controls;

namespace PayrollManager.Views
{
    public partial class PayrollTypesSetupPage : ContentPage
    {
        public PayrollTypesSetupPage()
        {
            InitializeComponent();
        }

        private async void OnAddPayrollTypeTapped(object sender, EventArgs e)
        {
            // Navigate to the editor in insert mode (id = 0)
            await Shell.Current.GoToAsync($"{nameof(PayrollTypeEditorPage)}?id=0");
        }

        private async void OnEditTapped(object sender, EventArgs e)
        {
            // Navigate to the editor in update mode (statically passing id = 1 for now)
            await Shell.Current.GoToAsync($"{nameof(PayrollTypeEditorPage)}?id=1");
        }
    }
}