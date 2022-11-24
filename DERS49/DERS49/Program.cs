using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int toplam = 0;
            string[] isimler = { "Mustafa", "Kemal", "Atatürk", "Atamizindeyiz" };
            /*
            for(int i=0; i<sayilar.Length; i++)
            {
                toplam = toplam + sayilar[i];
            }
            */
            /*
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            
            Console.WriteLine(toplam);
            */
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
