using System;
using Microsoft.Maui.Controls;

namespace PayrollManager.Views
{
    public partial class TransactionsPage : ContentPage
    {
        public TransactionsPage()
        {
            InitializeComponent();
        }

        private async void OnRevenuesTapped(object sender, EventArgs e)
        {
            // Navigate to the newly created Revenues List Page
            await Shell.Current.Navigation.PushAsync(new RevenuesPage());
        }

        private async void OnDeductionsTapped(object sender, EventArgs e)
        {
            //await Shell.Current.Navigation.PushAsync(new TransactionEditorPage("تعديل الخصم"));
        }

        private async void OnTaxesTapped(object sender, EventArgs e)
        {
            //await Shell.Current.Navigation.PushAsync(new TransactionEditorPage("تعديل الضريبة"));
        }
    }
}