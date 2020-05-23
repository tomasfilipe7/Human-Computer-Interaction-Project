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
            string[] allLines = System.IO.File.ReadAllLines("C:/Users/marci/Desktop/IHC_Projeto/ClubMember/ClubMember/users.txt");

            string[] content;
            Boolean foundID = false;
            Boolean foundMovie = false;

            string memberID = textBox1.Text;
            string movie = textBox2.Text;

            if (movie == "" && memberID == "")
            {
                MessageBox.Show("Inputs cannot be left in blank", "Forgot Password", MessageBoxButton.OK);
            }
            else if (movie == "")
            {
                MessageBox.Show("Please answer the question", "Forgot Password", MessageBoxButton.OK);

            }

            else if (memberID == "")
            {
                MessageBox.Show("Please insert member ID", "Forgot Password", MessageBoxButton.OK);

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
                            MessageBox.Show("Your password is: " + content[1], "Forgot Password", MessageBoxButton.OK);
                            foundMovie = true;
                        }
                    }


                }

                if(foundID == false)
                {
                    MessageBox.Show("Member ID invalid", "Forgot Password", MessageBoxButton.OK);
                }
                else
                {
                    if (foundMovie == false)
                    {
                        MessageBox.Show("Your answer is incorret. Please try again", "Forgot Password", MessageBoxButton.OK);

                    }
                }

                
            }
        }
    }
}
