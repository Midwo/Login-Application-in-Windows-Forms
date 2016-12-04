using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Application
{
    class typ_generyczny_podmiana
    {
        public static void podmianka<T>(ref T first, ref T second)
        {
            T temp = second;
            second = first;
            first = temp;

        }
    }
}
