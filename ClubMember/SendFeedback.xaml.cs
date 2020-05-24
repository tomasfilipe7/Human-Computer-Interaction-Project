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
            MessageBox.Show("Thanks for your feedback!", "Send Feedback", MessageBoxButton.OK);
            this.NavigationService.Navigate(PageManager.pagemanager.getSettings());
        }
    }
}
