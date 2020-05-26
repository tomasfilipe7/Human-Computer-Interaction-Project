using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for BuyTickets.xaml
    /// </summary>
    public partial class BuyTickets : Page
    {
        private int num_tickets;
        private String date;
        private String game;
        public BuyTickets()
        {
            InitializeComponent();
            num_tickets = 1;
        }

        public String getDate()
        {
            return date;
        }

        public String getGame()
        {
            return game;
        }
        private void Increase_Tickets(object sender, RoutedEventArgs e)
        {
            num_tickets += 1;
            if (num_tickets >= 10)
            {
                num_tickets = 10;
            }
            UpdateTicketsText();
        }

        private void Decrease_Tickets(object sender, RoutedEventArgs e)
        {
            num_tickets -= 1;
            if (num_tickets <= 1)
            {
                num_tickets = 1;
            }
            UpdateTicketsText();
        }

        private void UpdateTicketsText()
        {
            this.QuantityTickets.Content = num_tickets;
        }
        public int getNumTickets()
        {
            return num_tickets;
        }
        private void Choose_Tickets(object sender, RoutedEventArgs e)
        {
            date = this.GameCalendar.SelectedDate.ToString().Split(" ")[0];
            if(date.Equals("27/05/2020"))
            {
                game = "MyClub_x_RivalsFC";
            }
            else
            {
                game = "MyClub_x_RivalsFC";
            }
            PageManager.pagemanager.setChooseTickets();
            this.NavigationService.Navigate(PageManager.pagemanager.getChooseTickets());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getProfile());
        }
    }
}
