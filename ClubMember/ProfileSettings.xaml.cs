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
            string[] line = System.IO.File.ReadAllLines("users.txt");
            Boolean found = false;
            string[] content;

            string ac_password = textBox1.Password;
            string new_password = textBox4.Password;

            foreach (string l in line)
            {
                content = l.Split(',');

                if (ac_password == content[1])
                {
                    PageManager.pagemanager.getPerson().setPassword(new_password);
                    PageManager.pagemanager.getPerson().savePerson();
                    ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getProfileSettings(), "Password changed!");
                    window.HorizontalAlignment = HorizontalAlignment.Center;
                    window.VerticalAlignment = VerticalAlignment.Center;
                    window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    window.ShowDialog();
                    found = true;
                }                

            }
            
            if (found == false)
            {
                ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getProfileSettings(), "Your actual password is incorret");
                window.HorizontalAlignment = HorizontalAlignment.Center;
                window.VerticalAlignment = VerticalAlignment.Center;
                window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                window.ShowDialog();

            }

            textBox1.Password = "";
            textBox4.Password = "";


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string email = textBox2.Text;
            PageManager.pagemanager.getPerson().setEmail(email);
            PageManager.pagemanager.getPerson().savePerson();
            ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getProfileSettings(), "E-mail changed!");
            window.HorizontalAlignment = HorizontalAlignment.Center;
            window.VerticalAlignment = VerticalAlignment.Center;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.ShowDialog();

            textBox2.Text = "";
        }

        // button to Confirm Movie
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string movie = textBox3.Text;
            PageManager.pagemanager.getPerson().setMovie(movie);
            PageManager.pagemanager.getPerson().savePerson();
            ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getProfileSettings(), "Recovery answer changed!");
            window.HorizontalAlignment = HorizontalAlignment.Center;
            window.VerticalAlignment = VerticalAlignment.Center;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.ShowDialog();

            textBox3.Text = "";
        }

        // button to go back
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getProfile());
        }
    }
}
