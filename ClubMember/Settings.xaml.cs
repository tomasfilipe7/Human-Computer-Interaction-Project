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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
        }

        // button to Profile
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getProfile());
        }

        // button to Log Out
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getLogin());
        }

        // button to Settings

    }
}
