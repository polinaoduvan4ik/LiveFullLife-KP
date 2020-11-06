using LiveFullLife.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для Image.xaml
    /// </summary>
    public partial class Photo : Page
    {
        public MainWindow window;
        Model.PlacesViewModel placesmodel;
        Page previouspage;

        public Photo(MainWindow window, Page page)
        {
            InitializeComponent();
            this.window = window;
            placesmodel = new Model.PlacesViewModel(window);
            this.previouspage = page;
            PlaceImg.Source = placesmodel.LoadImage();
            Description.Content = placesmodel.Text();
        }
       

       

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Wanted_Check.IsChecked)
            {
                placesmodel.Wanted();
            }
            if ((bool)Visited_Check.IsChecked)
            {
                placesmodel.Visited();
            }
            if (previouspage.GetType() == typeof(Places))
            {
                window.OpenPage(MainWindow.Pages.Fourth);

            }
            else if (previouspage.GetType() == typeof(MyPlaces))
            {
                window.OpenPage(MainWindow.Pages.Seventh);

            }
            else if (previouspage.GetType() == typeof(Tours))
            {
                window.OpenPage(MainWindow.Pages.Sixth);

            }
            else if (previouspage.GetType() == typeof(Events))
            {
                window.OpenPage(MainWindow.Pages.Fifth);

            }
        }

        
    }
}
