using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS43
{
    class Program
    { //Birbirleriyle selamlaşan ve tanışan 2 insan 

        class Insan
        {
            private string isim;
            private int yas;

            public void selamVer()
            {
                Console.WriteLine("Merhaba :)");
            }

            public void bilgileriSor()
            {
                Console.WriteLine("Adın ne ve yaşın kaç ? ");
            }

            public void cevapVer()
            {
                Console.WriteLine("Adım " + isim + " ve yaşım " + yas);
            }

            public void isimVeYasDuzenle(string isim, int yas)
            {
                this.isim = isim;
                this.yas = yas;
            }
        }
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan();

            i1.isimVeYasDuzenle("Taha", 24);
            i2.isimVeYasDuzenle("Muhammet", 25);

            i1.selamVer();
            i2.selamVer();
            i1.bilgileriSor();
            i2.cevapVer();
            i2.bilgileriSor();
            i1.cevapVer();


            Console.ReadLine();
        }
    }
}
