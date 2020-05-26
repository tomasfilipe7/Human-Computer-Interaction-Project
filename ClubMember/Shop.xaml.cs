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
    /// Interaction logic for Shop.xaml
    /// </summary>
    public partial class Shop : Page
    {
        int count = 0;
        public Shop()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.GetShopOptions());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            count++;
            txtBlk.Text = count.ToString();
        }
    }
}
