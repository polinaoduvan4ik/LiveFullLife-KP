using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using LiveFullLife.View;
using LiveFullLife.ViewModel;


namespace LiveFullLife
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenPage(Pages.First);

        }

        public enum Pages { First, Second, Third, Fourth, Fifth, Sixth, Seventh, Photo, Maps, AdminPage }
        public void OpenPage(Pages page)
        {
            if (page == Pages.First)
            {
                MainFrame.Navigate(new Enter_Reg(this));

            }
            if (page == Pages.Third)
            {
                MainFrame.Navigate(new City(this));

            }
            if (page == Pages.Fourth)
            {
                MainFrame.Navigate(new Places(this));

            }

            if (page == Pages.Fifth)
            {
                MainFrame.Navigate(new Events(this));

            }
            if (page == Pages.Sixth)
            {
                MainFrame.Navigate(new Tours(this));

            }
            if (page == Pages.Seventh)
            {
                MainFrame.Navigate(new MyPlaces(this));

            }
            if (page == Pages.Maps)
            {
                MainFrame.Navigate(new Map(this));

            }
            if (page == Pages.AdminPage)
            {
                MainFrame.Navigate(new AdminControl(this));

            }
           

        }

        public void OpenPage(Pages page, object o)
        {
            if (page == Pages.Second)
            {
                MainFrame.Navigate(new Users_Inf(this, o));

            }
        }

        public void OpenPage(Pages page, Page o)
        {
            if (page == Pages.Photo)
            {
                MainFrame.Navigate(new Photo(this, o));

            }

        }



    }
    
}
