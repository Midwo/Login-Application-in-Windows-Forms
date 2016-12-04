using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Application
{
    class Uzytkownik_zalogowany
    {
        private static string _zalogowany;
        //public static string zalogowany { get; set; }
        //private static string _czas_zalogowania;
        //you can choice
        public static string zalogowany
        {
            get
            {
                return _zalogowany;
            }


            set
            {
                _zalogowany = value;
            }
        }



        public static string czas_zalogowania { get; set; }

        public static string zalogowany_czas_zalogowania()
        {
            string x = String.Format("{0}, pracujesz na aplikacji od: {1}", _zalogowany, czas_zalogowania);
            return x;
        }


    }
}
}
