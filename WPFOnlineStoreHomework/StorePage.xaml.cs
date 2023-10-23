using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
using WPFOnlineStoreHomework;

namespace WPFOnlineStoreHomework
{
    public partial class StorePage : Page
    {
       
        public ObservableCollection<Element> Elements {get; set; }
        //public ObservableCollection<Element> Elements2 {get; set; }
        public StorePage()
        {
            InitializeComponent();

            Elements = new ObservableCollection<Element>()
            {
                new(){Image="C:\\Users\\Professional\\source\\repos\\WPFOnlineStoreHomework\\WPFOnlineStoreHomework\\image\\Iphone15.jpg",Marka="Iphone",Model="15 pro max",Color="White",Money="4420",Memory="1TB" },
                new(){Image="C:\\Users\\Professional\\source\\repos\\WPFOnlineStoreHomework\\WPFOnlineStoreHomework\\image\\Iphone12.jpg",Marka="Iphone",Model="12 pro max",Color="Pacific blue",Money="3720",Memory="512GB" },
                new(){Image="C:\\Users\\Professional\\source\\repos\\WPFOnlineStoreHomework\\WPFOnlineStoreHomework\\image\\Iphone11.jpg",Marka="Iphone",Model="11 pro max",Color="Grey",Money="2700",Memory="512GB" },
                new(){Image="C:\\Users\\Professional\\source\\repos\\WPFOnlineStoreHomework\\WPFOnlineStoreHomework\\image\\SamsungS23.jpg",Marka="Samsung",Model="S23 Ultra",Color="Green",Money="2750",Memory="512GB" },
                new(){Image="C:\\Users\\Professional\\source\\repos\\WPFOnlineStoreHomework\\WPFOnlineStoreHomework\\image\\SamsungNote20U.jpg",Marka="Samsung",Model="Note20 ultra",Color="Black",Money="2450",Memory="512GB" },
                new(){Image="C:\\Users\\Professional\\source\\repos\\WPFOnlineStoreHomework\\WPFOnlineStoreHomework\\image\\AppleWatch2.jpg",Marka="Apple",Model="Watch ultra 2",Color="Blue",Money="700",Memory="64GB" },
                new(){Image="C:\\Users\\Professional\\source\\repos\\WPFOnlineStoreHomework\\WPFOnlineStoreHomework\\image\\AppleAirpods.jpg",Marka="Apple",Model="Airpods pro 2nd",Color="White",Money="2200",Memory="Yaddas yoxdur" },
                new(){Image="C:\\Users\\Professional\\source\\repos\\WPFOnlineStoreHomework\\WPFOnlineStoreHomework\\image\\AppleAirpodsMax.jpg",Marka="Apple",Model="Airpods max",Color="Green",Money="1600",Memory="Yaddas yoxdur" },
            };

            
            //DataContext = this;

        }

        private void select(object sender, RoutedEventArgs e) 
        {

            StaticClass.Money = Elements[items.SelectedIndex].Money.ToString();
            StaticClass.Image = Elements[items.SelectedIndex].Image;
            StaticClass.Color = Elements[items.SelectedIndex].Color;
            StaticClass.Marka = Elements[items.SelectedIndex].Marka;
            StaticClass.Model = Elements[items.SelectedIndex].Model;
            StaticClass.Memory = Elements[items.SelectedIndex].Memory;
            
            
        }

        private void addElement(object sender, RoutedEventArgs e)
        {
            AddElement.Elements.Add(Elements[items.SelectedIndex]);
            
        }

        private void showAddElement(object sender, RoutedEventArgs e)
        {
            
            BasketElement basket = new BasketElement();
            basket.ShowDialog();
            
        }

        private void a(object sender, TextChangedEventArgs e)
        {
        }

        private void show(object sender, MouseButtonEventArgs e)
        {
            AboutPage ab = new AboutPage();
            ab.ShowDialog();

            Elements[items.SelectedIndex].Model = StaticClass.Model;
            Elements[items.SelectedIndex].Marka = StaticClass.Marka;
            Elements[items.SelectedIndex].Color = StaticClass.Color;
            Elements[items.SelectedIndex].Money = StaticClass.Money;
            Elements[items.SelectedIndex].Memory = StaticClass.Memory;

        }

        private void allShow(object sender, RoutedEventArgs e)
        {
            DataContext = this;
        }

        private void createElement(object sender, RoutedEventArgs e)
        {
            CreateWindow create = new CreateWindow();
            create.ShowDialog();
            Element element = new Element();

            element.Model = StaticClass.Model;
            element.Marka = StaticClass.Marka;
            element.Color = StaticClass.Color;
            element.Money = StaticClass.Money;
            element.Memory = StaticClass.Memory;
            element.Image = StaticClass.Image;
            Elements.Add(element);
        }
    }
}
