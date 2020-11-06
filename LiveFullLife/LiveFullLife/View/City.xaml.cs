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

namespace LiveFullLife.View
{
    /// <summary>
    /// Логика взаимодействия для City.xaml
    /// </summary>
    public partial class City : Page
    {
        public MainWindow window;
        public City(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
        }

        private void ButtonOff_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Places_Click(object sender, RoutedEventArgs e)
        {
            window.OpenPage(MainWindow.Pages.Fourth);
        }

        private void Button_Events_Click(object sender, RoutedEventArgs e)
        {
            window.OpenPage(MainWindow.Pages.Fifth);
        }

        private void Button_Tours_Click(object sender, RoutedEventArgs e)
        {
            window.OpenPage(MainWindow.Pages.Sixth);
        }

       

        private void Button_MyPlaces_Click(object sender, RoutedEventArgs e)
        {
            window.OpenPage(MainWindow.Pages.Seventh);
        }

        private void Button_Maps_Click(object sender, RoutedEventArgs e)
        {
            window.OpenPage(MainWindow.Pages.Maps);
        }

        private void ButtonAuth_Click(object sender, RoutedEventArgs e)
        {
            window.OpenPage(MainWindow.Pages.First);

        }
    }
}
