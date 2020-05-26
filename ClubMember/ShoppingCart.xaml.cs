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
using System.IO;

namespace ClubMember
{ 
    /// <summary>
    /// Interaction logic for ShoppingCart.xaml
    /// </summary>
    public partial class ShoppingCart : Page
    {
        private List<String> shoppingCart = new List<String>();
        private List<int> prices = new List<int>();
        private String memberID;
        public ShoppingCart()
        {
            InitializeComponent();
        }

        public void addToCart(String item, int price)
        {
            shoppingCart.Add(item);
            prices.Add(price);
        }

        private void goBackToShop(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getShop());
        }

        public void setMemberID(String _memberID)
        {
            memberID = _memberID;

            RowDefinition row;
            int count = 0;

            foreach (string l in shoppingCart)
            {
                row = new RowDefinition();
                myGrid.RowDefinitions.Add(row);

                TextBlock newT1 = new TextBlock();
                newT1.Text = l + " | " + prices[count].ToString() + "€" + "\n";
                newT1.FontSize = 15;
                Grid.SetRow(newT1, count);
                myGrid.Children.Add(newT1);

                using (StreamWriter writer = new StreamWriter("itemsBought.txt", true))
                {
                    String tmp = memberID + ", " + l + ", 1, " + prices[count].ToString() + ", " + DateTime.Today;
                    writer.WriteLine(tmp);
                }

                count++;
            }
        }

        public int totalPrice()
        {
            int count = 0;
            foreach(int i in prices)
            {
                count += i;
            }

            return count;
        }

        private void goToPayment(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.setShopPayment();
            this.NavigationService.Navigate(PageManager.pagemanager.GetShopPayment());
        }
    }
}
