﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Navigation;

namespace ClubMember
{  
    class PageManager
    {
        public static PageManager pagemanager;
        private MembershipPage membershipPage;
        private Login login;
        private PaymentCCPage paymentccpage;
        private PaymentPaypalPage paypalpayment;
        private CreateAccount createAccount;
        private ForgotPassword forgotpass;
        private NavigationWindow mainWindow;

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
        public void setMainWindow(NavigationWindow window)
        {
            mainWindow = window;
        }
        public NavigationWindow getMainWindow()
        {
            return mainWindow;
        }
        public MembershipPage getMembershipPage()
        {
            return membershipPage;
        }
            
        public void setpaymentCCPage(String _plan)
        {
            paymentccpage = new PaymentCCPage();
            paymentccpage.setPlan(_plan);
        }
        public PaymentCCPage getPaymentCCPage()
        {
            return paymentccpage;
        }
        public void setpaymentPayPalPage(String _plan)
        {
            paypalpayment = new PaymentPaypalPage();
            paypalpayment.setPlan(_plan);
        }
        public PaymentPaypalPage getPaymentPaypalPage()
        {
            return paypalpayment;
        }
        public void setcreateAccount()
        {
            createAccount = new CreateAccount();
        }

        public CreateAccount getCreateAccount()
        {
            return createAccount;
        }

        public void setForgotPassword()
        {
            forgotpass = new ForgotPassword();
        }

        public ForgotPassword getForgotPassword()
        {
            return forgotpass;
        }
    }
}
