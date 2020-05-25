using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClubMember
{
    /// <summary>
    /// Interaction logic for Personal.xaml
    /// </summary>
    public partial class Personal : Page
    {

        private string fname;
        private string lname;
        private int daysLeft;

        public Personal()
        {
            InitializeComponent();
        }

        public void setFname(string _Fname)
        {
            fname = _Fname;
            this.textBlock1.Text = fname + " " + lname;
        }

        public void setLname(string _Lname)
        {
            lname = _Lname;
            this.textBlock1.Text = fname + " " + lname;
        }

        public void setDaysLeft(int _daysLeft)
        {
            daysLeft = _daysLeft;
            if(daysLeft <= 10)
            {
                this.button1.Background = Brushes.Red;
            }
            else
            {
                this.button1.Background = Brushes.Green;
            }

            this.button1.Content = "Membership status: " + daysLeft + " days left";
        }

        // button to Settings
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getSettings());
        }

        // button to Membership Page
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getMembershipPage());
        }

        // button to Items Bought
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getItemsBought());
        }

        // button to Profile Settings
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getProfileSettings());
        }

        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.setBuyTickets();
            this.NavigationService.Navigate(PageManager.pagemanager.getBuyTickets());
        }
    }
}
