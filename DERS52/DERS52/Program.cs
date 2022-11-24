using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS52
{
    class Program
    {   
        class Insan
        {
            public const double PI = 3.14;

            public string isim;
            public int yas;
            private static int insanSayisi = 0;

            public Insan()
            {
                insanSayisi++;
            }

            public static int insanSayisiniSoyle()
            {
                return insanSayisi;
            }
        }
        static void Main(string[] args)
        {
            Insan i1 = new Insan();

            Insan i2 = new Insan();

            Insan i3 = new Insan();


            Console.WriteLine(Insan.insanSayisiniSoyle());

            Console.WriteLine(Insan.PI);

            Console.ReadLine();
        }
    }
}
