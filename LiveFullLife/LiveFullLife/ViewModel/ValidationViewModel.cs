using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace LiveFullLife
{
    class ValidationViewModel
    {
        public static void Registr_log(string str)
        {
            Regex regex = new Regex(@"[^a-z0-9]+");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                throw new Exception("Неверный формат имени пользователя");
            }
        }

        public static void Registr_pas(string str)
        {
            Regex regex = new Regex(@"[^0-9]+");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                throw new Exception("Пароль может содержать только цифры");
            }
        }

        public static void UserInf_Data(string str)
        {
            Regex regex = new Regex(@"[^A-zА-я\-]+");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                throw new Exception("Неверный формат введенных данных");
            }
        }

        public static void UserInf_Street(string str)
        {
            Regex regex = new Regex(@"[^0-9A-zА-я\-]+");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                throw new Exception("Неверный формат введенных данных");
            }
        }

       
        public static void NoPoint(string str)
        {
            Regex regex = new Regex(@"[.,]+");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                throw new Exception("Неверный формат названия");
            }
        }

        public static void Adress(string str)
        {
            Regex regex = new Regex(@"[^0-9A-я.\- ]+");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                throw new Exception("Неверный формат адреса");
            }
        }

        public static void Description(string str)
        {
            Regex regex = new Regex(@"[@#$%^&*+=`~]+");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                throw new Exception("Неверный формат описания");
            }
        }

       
    }
}
