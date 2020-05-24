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

      
        public ItemsBought()
        {
            InitializeComponent();

            
            string[] line = System.IO.File.ReadAllLines("C:/Users/marci/Desktop/IHC_Projeto/ClubMember/ClubMember/itemsBought.txt");

            string[] content;

            foreach (string l in line)
            {
                content = l.Split(',');

                TextBlock newT1 = new TextBlock();
                TextBlock newT2 = new TextBlock();
                TextBlock newT3 = new TextBlock();
                TextBlock newT4 = new TextBlock();
                newT1.Text = content[0];
                newT1.HorizontalAlignment = HorizontalAlignment.Center;
                newT1.FontSize = 14;
                newT2.Text = content[1];
                newT2.HorizontalAlignment = HorizontalAlignment.Center;
                newT2.FontSize = 14;
                newT3.Text = content[2];
                newT3.HorizontalAlignment = HorizontalAlignment.Center;
                newT3.FontSize = 14;
                newT4.Text = content[3];
                newT4.HorizontalAlignment = HorizontalAlignment.Center;
                newT4.FontSize = 14;

                Grid.SetColumn(newT1, 0);
                myGrid.Children.Add(newT1);

                Grid.SetColumn(newT2, 1);
                myGrid.Children.Add(newT2);

                Grid.SetColumn(newT3, 2);
                myGrid.Children.Add(newT3);

                Grid.SetColumn(newT4, 3);
                myGrid.Children.Add(newT4);
            }
        }



    }
}
