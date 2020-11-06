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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LiveFullLife.View
{
    /// <summary>
    /// Логика взаимодействия для Users_Inf.xaml
    /// </summary>
    public partial class Users_Inf : Page
    {
        public MainWindow window;
        Model.DataViewModel datamodel;
        public Users_Inf(MainWindow window, object o)
        {
            InitializeComponent();
            this.window = window;
            datamodel = new Model.DataViewModel(window,o);
        }
        public Users_Inf()
        {
            InitializeComponent();
        }
        private void ButtonOff_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Button_Data_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                datamodel.Ok(Input_Name.Text, Input_Surname.Text, Input_Country.Text, Input_City.Text, Input_Street.Text, int.Parse(Input_House.Text), int.Parse(Input_Flat.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникло исключение: {ex.Message} ");
            }


        }
    }
}
