using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using System.Windows;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Linq;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Windows.Controls;
using System.Data.Entity.Validation;

namespace LiveFullLife.Model
{
    class DataViewModel
    {
        public MainWindow window;
        User user;
        public DataViewModel(MainWindow window, object o)
        {
            this.window = window;
            user = o as User;
        }
        public void Ok(string name, string surname, string country, string city, string street, int house, int flat)
        {
            try
            {
                if (name.Length > 0 && surname.Length > 0 && country.Length > 0 && city.Length > 0 && street.Length > 0)
                {
                    ValidationViewModel.UserInf_Data(name);
                    ValidationViewModel.UserInf_Data(surname);
                    ValidationViewModel.UserInf_Data(country);
                    ValidationViewModel.UserInf_Data(city);
                    ValidationViewModel.UserInf_Data(street);
                                                    using (var context = new MyDbContext())
                                                    {
                                                        var userinf = context.Users_information;
                                                        var useradr = context.Users_adress;


                                                        Users_information users_Information = new Users_information { Id_user = user.Id, Name = name, Surname = surname };
                                                        Users_adress users_Adress = new Users_adress { Id_adress = user.Id, Country = country, City = city, Street = street, House = house, Flat = flat };
                                                        userinf.Add(users_Information);
                                                        context.SaveChanges();
                                                        useradr.Add(users_Adress);
                                                        context.SaveChanges();
                                                        MessageBox.Show("Данные добавлены");
                                                        window.OpenPage(MainWindow.Pages.Third);
                                                    }
                  
                }
              else MessageBox.Show("Введены не все данные");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
            
    
}
