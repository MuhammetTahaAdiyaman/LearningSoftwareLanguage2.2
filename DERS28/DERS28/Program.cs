using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS28
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Restoran Menüsü Programı*/

            double secim;
            double toplam = 0;

            do
            {
                //menu item
                Console.WriteLine("\n1-Adana 12.75 TL");
                Console.WriteLine("2-Beyti 22.50 TL");
                Console.WriteLine("3-Salata 7.00 TL");
                Console.WriteLine("4-Çorba 8.00 TL");
                Console.WriteLine("5-İçecek 4.25 TL");
                Console.WriteLine("6-Çıkış");

                Console.WriteLine("Lutfen istediğiniz yemeklerin seçimini yapınız:");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        toplam = toplam + 12.75;
                        Console.WriteLine("Şu anki hesap" + toplam);
                        break;
                    case 2:
                        toplam = toplam + 22.50;
                        Console.WriteLine("Şu anki hesap" + toplam);
                        break;
                    case 3:
                        toplam = toplam + 7;
                        Console.WriteLine("Şu anki hesap" + toplam);
                        break;
                    case 4:
                        toplam = toplam + 8;
                        Console.WriteLine("Şu anki hesap" + toplam);
                        break;
                    case 5:
                        toplam = toplam + 4.25;
                        Console.WriteLine("Şu anki hesap" + toplam);
                        break;
                    case 6:
                        Console.WriteLine("Hesabınız Tamamlandı");
                        break;
                    default:
                        Console.WriteLine("Lutfen 1-6 arasinda seçim yapiniz");
                        break;
                }
            } while (secim != 6); //seçim 6 ya eşit olana kadar yukarıdaki işlemler devam etsin. seçim 6 olunca döngümüz tamamlansın ve bitsin.

            Console.WriteLine("Toplam Hesabınız: " + toplam);
            Console.ReadLine();
        }


    }
}
