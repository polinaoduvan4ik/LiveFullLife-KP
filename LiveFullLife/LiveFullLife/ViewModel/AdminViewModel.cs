using LiveFullLife.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace LiveFullLife.Model
{
    class AdminViewModel
    {
        public MainWindow window;
        public  byte[] imageData;

        public AdminViewModel(MainWindow window)
        {
            this.window = window;
        }

        //загрузка списка
        public List<Place> LoadDb()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                List<Place> place = new List<Place>();
                foreach (var a in places)
                {
                    
                        place.Add(a);
                    
                }
                return place;
            }
        }

        public void Delete(LiveFullLife.Model.Place o)
        {
            using(var context = new MyDbContext())
            {
                var places = context.Places;
                var places_inf = context.Place_information;
                var places_wanted = context.Wanted_places;
                var places_visited = context.Visited_places;
                foreach(var a in places)
                {
                     if (o == null)
                    {
                        MessageBox.Show("Объект не указан");
                        return;
                    }
                    else if(a.Id == o.Id)
                    {
                        places.Remove(a);
                    }
                   

                }
                foreach(var b in places_inf)
                {
                    if(b.Id_place == o.Id)
                    {
                        places_inf.Remove(b);
                    }
                    
                }
                foreach (var b in places_wanted)
                {
                    if (b.Place_id == o.Id)
                    {
                        places_wanted.Remove(b);
                    }
                }
                foreach (var b in places_visited)
                {
                    if (b.Visited_place_id == o.Id)
                    {
                        places_visited.Remove(b);
                    }
                }
                context.SaveChanges();
            }
        }
        
        //загрузка фотографии
        public void LoadImageIn()
        {
            
            var dlg = new OpenFileDialog { Filter = "JPG (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|Png (*.png)|*.png" };
            if (dlg.ShowDialog() != true) return;
            using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);
            }
        }
        
            
        
        public void AddNewPlace(string name, string adress, string type, string description)
        {
            try
            {
                int ID_PL = 0;
                if (name.Length > 0 && adress.Length > 0 && description.Length > 0 && type.Length > 0 && imageData != null)
                {
                    
                    ValidationViewModel.NoPoint(name);
                    ValidationViewModel.Adress(adress);
                    ValidationViewModel.Description(description);
                    using (var context = new MyDbContext())
                    {
                        var place = context.Places;
                        var place_inf = context.Place_information;

                        Place place1 = new Place { Place_name = name, Place_adress = adress, Place_type = type };
                        foreach(var a in place)
                        {
                            if(a.Place_adress == place1.Place_adress && a.Place_name == place1.Place_name && a.Place_type == place1.Place_type)
                            {
                                MessageBox.Show("Такое место уже существует");
                                return;
                            }
                            
                        }
                        place.Add(place1);
                        context.SaveChanges();
                        foreach (var a in place)
                        {
                            if (a.Place_name == name)
                                ID_PL = a.Id;
                        }
                        Place_information place_Information1 = new Place_information { Id_place = ID_PL, Place_discriptin = description, Photo_place = imageData };
                        place_inf.Add(place_Information1);
                        context.SaveChanges();

                    }

                }
                else MessageBox.Show("Не все данные введены");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        public void AddNewEvent(string name, string adress, string description)
        {
            try
            {
                int ID_PL = 0;
                if (name.Length > 0 && adress.Length > 0 && description.Length > 0 && imageData != null)
                {

                    ValidationViewModel.NoPoint(name);
                    ValidationViewModel.Adress(adress);
                    ValidationViewModel.Description(description);
                    using (var context = new MyDbContext())
                    {
                        var place = context.Places;
                        var place_inf = context.Place_information;

                        Place place1 = new Place { Place_name = name, Place_adress = adress, Place_type = "выставки" };
                        foreach (var a in place)
                        {
                            if (a.Place_adress == place1.Place_adress && a.Place_name == place1.Place_name && a.Place_type == place1.Place_type)
                            {
                                MessageBox.Show("Такая выставка уже существует");
                                return;
                            }

                        }
                        place.Add(place1);
                        context.SaveChanges();
                        foreach (var a in place)
                        {
                            if (a.Place_name == name)
                                ID_PL = a.Id;
                        }
                        Place_information place_Information1 = new Place_information { Id_place = ID_PL, Place_discriptin = description, Photo_place = imageData };
                        place_inf.Add(place_Information1);
                        context.SaveChanges();
                    }

                }
                else MessageBox.Show("Не все данные введены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddNewTour(string name, string description)
        {
            try
            {
                int ID_PL = 0;
                if (name.Length > 0 && description.Length > 0 && imageData != null)
                {

                    ValidationViewModel.NoPoint(name);
                    ValidationViewModel.Description(description);
                    using (var context = new MyDbContext())
                    {
                        var place = context.Places;
                        var place_inf = context.Place_information;

                        Place place1 = new Place { Place_name = name, Place_adress = " ", Place_type = "экскурсии" };
                        foreach (var a in place)
                        {
                            if (a.Place_adress == place1.Place_adress && a.Place_name == place1.Place_name && a.Place_type == place1.Place_type)
                            {
                                MessageBox.Show("Такая экскурсия уже существует");
                                return;
                            }

                        }
                        place.Add(place1);
                        context.SaveChanges();
                        foreach (var a in place)
                        {
                            if (a.Place_name == name)
                                ID_PL = a.Id;
                        }
                        Place_information place_Information1 = new Place_information { Id_place = ID_PL, Place_discriptin = description, Photo_place = imageData };
                        place_inf.Add(place_Information1);
                        context.SaveChanges();
                        window.OpenPage(MainWindow.Pages.AdminPage);
                    }

                }
                else MessageBox.Show("Не все данные введены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
