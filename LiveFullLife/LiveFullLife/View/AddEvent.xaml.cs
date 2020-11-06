using LiveFullLife.Model;
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
using System.Windows.Shapes;

namespace LiveFullLife
{
    /// <summary>
    /// Логика взаимодействия для AddEvent.xaml
    /// </summary>
    public partial class AddEvent : Window
    {
        MainWindow window;
        AdminViewModel adminmodel;
        public AddEvent(MainWindow window)
        {
            InitializeComponent();
            adminmodel = new AdminViewModel(window);
            this.window = window;
        }


        private void LoadImage_Button_Click(object sender, RoutedEventArgs e)
        {
            adminmodel.LoadImageIn();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            adminmodel.AddNewEvent(Input_NameEvent.Text, Input_AdressEvent.Text, Input_DescriptionEvent.Text);
            this.Close();
            window.OpenPage(MainWindow.Pages.AdminPage);
        }
    }
}
