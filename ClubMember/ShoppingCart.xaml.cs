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
using System.Diagnostics;

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
                Image bt = new Image();
                bt.Source = new BitmapImage(new Uri("/ClubMember;component/Images/TrashCan.png", UriKind.Relative));
                bt.Width = 20;
                bt.Height = 20;
                bt.VerticalAlignment = VerticalAlignment.Top;
                bt.Name = "Image_" + count;
                bt.MouseDown += DeleteItem;
                TextBlock newT1 = new TextBlock();
                newT1.Text = l + " | " + prices[count].ToString() + "€" + "\n";
                newT1.FontSize = 15;
                newT1.Name = "T_" + count;
                newT1.MouseDown += CheckName;
                this.RegisterName(newT1.Name, newT1);
                Debug.WriteLine(newT1.Name);
                Grid.SetRow(newT1, count);
                Grid.SetRow(bt, count);
                Grid.SetColumn(newT1, 0);
                Grid.SetColumn(bt, 3);
                myGrid.Children.Add(newT1);
                myGrid.Children.Add(bt);

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

        private void CheckName(object sender, RoutedEventArgs e)
        {
            TextBlock tx = (TextBlock)sender;
            Debug.WriteLine("HELLOOOOOO");
            Debug.WriteLine(tx.Name);
        }
        private void DeleteItem(object sender, RoutedEventArgs e)
        {
            Image img = (Image)sender;
            String num = img.Name.Split("_")[1];
            int index = Int32.Parse(num);
            TextBlock txt = (TextBlock)(this.FindName("T_"+num));
            shoppingCart.Remove(txt.Text.Split(" | ")[0]);
            prices.Remove(Int32.Parse(txt.Text.Split(" | ")[1].Replace("€","")));
            PageManager.pagemanager.getShop().delete_shoppingCart(txt.Text.Split(" | ")[0], Int32.Parse(txt.Text.Split(" | ")[1].Replace("€", "")));
            txt.Text = "";
            img.Opacity = 0;

        }
        private void goToPayment(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.setShopPayment();
            this.NavigationService.Navigate(PageManager.pagemanager.GetShopPayment());
        }
        public void PaidSuccess()
        {
            int count = 0;
            foreach (string l in shoppingCart)
            {
                using (StreamWriter writer = new StreamWriter("itemsBought.txt", true))
                {
                    String tmp = memberID + ", " + l + ", 1, " + prices[count].ToString() + "€" + ", " + DateTime.Today;
                    writer.WriteLine(tmp);
                }
                count++;
            }
        }
    }
}
