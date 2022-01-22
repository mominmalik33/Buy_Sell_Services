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
    /// Interaction logic for PublishItem.xaml
    /// </summary>
    public partial class PublishItem : Window
    {
        public PublishItem()
        {
            InitializeComponent();
        }

        private void Upload(object sender, RoutedEventArgs e)
        {

            if(this.posstedBy.Text == "" || this.itemName.Text == "" || this.city.Text == "" || this.contact.Text == "" || this.price.Text == "" || this.type.Text == "" || this.categoryCombo.SelectedIndex < 0 || this.perfomanceCombo.SelectedIndex < 0 || this.address.Text == "" ||this.warranty.Text == "")
            {
                MessageBox.Show("Please Provide Complete Data For Processing. Thanks!");
            }
            else
            {
                ComboBoxItem categ = (ComboBoxItem)this.categoryCombo.SelectedItem;
                ComboBoxItem perform = (ComboBoxItem)this.perfomanceCombo.SelectedItem;
                HouseAccessSystemEntities db = new HouseAccessSystemEntities();
                Accessory newAccressory = new Accessory() { 
                    PostedBy = posstedBy.Text,
                    ItemName = itemName.Text,
                    City = city.Text,
                    Contact = contact.Text,
                    Price = price.Text,
                    Type = type.Text,
                    Category = categ.Content.ToString(),
                    Perfomance = perform.Content.ToString(),
                    Address = address.Text,
                    Warranty = warranty.Text
                };
                db.Accessories.Add(newAccressory);
                db.SaveChanges();
                MessageBox.Show("Data Posted Successfully");
                this.Hide();
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu men = new Menu();
            men.Show();
        }
    }
}
