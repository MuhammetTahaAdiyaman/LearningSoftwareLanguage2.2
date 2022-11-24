using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcının girmiş olduğu mesleğine göre maaş aralığını söyleyen program*/
            string meslek;
            Console.WriteLine("Lutfen mesleğinizi giriniz: ");
            meslek = Console.ReadLine();

            switch(meslek){

                case "Ogretmen":
                    Console.WriteLine("3500-5000 arası maaş");
                    break;

                case "Doktor":
                    Console.WriteLine("5000-10000 arası maaş");
                    break;

                case "Muhendis":
                    Console.WriteLine("4000-9000 arası maaş");
                    break;

                case "Sofor":
                    Console.WriteLine("3700-8000 arası maaş");
                    break;

                case "Hemsire":
                    Console.WriteLine("4500-8500 arası maaş");
                    break;

                case "Futbolcu":
                    Console.WriteLine("2000000-3500000 arası maaş");
                    break;

                default:
                    Console.WriteLine("Mesleginizin maas aralıgı bilinmemektedir.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
