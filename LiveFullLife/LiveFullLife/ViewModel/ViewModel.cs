using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using System.Windows;
using System.Security.Cryptography;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Linq;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Windows.Controls;
using System.Data.Entity.Validation;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LiveFullLife.Model
{
     public class ViewModel 
    {
        public MainWindow window;
        
        public ViewModel(MainWindow window)
        {
            this.window = window;
        }
        

        public static string generateSHA512(string input)
        {
            input = input + "KLDFN1523DFV4";
            SHA256 shaM = new SHA256Managed();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = shaM.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            input = sBuilder.ToString();
            return (input);
        }
        
        public void Enter(string login, string password)
        {
            try
            {
                if (login.Length > 0)
                {
                    if (password.Length > 0)
                    {
                        string passwordhash = generateSHA512(password);
                        using (var context = new MyDbContext())
                        {
                            var users = context.Users;

                            foreach (var a in users)
                            {
                                if (a.Password == passwordhash && a.Login == login)
                                {
                                    if (login == "admin")
                                    {
                                        window.OpenPage(MainWindow.Pages.AdminPage);
                                        return;
                                    }
                                    else
                                    {
                                        window.OpenPage(MainWindow.Pages.Third);
                                        User.ID_u = a.Id;
                                        return;
                                    }

                                }

                            }
                            MessageBox.Show("Пользователь не найден");
                            return;
                        }
                    }
                    MessageBox.Show("Пароль не введен");
                    return;
                }
                MessageBox.Show("Логин не введен");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void Registration(string login, string password)
        {
            try
            {
                if (login.Length > 0)
                {
                    if (login.Length >= 4)
                    {
                        ValidationViewModel.Registr_log(login);
                        if (login != "admin")
                        {
                            if (password.Length > 0)
                            {
                                ValidationViewModel.Registr_pas(password);
                                    string passwordhash = generateSHA512(password);
                                    using (var context = new MyDbContext())
                                    {
                                        var users = context.Users;

                                        foreach (var a in users)
                                        {
                                            if (a.Login == login)
                                            {
                                                MessageBox.Show("Пользователь уже зарегистрирован");
                                                return;
                                            }

                                        }

                                        User user = new User { Login = login, Password = passwordhash };

                                        users.Add(user);
                                        context.SaveChanges();
                                        User.ID_u = user.Id;
                                        window.OpenPage(MainWindow.Pages.Second, user);



                                    }

                            }

                            else MessageBox.Show("Пароль не введен");
                            return;
                        }
                        else MessageBox.Show("Это имя пользователя недоступно");
                        return;
                    
                    }
                    else MessageBox.Show("Логин не может быть меньше 4 символов");
                    return;
                }
             else MessageBox.Show("Логин не введен");
                
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
       
        
    }

    
}
