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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Main_Menu(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu men = new Menu();
            men.Show();
        }

        private void Services(object sender, RoutedEventArgs e)
        {
            Services ser = new Services();
            ser.Show();
        }

        private void Portal(object sender, RoutedEventArgs e)
        {
            Portal por = new Portal();
            por.Show();
        }

        private void Profile(object sender, RoutedEventArgs e)
        {
            UserProfile up = new UserProfile();
            up.Show();
        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
