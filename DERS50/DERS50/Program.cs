using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS50
{
    class Program
    {
        static void Main(string[] args)
        {
            //tek boyutlu dizi
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(*****)

            //2 boytulu dizi
            int[,] sayilar1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i=0; i<3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sayilar1[i, j] +"");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
