using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Sign_In(object sender, RoutedEventArgs e)
        {
            if(this.firstname.Text == "" || this.lastname.Text == "" || this.email.Text == "" || this.password.Text == "")
            {
                MessageBox.Show("Please fill all the required fields");
            }
            else
            {
                HouseAccessSystemEntities db = new HouseAccessSystemEntities();
                User newUser = new User() { 
                    Firstname = firstname.Text,
                    Lastname = lastname.Text,
                    Email = email.Text,
                    Password = password.Text
                };
                db.Users.Add(newUser);
                db.SaveChanges();
                this.Hide();
                MessageBox.Show("Account Created Successfully");
                Home hm = new Home();
                hm.Show();
            }
        }

        private void Sign_Up(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }

    }
}
