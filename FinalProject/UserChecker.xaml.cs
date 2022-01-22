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
    /// Interaction logic for UserChecker.xaml
    /// </summary>
    public partial class UserChecker : Window
    {
        public UserChecker()
        {
            InitializeComponent();
        }

        private void DBShower(object sender, RoutedEventArgs e)
        {
            HouseAccessSystemEntities he = new HouseAccessSystemEntities();
            this.userGrid.ItemsSource = he.Users.ToList();
        }
    }
}
