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
            UpdateSeatText();
        }

        private void UpdateSeatText()
        {
            if(zone != "" && seat_number != "")
            {
                this.SeatText.Text = zone + " - " + seat_number;
            }
        }
    }
}
