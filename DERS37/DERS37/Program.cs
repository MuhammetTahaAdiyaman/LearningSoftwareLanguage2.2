using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS37
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dönüş değerine sahip metotlar */

            //karesini almak istediğimiz sayi
            int sayi, sonuc;
            Console.WriteLine("Lütfen karesini almak istediginiz sayiyi giriniz: ");
            sayi = int.Parse(Console.ReadLine());
            sonuc = kareAl(sayi);
            Console.WriteLine("Karesi: " + sonuc);

            Console.ReadLine();

            /*isim ve soyismini ekrana bastıran method */
            string isim;
            string soyisim;
            Console.WriteLine("Lütfen isminizi giriniz: ");
            isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisminizi giriniz: ");
            soyisim = Console.ReadLine();

            Console.WriteLine(isimSoyisim(isim, soyisim));

            /*hangi sayi daha buyuk*/
            int s1 = 10;
            int s2 = 20;
            Console.WriteLine("buyuk sayi: " + buyukMu(s1, s2));

            Console.ReadLine();
        }
        static int kareAl(int sayi1)
        {
            return sayi1 * sayi1;
        }
        static string isimSoyisim(string i, string s)
        {
            return i + " " + s;
        }
        static int buyukMu(int sayi3, int sayi4)
        {
            if(sayi3 > sayi4)
            {
                return sayi3;
            }
            else
            {
                return sayi4;
            }
        }
    }
}
