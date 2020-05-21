using System;
using System.Collections.Generic;
using System.Text;

namespace ClubMember
{  
    class PageManager
    {
        public static PageManager pagemanager;
        private MembershipPage membershipPage;
        private Login login;
        private PaymentCCPage paymentccpage;
        public PageManager()
        {
            pagemanager = this;
        }
        public void setMembership(String id, int days, String memberPlan)
        {
            membershipPage = new MembershipPage();
            membershipPage.setMemberID(id);
            membershipPage.setDays(days);
            membershipPage.setMemberPlan(memberPlan);
        }
        public MembershipPage getMembershipPage()
        {
            return membershipPage;
        }
            
        public void setpaymentCCPage()
        {
            paymentccpage = new PaymentCCPage();
        }
        public PaymentCCPage getPaymentCCPage()
        {
            return paymentccpage;
        }
    }
}
