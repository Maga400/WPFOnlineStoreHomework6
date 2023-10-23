using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for BasketElement.xaml
    /// </summary>
    public partial class BasketElement : Window
    {
        public ObservableCollection<Element> Elementss { get; set; }
        public BasketElement()
        {

            InitializeComponent();

            Elementss = AddElement.Elements;
            DataContext = this;

        }

    }
}
