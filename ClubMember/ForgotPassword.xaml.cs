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

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string[] allLines = System.IO.File.ReadAllLines("C:/Users/marci/Desktop/IHC_Projeto/ClubMember/ClubMember/users.txt");

            string[] content;
            Boolean found = false;

            string movie = textBox1.Text;

            if(movie == "")
            {
                MessageBox.Show("Please answer the question", "Forgot Password", MessageBoxButton.OK);
            }

            else
            {
                foreach(string l in allLines)
                {
                    content = l.Split(",");

                    if(movie == content[7])
                    {
                        MessageBox.Show("Your password is: " + content[1], "Forgot Password", MessageBoxButton.OK);
                        found = true;
                    }
                }

                if(found == false)
                {
                    MessageBox.Show("Your answer is incorret. Please try again", "Forgot Password", MessageBoxButton.OK);

                }
            }
        }
    }
}
