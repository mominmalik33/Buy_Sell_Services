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
    /// Interaction logic for AccessoryChecker.xaml
    /// </summary>
    public partial class AccessoryChecker : UserControl
    {
        public AccessoryChecker()
        {
            InitializeComponent();
        }
        private void DBShower(object sender, RoutedEventArgs e)
        {
            HouseAccessSystemEntities db = new HouseAccessSystemEntities();
            this.userGrid.ItemsSource = db.Accessories.ToList();
        }
    }
}
