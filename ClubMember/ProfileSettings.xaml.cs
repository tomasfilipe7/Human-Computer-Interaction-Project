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

namespace ClubMember
{
    /// <summary>
    /// Interaction logic for ProfileSettings.xaml
    /// </summary>
    public partial class ProfileSettings : Page
    {
        private string id;
        private string password;
        private string email;
        private string movie;

        public ProfileSettings()
        {
            InitializeComponent();
        }

        public void setID(string _ID)
        {
            id = _ID;
        }

        public void setPassword(string _password)
        {
            password = _password;
        }

        public void setEmail(string _email)
        {
            email = _email;
        }

        public void setMovie(string _movie)
        {
            movie = _movie;
        }

        // button to Confirm Password
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] line = System.IO.File.ReadAllLines("C:/Users/marci/Desktop/IHC_Projeto/ClubMember/ClubMember/users.txt");

            string[] content;

            string ac_password = textBox1.Password;
            string new_password = textBox4.Password;

            foreach (string l in line)
            {
                content = l.Split(',');

                if (id == content[0])
                {
                    if (ac_password == content[1])
                    {
                        using (StreamWriter writer = new StreamWriter("C:/Users/marci/Desktop/IHC_Projeto/ClubMember/ClubMember/users.txt", true))
                        {

                            content[1] = new_password;
                            writer.WriteLine(content[1]);
                            MessageBox.Show("Password changed!", "Change Password", MessageBoxButton.OK);
                        }
                    }
                }

            }
        }

        // button to Confirm Email
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] line = System.IO.File.ReadAllLines("C:/Users/marci/Desktop/IHC_Projeto/ClubMember/ClubMember/users.txt");

            string[] content;

            string new_email = textBox2.Text;

            foreach (string l in line)
            {
                content = l.Split(',');

                if (id == content[0])
                {
                    using (StreamWriter writer = new StreamWriter("C:/Users/marci/Desktop/IHC_Projeto/ClubMember/ClubMember/users.txt", true))
                    {

                        content[6] = new_email;
                        writer.WriteLine(content[6]);
                        MessageBox.Show("E-mail changed!", "Change E-mail", MessageBoxButton.OK);
                    }
        
                }

            }
        }

        // button to Confirm Movie
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string[] line = System.IO.File.ReadAllLines("C:/Users/marci/Desktop/IHC_Projeto/ClubMember/ClubMember/users.txt");

            string[] content;

            string new_movie = textBox3.Text;

            foreach (string l in line)
            {
                content = l.Split(',');

                if (id == content[0])
                {
                    using (StreamWriter writer = new StreamWriter("C:/Users/marci/Desktop/IHC_Projeto/ClubMember/ClubMember/users.txt", true))
                    {

                        content[7] = new_movie;
                        writer.WriteLine(content[7]);
                        MessageBox.Show("Recovery answer changed!", "Change Recovery Answer", MessageBoxButton.OK);
                    }

                }

            }
        }

        // button to go back
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getProfile());
        }
    }
}
