using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClubMember
{
    /// <summary>
    /// Interaction logic for PaymentPaypalPage.xaml
    /// </summary>
    public partial class PaymentPaypalPage : Page
    {
        private int months;
        private int price;
        private double total_price;
        private String plan;
        private int price_per_month;
        public PaymentPaypalPage()
        {
            InitializeComponent();
            months = 1;
            UpdateMonthsText();
            UpdatePriceText();
        }

        public void setPlan(String _plan)
        {
            plan = _plan;
            UpdatePricePerMonth();
        }
        public String getPlan()
        {
            return plan;
        }
        private void UpdatePricePerMonth()
        {
            price_per_month = 6;
            if (plan == "VIP")
            {
                price_per_month = 9;
            }
            this.PricePerMonth.Content = price_per_month + "€ per month";
        }
        private void Increase_Months(object sender, RoutedEventArgs e)
        {
            months += 1;
            if (months >= 12)
            {
                months = 12;
            }
            UpdateMonthsText();
            UpdatePriceText();
        }

        private void Decrease_Months(object sender, RoutedEventArgs e)
        {
            months -= 1;
            if (months <= 1)
            {
                months = 1;
            }
            UpdateMonthsText();
            UpdatePriceText();
        }

        private void UpdateMonthsText()
        {
            this.QuantityMonths.Content = months;
        }
        private void UpdatePriceText()
        {
            price = price_per_month * months;
            this.QuantityMonths.Content = months;
            this.SubTotalPrice.Content = price + "€";
            total_price = (double)price * 0.23 + price;
            this.TotalPrice.Content = total_price;
        }

        private void Pay_check(object sender, RoutedEventArgs e)
        {
            ConfirmPayment window = new ConfirmPayment(this);
            window.HorizontalAlignment = HorizontalAlignment.Center;
            window.VerticalAlignment = VerticalAlignment.Center;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.ShowDialog();
        }

        private void CreditCard_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getPaymentCCPage());
        }
    }
}
