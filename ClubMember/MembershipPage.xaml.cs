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
        public MembershipPage()
        {
            InitializeComponent();
        }

        public void setMemberID(String _MemberID)
        {
            MemberID = _MemberID;
            this.Membership.Content = MemberID;
        }
    }

}
