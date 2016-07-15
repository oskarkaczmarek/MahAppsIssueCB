using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MahAppsIssueCB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        

        ObservableCollection<Tuple<int, string>> _SomeCollection;
        public ObservableCollection<Tuple<int, string>> SomeCollection
        {
            get
            {
                if(_SomeCollection == null)
                {
                    _SomeCollection = new ObservableCollection<Tuple<int, string>>() {
                        new Tuple<int, string>(1, "Lorem Ipsum"),
                        new Tuple<int, string>(2, "dolor sit amet"),
                        new Tuple<int, string>(3, "bacon"),
                        new Tuple<int, string>(4, "sausage"),
                        new Tuple<int, string>(4, "avada kedavra")

                    };

                }
                return _SomeCollection;
            }
        }
        

        public MainWindow() : base()
        {

            DataContext = this;
            InitializeComponent();


        }
        
    }
}
