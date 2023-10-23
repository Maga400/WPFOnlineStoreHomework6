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

namespace WPFOnlineStoreHomework
{
    /// <summary>
    /// Interaction logic for AboutPage.xaml
    /// </summary>
    public partial class AboutPage : Window
    {
        public AboutPage()
        {
            InitializeComponent();
            string imageUrl = StaticClass.Image.ToString();
            
            BitmapImage bitmapImage = new BitmapImage(new Uri(imageUrl));
            image_.Source = bitmapImage;
            modelTextBox.Text = StaticClass.Model;
            markaTextBox.Text = StaticClass.Marka;
            colorTextBox.Text = StaticClass.Color;
            memoryTextBox.Text = StaticClass.Memory;
            moneyTextBox.Text = StaticClass.Money.ToString();
            
        }

        public void SetImage(ImageSource imageSource)
        {
            image_.Source = imageSource;
        }

        private void changeInformation(object sender, RoutedEventArgs e)
        {
            StaticClass.Model = modelTextBox.Text;
            StaticClass.Marka = markaTextBox.Text;
            StaticClass.Color = colorTextBox.Text;
            StaticClass.Memory = memoryTextBox.Text;
            StaticClass.Money = moneyTextBox.Text;
        }
    }
}
