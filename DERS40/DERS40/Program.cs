using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS40
{
    class Program
    {
        static void Main(string[] args)
        {
            /*overloading on methods*/
            Console.WriteLine(isimSoyle("Taha"));
            Console.WriteLine(isimSoyle("Taha", "Adıyaman"));

            Console.ReadLine();
        }

        static string isimSoyle(string isim)
        {
            return "tek parametreli method: " + isim;
        }
        static string isimSoyle(string isim, string soyisim)
        {
            return "iki parametreli method: " + isim+soyisim;
        }

    }
}
