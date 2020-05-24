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
    /// Interaction logic for ItemsBought.xaml
    /// </summary>
    public partial class ItemsBought : Page
    {

        private string memberID;


        public ItemsBought()
        {
            InitializeComponent();

        }

        public void setMemberID(string _memberID)
        {
            memberID = _memberID;

            string[] line = System.IO.File.ReadAllLines("C:/Users/marci/Desktop/IHC_Projeto/ClubMember/ClubMember/itemsBought.txt");

            string[] content;

            RowDefinition row;
            int count = 0;

            foreach (string l in line)
            {
                content = l.Split(',');

                if(memberID == content[0])
                {
                    row = new RowDefinition();
                    myGrid.RowDefinitions.Add(row);

                    TextBlock newT1 = new TextBlock();
                    TextBlock newT2 = new TextBlock();
                    TextBlock newT3 = new TextBlock();
                    TextBlock newT4 = new TextBlock();
                    newT1.Text = content[1];
                    newT1.HorizontalAlignment = HorizontalAlignment.Center;
                    newT1.FontSize = 14;
                    newT2.Text = content[2];
                    newT2.HorizontalAlignment = HorizontalAlignment.Center;
                    newT2.FontSize = 14;
                    newT3.Text = content[3];
                    newT3.HorizontalAlignment = HorizontalAlignment.Center;
                    newT3.FontSize = 14;
                    newT4.Text = content[4];
                    newT4.HorizontalAlignment = HorizontalAlignment.Center;
                    newT4.FontSize = 14;

                    Grid.SetRow(newT1, count);
                    Grid.SetColumn(newT1, 0);
                    myGrid.Children.Add(newT1);

                    Grid.SetRow(newT2, count);
                    Grid.SetColumn(newT2, 1);
                    myGrid.Children.Add(newT2);

                    Grid.SetRow(newT3, count);
                    Grid.SetColumn(newT3, 2);
                    myGrid.Children.Add(newT3);

                    Grid.SetRow(newT4, count);
                    Grid.SetColumn(newT4, 3);
                    myGrid.Children.Add(newT4);

                    count++;
                }

  


            }
        }

        // button to go back
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getProfile());
        }
    }
}
