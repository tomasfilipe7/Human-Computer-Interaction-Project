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
    /// Interaction logic for MembershipPage.xaml
    /// </summary>
    public partial class MembershipPage : Page
    {
        private String MemberID;
        private int days_left;
        private String memberplan;
        public MembershipPage()
        {
            InitializeComponent();
        }

        public void setMemberID(String _MemberID)
        {
            MemberID = _MemberID;
            this.Membership.Content = "Membership ID: " + MemberID;
        }

        public void setDays(int _daysleft)
        {
            days_left = _daysleft;
            this.DaysLeft.Content = "Days left: " + days_left;
        }
        public void setMemberPlan(String _memberplan)
        {
            memberplan = _memberplan;
            this.MembershipPlan.Content = "Membership plan: " + memberplan;
        }

        private void Renew_Click(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.setpaymentCCPage();
            PageManager.pagemanager.setpaymentPayPalPage();
            this.NavigationService.Navigate(PageManager.pagemanager.getPaymentCCPage());
        }

        private void Upgrade_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
