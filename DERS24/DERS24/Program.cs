using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS24
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 den n e kadar olan sayıların toplamını bulan program*/

            int kacaKadar;
            int toplam = 0;
            
            Console.WriteLine("1'den kaça kadar sayıların toplamını bulmak istiyorsunuz ?");
            kacaKadar = int.Parse(Console.ReadLine());    
            while (kacaKadar >0)
            {
                 toplam = toplam+kacaKadar;
                 kacaKadar--;

            }
            
            Console.WriteLine("Sonuc: " + toplam);
            Console.ReadLine();
        }
    }
}
