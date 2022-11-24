using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS27
{
    class Program
    {
        static void Main(string[] args)
        {
            /* do-while döngüsü; diğerlerinden farkı şarta bakılmaksızın döngüye bir kez giriyor ve sonunda şartın sağlanıp sağlanmadığını kontrol ediyor*/

            int sayi = 10;
            int toplam = 0;

            do
            {
                toplam = toplam + sayi;
                sayi--;
            } while (sayi > 10); //diğer döngülerde ekrana 0 yazması gerek çünkü şartı sağlamıyor 10 10'a eşit ancak do while da ekrana 10 bastıracak çünkü 1 kez döngü içine girdi ve toplam=10 oldu onu ekrana bastı sonra sayi bir azaltı 9 oldu şarta takıldı ve döngü sonlandı.

            Console.WriteLine("Sonuc: " + toplam);

            sayi = 10;
            toplam = 0;

            while (sayi > 10)
            {
                toplam = toplam + sayi;
                sayi--;
            }

            Console.WriteLine("Sonuc: " + toplam);

            Console.ReadLine();
        }
    }
}
