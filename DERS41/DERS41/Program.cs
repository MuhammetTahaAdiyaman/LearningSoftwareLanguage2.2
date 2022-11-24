using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS41
{
    class Program
    {
        static void Main(string[] args)
        {
            //RECURSIVE --> KENDI KENDINI CAGIRAN METHODLAR (OZYINELEMELI)
            //ITERATIVE --> (TEKRARLAMALI)

            Console.WriteLine("recursive: " + recursiveFaktoriyel(5));
            Console.WriteLine("iterative: " + iterativeFaktoriyel(6));

            Console.ReadLine();
        }

        static int recursiveFaktoriyel(int sayi)
        {
            if (sayi == 1)
            {
                return 1;
            }
            else
            {
                return sayi * recursiveFaktoriyel(sayi - 1);
            }
        }

        static int iterativeFaktoriyel(int sayi1)
        {
            int sonuc=1;
            
                while (sayi1 > 0)
                {
                    sonuc = sonuc * sayi1;
                    sayi1--;
                }
            return sonuc;
        }
    }
}
