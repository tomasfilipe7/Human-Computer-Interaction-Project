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
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

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
            PageManager.pagemanager.setSettings();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] line = System.IO.File.ReadAllLines("users.txt") ;

            string[] content;
            Boolean found = false;

            string ID = textBox1.Text;
            string password = textBox2.Password;

            if(ID == "" && password == "")
            {
                MessageBox.Show("Inputs cannot be left in blank", "Login", MessageBoxButton.OK);
            }

            else if (ID == "")
            {
                MessageBox.Show("Please, insert MemberID", "Login", MessageBoxButton.OK);
            }

            else if (password == "")
            {
                MessageBox.Show("Please, insert password", "Login", MessageBoxButton.OK);
            }

            else
            {
                foreach (string l in line)
                {

                    content = l.Split(',');


                    if (ID == content[0] && password == content[1])
                    {
                        MessageBox.Show("Login successfully!", "Login", MessageBoxButton.OK);
                        found = true;
                        string timeLeft = content[2];
                        string memberType = content[3];
                        string fName = content[4];
                        string lName = content[5];
                        string email = content[6];
                        string movie = content[7];
                        PageManager.pagemanager.setPerson(ID, password, Int32.Parse(timeLeft), memberType, fName, lName, email, movie);
                        PageManager.pagemanager.setMembership(
                            PageManager.pagemanager.getPerson().getID(), 
                            PageManager.pagemanager.getPerson().getDaysLeft(), 
                            PageManager.pagemanager.getPerson().getMemberType()
                        );

                        PageManager.pagemanager.setProfile(
                            PageManager.pagemanager.getPerson().getFname(),
                            PageManager.pagemanager.getPerson().getLname(),
                            PageManager.pagemanager.getPerson().getDaysLeft()
                        );

                        this.NavigationService.Navigate(PageManager.pagemanager.getProfile());

                        PageManager.pagemanager.setItemsBought(
                            PageManager.pagemanager.getPerson().getID()
                        ); ;

                        PageManager.pagemanager.setProfileSettings(
                            PageManager.pagemanager.getPerson().getID(),
                            PageManager.pagemanager.getPerson().getPassword(),
                            PageManager.pagemanager.getPerson().getEmail(),
                            PageManager.pagemanager.getPerson().getMovie()
                        );

                        PageManager.pagemanager.setSendFeedback();
                        PageManager.pagemanager.setAboutApp();
                        PageManager.pagemanager.setHelp();
                        PageManager.pagemanager.setShopOptions();
                        PageManager.pagemanager.setBuyTickets();
                        PageManager.pagemanager.setNewsFeed();
                        PageManager.pagemanager.setShop();
                        PageManager.pagemanager.setResults();
                        PageManager.pagemanager.setOwnedTickets(ID);
                    }
                }

                if (found == false)
                {
                    MessageBox.Show("Login invalid!", "Login", MessageBoxButton.OK);
                }
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.setcreateAccount();
            this.NavigationService.Navigate(PageManager.pagemanager.getCreateAccount());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.setForgotPassword();
            this.NavigationService.Navigate(PageManager.pagemanager.getForgotPassword());
        }
    }
}
