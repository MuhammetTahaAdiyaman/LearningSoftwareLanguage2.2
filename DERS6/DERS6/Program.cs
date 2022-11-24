using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS6
{
    class Program
    {
        static void Main(string[] args)
        {
            //assignment(atama) operatörleri
            int sayi = 5;
            Console.WriteLine(sayi);

            sayi = sayi + 3;
            Console.WriteLine(sayi);
            sayi += 3;
            Console.WriteLine(sayi);
            sayi = sayi - 3;
            Console.WriteLine(sayi);
            sayi -= 3;
            Console.WriteLine(sayi);
            sayi = sayi / 4;
            Console.WriteLine(sayi);

            Console.WriteLine("mod işlemleri");
            sayi = sayi % 2;
            Console.WriteLine(sayi);


            Console.ReadLine();

        }
    }
}
