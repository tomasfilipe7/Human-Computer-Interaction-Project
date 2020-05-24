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
    /// Interaction logic for ConfirmPayment.xaml
    /// </summary>
    public partial class ConfirmPayment : Window
    {
        private Page page;
        private Page target_page;
        public ConfirmPayment(Page _page,Page _target_page)
        {
            InitializeComponent();
            page = _page;
            target_page = _target_page;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            page.NavigationService.Navigate(target_page);
            this.Close();
        }
    }
}
