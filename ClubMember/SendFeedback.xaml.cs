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
    /// Interaction logic for SendFeedback.xaml
    /// </summary>
    public partial class SendFeedback : Page
    {
        public SendFeedback()
        {
            InitializeComponent();
        }

        // button to Send Feedback
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getSendFeedback(), "Thanks for your feedback!");
            window.HorizontalAlignment = HorizontalAlignment.Center;
            window.VerticalAlignment = VerticalAlignment.Center;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.ShowDialog();
            this.NavigationService.Navigate(PageManager.pagemanager.getSettings());
        }

        // button to go back
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getSettings());
        }
    }
}
