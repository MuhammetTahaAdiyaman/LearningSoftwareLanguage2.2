using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS33
{
    class Program
    {
        static void Main(string[] args)
        {
            /* çarpım tablosu

            for(int i=1; i<10; i++)
            {
                for(int j=1; j<10; j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + i * j);
                    
                }
                
            }
            */
            for (int i = 1, j=1; i < 10 && j <10; i++, j++)
            {
               Console.WriteLine(i + "x" + j + "=" + i * j);
            }

            Console.ReadLine();
        }
    }
}
