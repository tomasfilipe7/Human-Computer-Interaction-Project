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
    /// Interaction logic for BuyTickets.xaml
    /// </summary>
    public partial class BuyTickets : Page
    {
        private int num_tickets;
        public BuyTickets()
        {
            InitializeComponent();
            num_tickets = 1;
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
            PageManager.pagemanager.setChooseTickets();
            this.NavigationService.Navigate(PageManager.pagemanager.getChooseTickets());
        }
    }
}
