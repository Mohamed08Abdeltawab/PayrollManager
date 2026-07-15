using Microsoft.Maui.Controls;
using PayrollManager.Views;
using System;

namespace PayrollManager.Views
{
    public partial class RevenuesPage : ContentPage
    {
        public RevenuesPage()
        {
            InitializeComponent();
        }

        private async void OnAddRevenueTapped(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new RevenueEditorPage("إضافة إيراد"));
        }

        private async void OnEditRevenueTapped(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new RevenueEditorPage("تعديل الإيراد"));
        }

        private async void OnSearchClicked(object sender, EventArgs e)
        {
            await DisplayAlert("بحث", "تم الضغط على زر البحث", "موافق");
        }
    }
}