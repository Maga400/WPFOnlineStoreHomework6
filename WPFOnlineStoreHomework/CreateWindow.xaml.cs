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
    /// Interaction logic for CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        public CreateWindow()
        {
            InitializeComponent();
        }

        private void changeInformation(object sender, RoutedEventArgs e)
        {
            StaticClass.Model = modelTextBox.Text;
            StaticClass.Marka = markaTextBox.Text;
            StaticClass.Color = colorTextBox.Text;
            StaticClass.Memory = memoryTextBox.Text;
            StaticClass.Money = moneyTextBox.Text;
            StaticClass.Image = imageTextBox.Text;
            
        }
    }
}
