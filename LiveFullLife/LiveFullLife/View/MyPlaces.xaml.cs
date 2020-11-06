using LiveFullLife.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для MyPlaces.xaml
    /// </summary>
    public partial class MyPlaces : Page
    {
        public MainWindow window;
        Model.PlacesViewModel placesmodel;

        public MyPlaces(MainWindow window)
        {
            InitializeComponent();
            placesmodel = new Model.PlacesViewModel(window);
            this.window = window;
            List_MyWanted.ItemsSource = placesmodel.LoadWanted();
            List_MyVisited.ItemsSource = placesmodel.LoadVisited();
        }

        
        private void ButtonOff_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = propertyDescriptor.DisplayName;
            e.Cancel = true;
        }

        private void List_MyWanted_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (List_MyWanted.SelectedItem != null)
            {
                Place places = new Place();
                places = (LiveFullLife.Model.Place)List_MyWanted.SelectedItem;
                Place.ID = places.Id;
                window.OpenPage(MainWindow.Pages.Photo,this);
            }

        }


        private void City_Bytton_Click(object sender, RoutedEventArgs e)
        {
            window.OpenPage(MainWindow.Pages.Third);
        }

        private void Button_Places_Click(object sender, RoutedEventArgs e)
        {
            List_MyWanted.ItemsSource = placesmodel.Load_MyPlacesWanted();
            List_MyVisited.ItemsSource = placesmodel.Load_MyPlacesVisited();
        }

        private void Button_Events_Click(object sender, RoutedEventArgs e)
        {
            List_MyWanted.ItemsSource = placesmodel.Load_EventsWanted();
            List_MyVisited.ItemsSource = placesmodel.Load_EventsVisited();
        }

        private void Button_Tours_Click(object sender, RoutedEventArgs e)
        {
            List_MyWanted.ItemsSource = placesmodel.Load_ToursWanted();
            List_MyVisited.ItemsSource = placesmodel.Load_ToursVisited();
        }
    }
}
