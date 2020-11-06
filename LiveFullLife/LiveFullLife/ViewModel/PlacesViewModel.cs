using LiveFullLife.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Xml;

namespace LiveFullLife.Model
{
    public class PlacesViewModel
    {

        public MainWindow window;

        public PlacesViewModel(MainWindow window)
        {
            this.window = window;
        }

        //выгрузка изображения
        public BitmapImage LoadImage()
        {
            
                Place_information place1 = new Place_information();
                using (var context = new MyDbContext())
                {
                    var places = context.Place_information;

                    foreach (var a in places)
                    {
                        place1 = context.Place_information.FirstOrDefault(x => x.Id_place == Place.ID);

                    }


                }

                var image = new BitmapImage();
                using (var mem = new MemoryStream(place1.Photo_place))
                {
                    mem.Position = 0;
                    image.BeginInit();
                    image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.UriSource = null;
                    image.StreamSource = mem;
                    image.EndInit();
                }
                image.Freeze();
                return image;
           
            
        }

        public string Text()
        {
            Place_information text1 = new Place_information();
            using (var context = new MyDbContext())
            {
                var places = context.Place_information;
                foreach (var a in places)
                {
                    text1 = context.Place_information.FirstOrDefault(x => x.Id_place == Place.ID);
                }
            }

            return text1.Place_discriptin;
        }
        //список желаний - места
        public List<Place> Load_MyPlacesWanted()
        {
            
                using (var context = new MyDbContext())
                {
                    var places = context.Places;
                    var wanted = context.Wanted_places;
                    List<Place> place = new List<Place>();
                    foreach (var a in wanted)
                    {
                        foreach (var b in places)
                        {
                            if (a.Place_id == b.Id && a.User_id == User.ID_u)
                            {
                                if (b.Place_type == "бар" || b.Place_type == "кафе" || b.Place_type == "ресторан" || b.Place_type == "кофейня" || b.Place_type == "парк" || b.Place_type == "для компаний" || b.Place_type == "семейный отдых" || b.Place_type == "культурный отдых")
                                {
                                    place.Add(b);
                                }
                            }

                        }

                    }
                    return place;
                }
            
          
           
        }

        //список желаний - выставки
        public List<Place> Load_EventsWanted()
        {
            
                using (var context = new MyDbContext())
                {
                    var places = context.Places;
                    var wanted = context.Wanted_places;
                    List<Place> place = new List<Place>();
                    foreach (var a in wanted)
                    {
                        foreach (var b in places)
                        {
                            if (a.Place_id == b.Id && a.User_id == User.ID_u)
                            {
                                if (b.Place_type == "выставки")
                                {
                                    place.Add(b);
                                }
                            }

                        }

                    }
                    return place;
                }
           
            
        }

