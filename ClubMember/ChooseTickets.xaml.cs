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
    /// Interaction logic for ChooseTickets.xaml
    /// </summary>
    public partial class ChooseTickets : Page
    {
        private String zone;
        private String seat_number;
        private Button seat_selected;
        private List<String> tickets = new List<String>();
        public ChooseTickets()
        {
            InitializeComponent();
            zone = "";
            seat_number = "";
            this.SeatText.Text = "Choose a seat";
        }

        private void Choose_Seat(object sender, RoutedEventArgs e)
        {
            seat_selected = (Button)sender;
            seat_number = seat_selected.Name.ToString();
            zone = this.ZoneSelect.Text;

            if (zone != "" && seat_number != "")
            {
                String ticket_un = zone + "-" + seat_number;
                if (tickets.Contains(ticket_un))
                {
                    tickets.Remove(ticket_un);
                }
                else if (tickets.Count < PageManager.pagemanager.getBuyTickets().getNumTickets())
                {
                    tickets.Add(ticket_un);
                }
            }
            UpdateSeatText(seat_selected);
        }

        private void UpdateSeatText(Button bt)
        {
            if(tickets.Count > 0)
            {
                String tickets_str = "";
                foreach (String ticket in tickets)
                {
                    tickets_str += ticket + ";";
                }
                this.SeatText.Text = tickets_str;
            }
            else
            {
                this.SeatText.Text = "Choose a seat";
            }       
        }

        private void ProceedToPayment(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.setTicketPayment();
            this.NavigationService.Navigate(PageManager.pagemanager.GetTicketPayment());
        }
    }
}
