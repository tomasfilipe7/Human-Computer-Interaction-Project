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
    /// Interaction logic for ShopPayment.xaml
    /// </summary>
    public partial class ShopPayment : Page
    {
        public ShopPayment()
        {
            InitializeComponent();
            this.SubTotalPrice.Content = PageManager.pagemanager.GetShoppingCart().totalPrice().ToString() + "€";
            double total = PageManager.pagemanager.GetShoppingCart().totalPrice() * 0.23 + PageManager.pagemanager.GetShoppingCart().totalPrice();
            this.TotalPrice.Content = total.ToString() + "€";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.GetShoppingCart());

        }

        private void Pay_done(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.getItemsBought().setMemberID(PageManager.pagemanager.getPerson().getID());
            ConfirmPayment confirm = new ConfirmPayment(this, PageManager.pagemanager.getShop(),"The payment was accepted successfully!");
            confirm.ShowDialog();
        }
    }
}
