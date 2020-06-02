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
using System.Net.Mime;

namespace ClubMember
{
    /// <summary>
    /// Interaction logic for ForgotPassword.xaml
    /// </summary>
    public partial class ForgotPassword : Page
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] allLines = System.IO.File.ReadAllLines("users.txt");

            string[] content;
            Boolean foundID = false;
            Boolean foundMovie = false;

            string memberID = textBox1.Text;
            string movie = textBox2.Text;

            if (movie == "" && memberID == "")
            {
                ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getForgotPassword(), "Inputs cannot be left in blank");
                window.HorizontalAlignment = HorizontalAlignment.Center;
                window.VerticalAlignment = VerticalAlignment.Center;
                window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                window.ShowDialog();
            }
            else if (movie == "")
            {
                ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getForgotPassword(), "Please, answer the question");
                window.HorizontalAlignment = HorizontalAlignment.Center;
                window.VerticalAlignment = VerticalAlignment.Center;
                window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                window.ShowDialog();

            }

            else if (memberID == "")
            {
                ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getForgotPassword(), "Please, insert member ID");
                window.HorizontalAlignment = HorizontalAlignment.Center;
                window.VerticalAlignment = VerticalAlignment.Center;
                window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                window.ShowDialog();

            }

            else
            {
                foreach (string l in allLines)
                {
                    content = l.Split(",");

                    if (memberID == content[0])
                    {
                        foundID = true;
                        if (movie == content[7])
                        {
                            ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getLogin(), "Your password is: " + content[1]);
                            window.HorizontalAlignment = HorizontalAlignment.Center;
                            window.VerticalAlignment = VerticalAlignment.Center;
                            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                            window.ShowDialog();
                            foundMovie = true;
                        }
                    }


                }

                if(foundID == false)
                {
                    ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getForgotPassword(), "Member ID invalid");
                    window.HorizontalAlignment = HorizontalAlignment.Center;
                    window.VerticalAlignment = VerticalAlignment.Center;
                    window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    window.ShowDialog();
                }
                else
                {
                    if (foundMovie == false)
                    {
                        ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getForgotPassword(), "Your answer is incorret.\nPlease try again");
                        window.HorizontalAlignment = HorizontalAlignment.Center;
                        window.VerticalAlignment = VerticalAlignment.Center;
                        window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                        window.ShowDialog();

                    }
                }

                
            }
        }

        // button to go back
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getLogin());
        }
    }
}
