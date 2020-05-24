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
    /// Interaction logic for TicketPaymentCC.xaml
    /// </summary>
    public partial class TicketPaymentCC : Page
    {
        private int tickets;
        private double total_price;
        private String plan;
        private int price_per_ticket;
        private int price_per_memberticket;
        private int price;
        public TicketPaymentCC()
        {
            InitializeComponent();
            tickets = PageManager.pagemanager.getBuyTickets().getNumTickets();
            UpdatePrice();
        }
        
        private void UpdatePrice()
        {
            price_per_ticket = 24;
            price_per_memberticket = 18;
            if(tickets == 1)
            {
                this.PricePerTicket.Text = "\n 1x Member Ticket - " + price_per_memberticket + "€";
                price = price_per_memberticket;
                this.SubTotalPrice.Content = price;
            }
            else
            {
                this.PricePerTicket.Text = "1x MemberTicker - " + price_per_memberticket + "€" + "\n" + (tickets-1) + "x Normal Ticket - " + price_per_ticket + "€";
                price = price_per_memberticket + price_per_ticket * (tickets - 1);
                this.SubTotalPrice.Content = price + "€";
            }
            this.TotalPrice.Content = price*0.23 + price + "*";
        }

        private void Pay_check(object sender, RoutedEventArgs e)
        {
            ConfirmPayment window = new ConfirmPayment(this,PageManager.pagemanager.getBuyTickets());
            window.HorizontalAlignment = HorizontalAlignment.Center;
            window.VerticalAlignment = VerticalAlignment.Center;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.ShowDialog();
        }

        private void Paypal_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getPaymentPaypalPage());
        }
    }
}
