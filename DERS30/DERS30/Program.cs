using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS30
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 ile N arasındaki sayıları konsola yazdıran program*/
            int kacaKadar, aralik;

            Console.WriteLine("Lutfen kaca kadar yazdirmak istediginizi giriniz: ");
            kacaKadar = int.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen yazdirmak istediginizi araligi giriniz: ");
            aralik = int.Parse(Console.ReadLine());
        
            for(int i=0; i<=kacaKadar; i += aralik)
            {
                Console.WriteLine(i); /*burada mantık şu şekilde 0 dan başla kaça kadarsa oraya kadar yazdır ancak
                                       şu şekilde arttır örneğin 1den 10 a kadar ikişer arttırma diyelim 
                                       0 < 10 evet o zaman ekrana bastı geldi 2şer arttırdı 2<10 evet o zaman 2 yi bastır
                                       sonra iki arttır 4 oldu 4<10 evet o zaman 4'ü ekrana bastır bu şekilde bir mantığı var.*/
            }

            Console.ReadLine();
        }
    }
}
