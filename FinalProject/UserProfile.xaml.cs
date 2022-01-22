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
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Window
    {
        public UserProfile()
        {
            InitializeComponent();
            HouseAccessSystemEntities db = new HouseAccessSystemEntities();
            List<User> data = db.Users.ToList();
            var result = from d in db.Users
                    where d.Id == data.Count select d;

            User users = result.SingleOrDefault();
            if (users != null)
            {
                this.firstname.Text = users.Firstname;
                this.lastname.Text = users.Lastname;
                this.email.Text = users.Email;
                this.password.Text = users.Password;

            }
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            HouseAccessSystemEntities db = new HouseAccessSystemEntities();
            List<User> data = db.Users.ToList();
            var result = from d in db.Users
                         where d.Id == data.Count
                         select d;

            User users = result.SingleOrDefault();
            if (users != null)
            {
                users.Firstname = this.firstname.Text;
                users.Lastname = this.lastname.Text;
                users.Email = this.email.Text;
                users.Password = this.password.Text;
                db.SaveChanges();
                MessageBox.Show("Account Record Updated Successfully");
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messagBoxResult = MessageBox.Show("Do You Want To Delete The Account?",
                "Deactivating Account....",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning,
                MessageBoxResult.No
                );
            if(messagBoxResult == MessageBoxResult.Yes)
            {
                HouseAccessSystemEntities db = new HouseAccessSystemEntities();
                List<User> data = db.Users.ToList();
                var result = from d in db.Users
                             where d.Id == data.Count
                             select d;

                User users = result.SingleOrDefault();
                if (users != null)
                {
                    db.Users.Remove(users);
                    db.SaveChanges();
                    MessageBox.Show("Data Deleted Successfully");
                    this.Hide();
                    MainWindow mw = new MainWindow();
                    mw.Show();
                }

            }

        }
    }
}
