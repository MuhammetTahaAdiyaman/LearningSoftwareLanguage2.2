using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS48
{
    class Insan
    {
        public string Isım { get; set; }
        public int Yas { get; set; }

        public Insan(string isim, int yas)
        {
            this.Isım = isim;
            this.Yas = yas;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int sayi1 = 5;
            int sayi2 = 6;
            int sayi3 = 7;
            int sayi4 = 8;
            */
            /* 1.yöntem
            int[] sayilar = new int[4];
            sayilar[0] = 5;
            sayilar[1] = 6;
            sayilar[2] = 7;
            sayilar[3] = 8;
            /*
            Console.WriteLine(sayilar[0]);
            Console.WriteLine(sayilar[1]);
            Console.WriteLine(sayilar[2]);
            Console.WriteLine(sayilar[3]);
            */

            /*
            for(int i=0; i<4; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            */

            /*2.yöntem
            int[] sayilar = new int[4] { 5, 6, 7, 8 }; 
            */

            /*3.yöntem
            int[] sayilar = { 5, 6, 7, 8 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
             
             */


            /*
            string[] isimler = { "Mustafa", "Kemal", "Atatürk" };


            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            */

            /*class ile oluşturduğumuz objeleri de dizi halinde tutabiliyoruz*/

            Insan i1 = new Insan("Taha", 24);
            Insan i2 = new Insan("Ecem", 23);

            Insan[] insanlar = { i1, i2 };
            for (int i = 0; i < insanlar.Length; i++)
            {
                Console.WriteLine(insanlar[i].Isım + " " + insanlar[i].Yas);
            }

            Console.ReadLine();
        }
    }
}
