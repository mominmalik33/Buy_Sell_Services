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
    /// Interaction logic for ProfileSettings.xaml
    /// </summary>
    public partial class ProfileSettings : Window
    {
        public ProfileSettings()
        {
            InitializeComponent();
        }
        private void About_Us(object sender, RoutedEventArgs e)
        {
            TextBlock info = new TextBlock();
            info.Text = "Contact";
            this.field1.Children.Add(info);

            TextBlock infoData = new TextBlock();
            infoData.Text = "0300 1234567";
            this.field1Data.Children.Add(infoData);



            TextBlock site = new TextBlock();
            site.Text = "Reach Us At";
            this.field2.Children.Add(site);

            TextBlock siteData = new TextBlock();
            siteData.Text = "http://www.houseaccessories.com";
            this.field2Data.Children.Add(siteData);
        }

        private void TermsConditions(object sender, RoutedEventArgs e)
        {

            TextBlock social = new TextBlock();
            social.Text = "Order Cancellation";
            this.field3.Children.Add(social);

            TextBlock socialData = new TextBlock();
            socialData.Text = "Minimum Peroid";
            this.field3Data.Children.Add(socialData);



            TextBlock business = new TextBlock();
            business.Text = "Quality Inspection";
            this.field4.Children.Add(business);

            TextBlock businessData = new TextBlock();
            businessData.Text = "Highly Recommended";
            this.field4Data.Children.Add(businessData);


        }

        private void Privacy_Policy(object sender, RoutedEventArgs e)
        {
            

            TextBlock adver = new TextBlock();
            adver.Text = "Instagram";
            this.field5.Children.Add(adver);


            TextBlock adverData = new TextBlock();
            adverData.Text = "http://www.intagram.com";
            this.field5Data.Children.Add(adverData);
        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Profile_Settings(object sender, RoutedEventArgs e)
        {
            UserProfile upr = new UserProfile();
            upr.Show();
        }
    }
}
