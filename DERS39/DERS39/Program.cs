using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS39
{
    class Program
    {
        static void Main(string[] args)
        {
            /*passing by value
             * passing by reference
             * out -->reference*/
            
            
            //passing by value
            int x = 5;
            kupHesapla(x); //125
            Console.WriteLine(x); //5

            Console.WriteLine();
            
            //passing by reference (ikinci method)
            int x1 = 4;
            kareHesapla(ref  x1); //16
            Console.WriteLine(x1); //16 cause of change address

            //out by reference (ücüncü method)
            int x2; //değer ataması method içinde yapıldı out kullanılarak.
            dorduncuKuvvet(out x2);
            Console.WriteLine(x2);


            Console.ReadLine();
        }

        static void kupHesapla(int sayi)
        {
            sayi = sayi * sayi * sayi;
            Console.WriteLine(sayi);
        }
        static void kareHesapla(ref int sayi)
        {
            sayi = sayi * sayi;
            Console.WriteLine(sayi);
        }
        static void dorduncuKuvvet(out int sayi)
        {
            sayi = 2;
            sayi = sayi * sayi*sayi*sayi;
            Console.WriteLine(sayi);
        }

    }
}
