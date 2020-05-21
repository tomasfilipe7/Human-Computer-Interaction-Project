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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager = new PageManager();
            PageManager.pagemanager.setMembership("3332243525", 32, "VIP");
            PageManager.pagemanager.setpaymentCCPage();
            this.NavigationService.Navigate(PageManager.pagemanager.getMembershipPage());
        }
    }
}
