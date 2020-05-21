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
    /// Interaction logic for PaymentCCPage.xaml
    /// </summary>
    public partial class PaymentCCPage : Page
    {
        private int months;
        private int price;
        public PaymentCCPage()
        {
            InitializeComponent();
            months = 1;
            UpdateMonthsText();
            UpdatePriceText();
        }

        private void Increase_Months(object sender, RoutedEventArgs e)
        {
            months += 1;
            if(months >= 12)
            {
                months = 12;
            }
            UpdateMonthsText();
            UpdatePriceText();
        }

        private void Decrease_Months(object sender, RoutedEventArgs e)
        {
            months -= 1;
            if(months <= 1)
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
            price = 6 * months;
            this.QuantityMonths.Content = months;
            this.PricePerMonth.Content = price + "€ per month";
        }
    }
}
