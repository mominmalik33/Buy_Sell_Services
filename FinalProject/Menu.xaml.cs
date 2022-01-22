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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
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

        

        private void Profile_Settings(object sender, RoutedEventArgs e)
        {
            UserProfile up = new UserProfile();
            up.Show();
        }

        

        private void About_Us(object sender, RoutedEventArgs e)
        {
            ProfileSettings sett = new ProfileSettings();
            sett.Show();
        }

        

        private void Publish_Item(object sender, RoutedEventArgs e)
        {
            PublishItem pit = new PublishItem();
            pit.Show();
        }

        private void Admin_Panel(object sender, RoutedEventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }
    }
    

}
