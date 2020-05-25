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
    /// Interaction logic for ShopOptions.xaml
    /// </summary>
    public partial class ShopOptions : Page
    {
        public ShopOptions()
        {
            InitializeComponent();
            this.LabelText1.Content = "All of MyClub products available through \n one tap.";
            this.LabelText2.Content = "Buy your ticket here in digital format \n No queues, no complications.";
            this.LabelText3.Content = "Check your membership fees here and enjoy\n all the advantages of being a member.";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getProfile());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getSettings());
        }

        private void OnlineStore(object sender, RoutedEventArgs e)
        {
           
        }

        private void Tickets(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getBuyTickets());
        }

        private void Membership(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getMembershipPage());
        }
    }
}
