using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS7
{
    class Program
    {
        static void Main(string[] args)
        {
            //increament and decreament operators (arttırma ve azaltma operatörleri)
            /*
            int sayi1 = 5;

            Console.WriteLine(sayi1);

            sayi1 = sayi1 + 1;

            Console.WriteLine(sayi1);
            
            sayi1 += 1;
            
            Console.WriteLine(sayi1);

            sayi1++; //postfixed

            Console.WriteLine(sayi1);

            ++sayi1; // prefixed
            Console.WriteLine(sayi1);

            Console.ReadLine();

            */

            int x = 0;
            int y = 5;

            x = y++;
            Console.WriteLine(x + " " + y);

            x = 0;
            y = 5;

            x = ++y;
            Console.WriteLine(x + " " + y);

            Console.ReadLine();
        }
    }
}
