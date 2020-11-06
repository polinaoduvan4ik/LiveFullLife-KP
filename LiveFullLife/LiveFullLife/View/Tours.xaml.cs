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
    /// Логика взаимодействия для Tours.xaml
    /// </summary>
    public partial class Tours : Page
    {
        public MainWindow window;
        Model.PlacesViewModel placesmodel;

        public Tours(MainWindow window)
        {
            InitializeComponent();
            placesmodel = new Model.PlacesViewModel(window);
            List_Tours.ItemsSource = placesmodel.LoadTours();
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

        private void List_Tours_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (List_Tours.SelectedItem != null)
            {
                Place places = new Place();
                places = (LiveFullLife.Model.Place)List_Tours.SelectedItem;
                Place.ID = places.Id;
                window.OpenPage(MainWindow.Pages.Photo, this);
            }

        }
        private void City_Bytton_Click(object sender, RoutedEventArgs e)
        {
            window.OpenPage(MainWindow.Pages.Third);

        }

    }
}
