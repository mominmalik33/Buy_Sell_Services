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
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void signUp(object sender, RoutedEventArgs e)
        {
            if (email.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");
            }
            else
            {
                HouseAccessSystemEntities db = new HouseAccessSystemEntities();
                var result = from d in db.Users
                             where d.Email == email.Text && d.Password == password.Text
                             select d;

                User users = result.SingleOrDefault();
                if (users != null)
                {
                    this.Hide();
                    MessageBox.Show("Logged In Successfully!!!");
                    Home hm = new Home();
                    hm.Show();
                }
                else
                {
                    MessageBox.Show("Sorry Record Does Not Exist!");
                }
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
