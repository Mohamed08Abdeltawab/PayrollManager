using System;
using Microsoft.Maui.Controls;

namespace PayrollManager.Views
{
    public partial class RevenueEditorPage : ContentPage
    {
        public RevenueEditorPage(string pageTitle)
        {
            InitializeComponent();
            this.Title = pageTitle;
            CalculationTypePicker.SelectedIndex = 0;
        }

        private void OnCalculationTypeChanged(object sender, EventArgs e)
        {
            if (CalculationTypePicker.SelectedIndex == -1) return;

            FixedAmountContainer.IsVisible = false;
            QuantityPriceContainer.IsVisible = false;
            PercentageContainer.IsVisible = false;

            switch (CalculationTypePicker.SelectedIndex)
            {
                case 0:
                    FixedAmountContainer.IsVisible = true;
                    break;
                case 1:
                    QuantityPriceContainer.IsVisible = true;
                    break;
                case 2:
                    PercentageContainer.IsVisible = true;
                    break;
            }
        }

        private void OnPriceOrQuantityChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(PriceEntry.Text, out double price) &&
                double.TryParse(QuantityEntry.Text, out double quantity))
            {
                TotalAmountEntry.Text = (price * quantity).ToString("F1");
            }
            else
            {
                TotalAmountEntry.Text = "0.0";
            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PopAsync();
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("تأكيد الحذف", "هل أنت متأكد من رغبتك في حذف هذا الإيراد؟", "نعم", "لا");
            if (answer)
            {
                await Shell.Current.Navigation.PopAsync();
            }
        }
    }
}