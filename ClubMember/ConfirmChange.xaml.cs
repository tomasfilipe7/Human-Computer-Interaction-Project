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
using System.Windows.Shapes;

namespace ClubMember
{
    /// <summary>
    /// Interaction logic for ConfirmChange.xaml
    /// </summary>
    public partial class ConfirmChange : Window
    {
        private Page page;
        public ConfirmChange(Page _page)
        {
            InitializeComponent();
            page = _page;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            page.NavigationService.Navigate(PageManager.pagemanager.getMembershipPage());
            this.Close();
        }
    }
}
