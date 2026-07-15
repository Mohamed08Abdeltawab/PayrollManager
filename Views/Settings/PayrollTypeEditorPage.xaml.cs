using System;
using Microsoft.Maui.Controls;

namespace PayrollManager.Views
{
    public partial class PayrollTypeEditorPage : ContentPage
    {
        public PayrollTypeEditorPage()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            // Pop the current page off the navigation stack to go back safely
            await Shell.Current.Navigation.PopAsync();
        }
    }
}