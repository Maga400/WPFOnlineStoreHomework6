using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFOnlineStoreHomework
{
    public static class SearchItem
    {
        public static ObservableCollection<Element> Elements { get; set; } = new ObservableCollection<Element>();
    }
}
