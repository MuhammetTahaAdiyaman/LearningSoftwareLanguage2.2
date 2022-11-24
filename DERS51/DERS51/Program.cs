using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS51
{
    class Program
    {   
        class Insan
        {
            public Insan()
            {
                Console.WriteLine("Obje oluşturuldu.");
            }

            ~Insan()
            {
                Console.WriteLine("Oluşturulan objeler kaldırıldı.");
            }
        }
        static void Main(string[] args)
        {
            objeOlustur();

            GC.Collect();
            Console.ReadLine();
        }

        static void objeOlustur()
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan();
        }
    }
}
