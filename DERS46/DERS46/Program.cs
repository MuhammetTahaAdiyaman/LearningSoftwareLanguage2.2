using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS46
{
    class Program
    {
        class Insan
        {
            private string isim;
            private int yas;

            public Insan()
            {
                Console.WriteLine("Yeni bir obje yaratıldı");
            }

            public Insan (string isim)
            {
                this.isim = isim;
            }

            public Insan (string isim, int yas)
            {
                this.isim = isim;
                this.yas = yas;
            }

            public void bilgeriSoyle()
            {
                Console.WriteLine("adım {0} ve yaşım {1}", isim, yas);
            }

        }
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            i1.bilgeriSoyle();

            Insan i2 = new Insan("Muhammet Taha ADIYAMAN");
            i2.bilgeriSoyle();

            Insan i3 = new Insan("Taha",24);
            i3.bilgeriSoyle();
           
            Console.ReadLine();
        }
    }
}
