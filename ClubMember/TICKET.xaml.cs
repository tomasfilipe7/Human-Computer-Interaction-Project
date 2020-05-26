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
    /// Interaction logic for TICKET.xaml
    /// </summary>
    public partial class TICKET : Page
    {
        public TICKET(String game, String date, String price, String seat)
        {
            InitializeComponent();
            this.Match.Text = game;
            this.Date.Text = date;
            this.Price.Text = price;
            this.Seat.Text = seat;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getOwnedTickets());
        }
    }
}