        //список желаний - экскурсии
        public List<Place> Load_ToursWanted()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                var wanted = context.Wanted_places;
                List<Place> place = new List<Place>();
                foreach (var a in wanted)
                {
                    foreach (var b in places)
                    {
                        if (a.Place_id == b.Id && a.User_id == User.ID_u)
                        {
                            if (b.Place_type == "экскурсии")
                            {
                                place.Add(b);
                            }
                        }

                    }

                }
                return place;
            }
        }


        //список посещений - места
        public List<Place> Load_MyPlacesVisited()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                var visited = context.Visited_places;
                List<Place> place = new List<Place>();
                foreach (var a in visited)
                {
                    foreach (var b in places)
                    {
                        if (a.Visited_place_id == b.Id && a.V_User_id == User.ID_u)
                        {
                            if (b.Place_type == "бар" || b.Place_type == "кафе" || b.Place_type == "ресторан" || b.Place_type == "кофейня" || b.Place_type == "парк" || b.Place_type == "для компаний" || b.Place_type == "семейный отдых" || b.Place_type == "культурный отдых")
                            {
                                place.Add(b);
                            }
                        }

                    }

                }
                return place;
            }
        }

        //список посещений - выставки
        public List<Place> Load_EventsVisited()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                var visited = context.Visited_places;
                List<Place> place = new List<Place>();
                foreach (var a in visited)
                {
                    foreach (var b in places)
                    {
                        if (a.Visited_place_id == b.Id && a.V_User_id == User.ID_u)
                        {
                            if (b.Place_type == "выставки" )
                            {
                                place.Add(b);
                            }
                        }

                    }

                }
                return place;
            }
        }

        //список посещений - экскурсии
        public List<Place> Load_ToursVisited()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                var visited = context.Visited_places;
                List<Place> place = new List<Place>();
                foreach (var a in visited)
                {
                    foreach (var b in places)
                    {
                        if (a.Visited_place_id == b.Id && a.V_User_id == User.ID_u)
                        {
                            if (b.Place_type == "экскурсии")
                            {
                                place.Add(b);
                            }
                        }

                    }

                }
                return place;
            }
        }

     
        // добавление в желания
        public void Wanted()
        {
            using ( var context = new MyDbContext())
            {
                
                var wanted = context.Wanted_places;
                foreach (var a in wanted)
                {
                    if (a.Place_id == Place.ID && a.User_id == User.ID_u)
                    {
                        MessageBox.Show("Это место уже добавлено.");
                        return;
                    }

                }
                Wanted_places wanted_Places = new Wanted_places { Place_id = Place.ID, User_id = User.ID_u };
                wanted.Add(wanted_Places);
                context.SaveChanges();

            }

        }

        //добавление в посещения
        public void Visited()
        {

            using (var context = new MyDbContext())
            {

                var visited = context.Visited_places;
                var wanted = context.Wanted_places;
                foreach (var a in visited)
                {
                    if (a.Visited_place_id == Place.ID && a.V_User_id == User.ID_u)
                    {
                        MessageBox.Show("Это место уже добавлено.");
                        return;
                    }

                }
                Visited_places visited_Places = new Visited_places { Visited_place_id = Place.ID, V_User_id = User.ID_u };
                visited.Add(visited_Places);
                context.SaveChanges();
                foreach(var a in wanted)
                {
                    if (visited_Places.Visited_place_id == a.Place_id)
                    {
                        wanted.Remove(a);
                    }

                }
                context.SaveChanges();

            }
           



        }

        //загрузка желаний
        public List<Place> LoadWanted()
        {
            using (var context = new MyDbContext())
            {
                var wanted = context.Wanted_places;
                List<Place> place = new List<Place>();

                foreach (var a in wanted)
                {
                    if(a.User_id == User.ID_u)
                    {
                        var places = context.Places;
                        foreach (var b in places)
                        {
                            if(a.Place_id == b.Id)
                            {
                                place.Add(b);

                            }

                        }

                    }
                    
                }
                return place;

            }
        }

        //загрузка посещений
        public List<Place> LoadVisited()
        {
            using (var context = new MyDbContext())
            {
                var visited = context.Visited_places;
                List<Place> place = new List<Place>();

                foreach (var a in visited)
                {
                    if (a.V_User_id == User.ID_u)
                    {
                        var places = context.Places;
                        foreach (var b in places)
                        {
                            if (a.Visited_place_id == b.Id)
                            {
                                place.Add(b);

                            }

                        }

                    }

                }
                return place;

            }
        }

       

        public List<Place> LoadBars()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                List<Place> place = new List<Place>();
                foreach (var a in places)
                {
                    if(a.Place_type == "бар")
                    {
                        place.Add(a);
                    }
                }
                return place;
            }
        }

        public List<Place> LoadCafes()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                List<Place> place = new List<Place>();
                foreach (var a in places)
                {
                    if (a.Place_type == "кафе")
                    {
                        place.Add(a);
                    }
                }
                return place;
            }
        }

        public List<Place> LoadRestourants()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                List<Place> place = new List<Place>();
                foreach (var a in places)
                {
                    if (a.Place_type == "ресторан")
                    {
                        place.Add(a);
                    }
                }
                return place;
            }
        }

        public List<Place> LoadCoffee()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                List<Place> place = new List<Place>();
                foreach (var a in places)
                {
                    if (a.Place_type == "кофейня")
                    {
                        place.Add(a);
                    }
                }
                return place;
            }
        }

        public List<Place> LoadParks()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                List<Place> place = new List<Place>();
                foreach (var a in places)
                {
                    if (a.Place_type == "парк")
                    {
                        place.Add(a);
                    }
                }
                return place;
            }
        }

        public List<Place> LoadCompanies()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                List<Place> place = new List<Place>();
                foreach (var a in places)
                {
                    if (a.Place_type == "для компаний")
                    {
                        place.Add(a);
                    }
                }
                return place;
            }
        }

        public List<Place> LoadFamily()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                List<Place> place = new List<Place>();
                foreach (var a in places)
                {
                    if (a.Place_type == "семейный отдых")
                    {
                        place.Add(a);
                    }
                }
                return place;
            }
        }

        public List<Place> LoadCulture()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                List<Place> place = new List<Place>();
                foreach (var a in places)
                {
                    if (a.Place_type == "культурный отдых")
                    {
                        place.Add(a);
                    }
                }
                return place;
            }
        }
        public List<Place> LoadTours()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                List<Place> place = new List<Place>();
                foreach (var a in places)
                {
                    if (a.Place_type == "экскурсии")
                    {
                        place.Add(a);
                    }
                }
                return place;
            }
        }

        public List<Place> LoadEvents()
        {
            using (var context = new MyDbContext())
            {
                var places = context.Places;
                List<Place> place = new List<Place>();
                foreach (var a in places)
                {
                    if (a.Place_type == "выставки")
                    {
                        place.Add(a);
                    }
                }
                return place;
            }
        }

        public List<Place> SearchPlace(string name)
        {
            using(var context = new MyDbContext())
            {
                var places = context.Places;
                List<Place> place = new List<Place>();
                Regex regex = new Regex(@"\w*" + name + @"\w*", RegexOptions.IgnoreCase);

                foreach(var a in places)
                {
                    if(a.Place_type == "бар" || a.Place_type == "кафе" || a.Place_type == "ресторан" || a.Place_type == "кофейня" || a.Place_type == "парк" || a.Place_type == "для компаний" || a.Place_type == "семейный отдых" || a.Place_type == "культурный отдых")
                    {
                        MatchCollection matches = regex.Matches(a.Place_name);
                        if (matches.Count > 0)
                        {
                            place.Add(a);
                        }
                    }

                }
                return place;
            }
        }

    }
}
