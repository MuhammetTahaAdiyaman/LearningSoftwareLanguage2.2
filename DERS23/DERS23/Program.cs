using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS23
{
    class Program
    {
        static void Main(string[] args)
        { /*(İç-içe) While döngüsü Çarpım tablosu*/

            int sayi1 = 1;

            int sayi2 = 1;

            while(sayi1 <= 10)
            {
                while(sayi2 <= 10)
                {
                    Console.WriteLine(sayi1 + "*" + sayi2 + "=" + sayi1 * sayi2);
                    sayi2++;
                }

                sayi1++;
                sayi2 = 1;
            }

            Console.ReadLine();
        }
    }
}
