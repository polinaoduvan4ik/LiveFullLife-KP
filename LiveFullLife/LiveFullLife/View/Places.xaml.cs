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
    /// Логика взаимодействия для Places.xaml
    /// </summary>
    public partial class Places : Page
    {
        public MainWindow window;
        Model.PlacesViewModel placesmodel;

        public Places(MainWindow window)
        {
            InitializeComponent();
            placesmodel = new Model.PlacesViewModel(window);
            this.window = window;
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

        private void List_Places_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (List_Places.SelectedItem != null)
            {
                Place places = new Place();
                places = (LiveFullLife.Model.Place)List_Places.SelectedItem;
                Place.ID = places.Id; 
                window.OpenPage(MainWindow.Pages.Photo, this);
            }
         
        }

       

        private void Button_Bars_Click(object sender, RoutedEventArgs e)
        {
            List_Places.ItemsSource = placesmodel.LoadBars();
        }

        private void Button_Cafe_Click(object sender, RoutedEventArgs e)
        {
            List_Places.ItemsSource = placesmodel.LoadCafes();

        }

        private void Button_Restourants_Click(object sender, RoutedEventArgs e)
        {
            List_Places.ItemsSource = placesmodel.LoadRestourants();

        }

        private void Button_Coffee_Click(object sender, RoutedEventArgs e)
        {
            List_Places.ItemsSource = placesmodel.LoadCoffee();

        }

        private void Button_Parks_Click(object sender, RoutedEventArgs e)
        {
            List_Places.ItemsSource = placesmodel.LoadParks();

        }

        private void Button_ForCompany_Click(object sender, RoutedEventArgs e)
        {
            List_Places.ItemsSource = placesmodel.LoadCompanies();

        }

        private void Button_Family_Click(object sender, RoutedEventArgs e)
        {
            List_Places.ItemsSource = placesmodel.LoadFamily();

        }

        private void Button_Culture_Click(object sender, RoutedEventArgs e)
        {
            List_Places.ItemsSource = placesmodel.LoadCulture();

        }

        private void City_Bytton_Click(object sender, RoutedEventArgs e)
        {
            window.OpenPage(MainWindow.Pages.Third);
        }

     

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           List_Places.ItemsSource = placesmodel.SearchPlace(Search.Text);
        }
    }
}
