using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir sınıftaki öğrenci sayısını şube koduna göre gösteren program*/
            int A, B, C, D;
            char sube;
            Console.WriteLine("Lutfen A subesinin sinif mevcudunu giriniz: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen B subesinin sinif mevcudunu giriniz: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen C subesinin sinif mevcudunu giriniz: ");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen D subesinin sinif mevcudunu giriniz: ");
            D = int.Parse(Console.ReadLine());

            Console.WriteLine("Hangi sınıf mevcudunu merak ediyorsunuz: A/B/C/D");
            sube = char.Parse(Console.ReadLine());

            switch (sube)
            {
                case 'A':
                    Console.WriteLine(A);
                    break;
                case 'B':
                    Console.WriteLine(B);
                    break;
                case 'C':
                    Console.WriteLine(C);
                    break;
                case 'D':
                    Console.WriteLine(D);
                    break;
                default:
                    Console.WriteLine("Girmis oldugunuz sinif mevcudu bulunmamaktadir.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
