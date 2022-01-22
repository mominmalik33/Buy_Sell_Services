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
    /// Interaction logic for Portal.xaml
    /// </summary>
    public partial class Portal : Window
    {
        public Portal()
        {
            InitializeComponent();
            HouseAccessSystemEntities he = new HouseAccessSystemEntities();
            this.AccessGrid.ItemsSource = he.Accessories.ToList();
        }

        private void Buy_Product(object sender, RoutedEventArgs e)
        {
            int accessId = 0;
            if (this.AccessGrid.SelectedIndex >= 0)
            {
                if (this.AccessGrid.SelectedItems.Count >= 0)
                {
                    if (this.AccessGrid.SelectedItems[0].GetType() == typeof(Accessory))
                    {
                        Accessory access = (Accessory)this.AccessGrid.SelectedItems[0];
                        accessId = access.Id;
                        MessageBoxResult messagBoxResult = MessageBox.Show("Do You Want To Buy This Item?",
                            "Placing Order....",
                            MessageBoxButton.YesNo,
                            MessageBoxImage.Warning,
                            MessageBoxResult.No
                         );
                        if (messagBoxResult == MessageBoxResult.Yes)
                        {
                            HouseAccessSystemEntities db = new HouseAccessSystemEntities();
                            var result = from d in db.Accessories
                                         where d.Id == accessId
                                         select d;

                            Accessory data = result.SingleOrDefault();
                            if (data != null)
                            {
                                db.Accessories.Remove(data);
                                db.SaveChanges();
                                MessageBox.Show("Purchasing Done Successfully!");
                                this.Hide();
                            }

                        }
                        
                    }
                }
            }
        }
            private void Cancel(object sender, RoutedEventArgs e)
            {
                this.Hide();
            }
        }
    }
