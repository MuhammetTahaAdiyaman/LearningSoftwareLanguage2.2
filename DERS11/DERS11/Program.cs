using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 6 Basamaklı bir sayının sayı değerlerinin toplamını bulan program*/
            int sayi = 523495;

            int birler = sayi % 10;
            int onlar = (sayi % 100) / 10;
            int yuzler = (sayi % 1000) / 100;
            int binler = (sayi % 10000) / 1000;
            int onBinler = (sayi % 100000) / 10000;
            int yuzBinler = (sayi % 1000000) / 100000;

            int degerToplami = birler + onlar + yuzler + binler + onBinler + yuzBinler;

            //Console.WriteLine(sayi+" sayısının basamaklar toplamı: " + (birler + onlar + yuzler+binler+onBinler+yuzBinler));
            //Ya da bunu şu şekilde yazabiliriz.
            Console.WriteLine("{0} sayısının degerleri toplamı: {1}", sayi, degerToplami);

            Console.ReadLine();
        }
    }
}
