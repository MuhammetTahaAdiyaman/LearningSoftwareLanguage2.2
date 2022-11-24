using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS26
{/* Bir sayının Faktöriyelini Hesaplama*/
    class Program
    {
        static void Main(string[] args)
        {
            int faktor;

            Console.WriteLine("Lutfen Faktoriyel almak istediginiz sayiyi giriniz: ");
            faktor = int.Parse(Console.ReadLine());

            if(faktor == 0)
            {
                Console.WriteLine("sonuc: 1");
            }
            else if(faktor < 0)
            {
                Console.WriteLine("Lutfen 0 veya 0 dan büyük değer giriniz.");
            }
            else
            {
                int toplam = 1;
                while (faktor > 0)
                {
                    toplam = toplam * faktor;
                    faktor--;
                }

                Console.WriteLine("Sonuc: " + toplam);
            }

            Console.ReadLine();
        }
        
    }
}
