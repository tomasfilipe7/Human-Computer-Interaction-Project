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
    /// Interaction logic for OwnedTickets.xaml
    /// </summary>
    public partial class OwnedTickets : Page
    {
        private String game;
        private String date;
        private String price;
        private String seat;
        private String memberID;


        public OwnedTickets()
        {
            InitializeComponent();
            lblPop.Visibility = Visibility.Visible;
            btn_OK.Visibility = Visibility.Visible;
        }

        public void setMemberID(String _memberID)
        {
            memberID = _memberID;

            string[] line = System.IO.File.ReadAllLines("tickets.txt");

            string[] content;

            RowDefinition row;
            int count = 0;

            foreach (string l in line)
            {
                content = l.Split(',');

                if (memberID == content[0])
                {
                    row = new RowDefinition();
                    myGrid.RowDefinitions.Add(row);

                    TextBlock newT1 = new TextBlock();
                    game = content[1];
                    date = content[2];
                    price = content[3];
                    seat = content[4];
                    newT1.Text =game + " | "+ date + " | " + price + " | " + seat + "\n";
                    newT1.FontSize = 15;
                    newT1.MouseDown += getTicket;
                    Grid.SetRow(newT1, count);
                    myGrid.Children.Add(newT1);

                    count++;
                }




            }
        }

        // button to go back
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getProfile());
        }
        private void getTicket(object sender, RoutedEventArgs e)
        {
            TextBlock ticket_temp = (TextBlock)sender;
            String[] ticket_split = ticket_temp.Text.Split("|");
            PageManager.pagemanager.setTicket(ticket_split[0], ticket_split[1], ticket_split[2], ticket_split[3]);
            this.NavigationService.Navigate(PageManager.pagemanager.getTicket());
        }

        private void btn_OK_Click(object sender, RoutedEventArgs e)
        {
            lblPop.Visibility = Visibility.Hidden;
            btn_OK.Visibility = Visibility.Hidden;
        }
    }
}
