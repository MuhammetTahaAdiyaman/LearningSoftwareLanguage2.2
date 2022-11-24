using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*iç içe if else yapısını kullanarak yaşa göre yaş grubunu söyleyen program */
            /*0-3 yaş bebeklik 
             *3-7 yaş bebek sonrası 
             *7-14 çocukluk 
             *14-18 ergenlik 
             *18-25 genclik 
             *25-40 orta yaş 
             *40-55 orta yaş üstü 
             *55 sonrası yaşlılık */


            int yas;
            Console.WriteLine("Lutfen yaşınızı giriniz: ");
            yas = int.Parse(Console.ReadLine());

            if (yas >= 18)
            {
                if (yas > 55)
                {
                    Console.WriteLine("Yaşlı Kategorisinde Yer Almaktasınız");
                }
                else if (yas > 40)
                {
                    Console.WriteLine("Orta Yaş Üstü Kategorisinde Yer Almaktasınız");

                }
                else if (yas > 25)
                {
                    Console.WriteLine("Orta Yaş Kategorisinde Yer Almaktasınız");

                }
                else
                {
                    Console.WriteLine("Gençlik Kategorisinde Yer Almaktasınız");

                }
            }
            else
            {
                if (yas < 3)
                {
                    Console.WriteLine("Bebek Kategorisinde Yer Almaktasınız");
                }
                else if (yas < 7)
                {
                    Console.WriteLine("Bebek Sonrası Yaş Kategorisinde Yer Almaktasınız");
                }
                else if (yas < 14)
                {
                    Console.WriteLine("Çocuk Kategorisinde Yer Almaktasınız");
                }
                else
                {
                    Console.WriteLine("Ergenlik Kategorisinde Yer Almaktasınız");
                }
            }

            Console.ReadLine();








        }
    }

}
        
