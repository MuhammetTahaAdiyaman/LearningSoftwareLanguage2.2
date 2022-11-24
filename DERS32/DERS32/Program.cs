using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS32
{
    class Program
    {
        static void Main(string[] args)
        {
            int kacaKadar;
            int bir = 0, iki = 1, uc;
            Console.WriteLine("Kacinci elemana kadar seriyi bastirmak istiyorsunuz. ");
            kacaKadar = int.Parse(Console.ReadLine());

            if (kacaKadar >= 0)
            {
                Console.WriteLine(bir + "\n" + iki);
                for(int i=0; i<kacaKadar; i++)
                {
                    uc = bir + iki;
                    bir = iki;
                    iki = uc;
                    Console.WriteLine(uc);
                }
            }
            else
            {
                Console.WriteLine("Lutfen sıfırdan büyük bir deger giriniz.");
            }

            Console.ReadLine();
        }
    }
}
