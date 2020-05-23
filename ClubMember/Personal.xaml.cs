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
    /// Interaction logic for Personal.xaml
    /// </summary>
    public partial class Personal : Page
    {
        public Personal()
        {
            InitializeComponent();
        }

        // button to Settings
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.setSettings();
            this.NavigationService.Navigate(PageManager.pagemanager.getSettings());
        }

        // button to Profile
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.setProfile();
            this.NavigationService.Navigate(PageManager.pagemanager.getProfile());
        }
    }
}
