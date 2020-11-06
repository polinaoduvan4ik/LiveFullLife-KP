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
    /// Логика взаимодействия для AdminControl.xaml
    /// </summary>
    public partial class AdminControl : Page
    {
         Model.AdminViewModel adminControl;
        public MainWindow window;
        bool AddPlaceOpen = false;
        bool AddEventOpen = false;
        bool AddTourOpen = false;
     
        public AdminControl(MainWindow window)
        {
            InitializeComponent();
            adminControl = new Model.AdminViewModel(window);
            List_Places.ItemsSource = adminControl.LoadDb();
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
        private void Add_Place_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!AddPlaceOpen && !AddTourOpen && !AddEventOpen)
            {
                AddPlace addPlace = new AddPlace(window);
                addPlace.Show();
                Delete_Button.IsEnabled = false;
                AddPlaceOpen = true;
            }
           
        }

        private void Add_Event_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!AddPlaceOpen && !AddTourOpen && !AddEventOpen)
            {
                AddEvent addEvent = new AddEvent(window);
                addEvent.Show();
                Delete_Button.IsEnabled = false;
                AddEventOpen = true;
            }
               
        }

        private void Add_Tour_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!AddPlaceOpen && !AddTourOpen && !AddEventOpen)
            {
                AddTour addTour = new AddTour(window);
                addTour.Show();
                Delete_Button.IsEnabled = false;
                AddTourOpen = true;
            }

               
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            adminControl.Delete((LiveFullLife.Model.Place)List_Places.SelectedItem);
            List_Places.ItemsSource = adminControl.LoadDb();
        }

        private void ButtonAuth_Click(object sender, RoutedEventArgs e)
        {
            window.OpenPage(MainWindow.Pages.First);
        }
    }
}
