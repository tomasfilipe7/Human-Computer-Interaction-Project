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
    /// Interaction logic for UpgradeMembershipPage.xaml
    /// </summary>
    public partial class UpgradeMembershipPage : Page
    {
        private String plan_chose;
        private String plan;
        private int price_per_month;
        public UpgradeMembershipPage()
        {
            InitializeComponent();
        }

        public void setPlan(String _plan)
        {
            plan = _plan;
            UpdatePlanText();
            UpdatePricePerMonth();
        }
        public String getPlan()
        {
            return plan;
        }
        private void UpdatePricePerMonth()
        {
            price_per_month = 6;
            if (plan == "VIP")
            {
                price_per_month = 9;
            }
            this.PricePerMonth.Content = price_per_month + "€ per month";
        }
        private void UpdatePlanText()
        {
            this.Plan.Content = plan;
        }

        private void ChangePlan_Click(object sender, RoutedEventArgs e)
        {
            if(this.StandardButton.IsChecked == true)
            {
                plan_chose = "Standard";
            }
            else if(this.VIPButton.IsChecked == true)
            {
                plan_chose = "VIP";
            }
            PageManager.pagemanager.getMembershipPage().setMemberPlan(plan_chose);
            ConfirmChange change = new ConfirmChange(this);
            change.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            change.ShowDialog();
        }
    }
}
