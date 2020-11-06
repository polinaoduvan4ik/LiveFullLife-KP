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
    /// Логика взаимодействия для Enter_Reg.xaml
    /// </summary>
    public partial class Enter_Reg : Page
    {
        public MainWindow window;
        Model.ViewModel model;
        public Enter_Reg(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
            model = new Model.ViewModel(window);
        }
        public Enter_Reg()
        {
            InitializeComponent();
            
        }
        private void ButtonOff_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Enter_Click(object sender, RoutedEventArgs e)
        {
         
            model.Enter(Input_Login.Text, Input_Password.Password);

        }

        private void Button_Registration_Click(object sender, RoutedEventArgs e)
        {
              model.Registration(Input_Login.Text, Input_Password.Password);
        }
        
    }
}
