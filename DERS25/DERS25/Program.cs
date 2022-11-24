using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS25
{
    class Program
    {
        static void Main(string[] args)
        {/*iki sayı arasındaki değerlerin toplamını bulan program*/
            /*örneğin 5 ile 10 arasında 5+6+7+8+9+10 toplam 6 sayı oluyor demekki döngümüz 10-5+1 kadar dönecek matematikde terim sayısı kadar diyelim*/

            int sayi1, sayi2;
            Console.WriteLine("Lutfen 1.sayiyi giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen 2.sayiyi giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());

            int döngüSayisi = sayi2 - sayi1 + 1;
            int toplam = 0;
            while(döngüSayisi > 0)
            {
                toplam = toplam + sayi1;
                sayi1++;

                döngüSayisi--;
            }

            Console.WriteLine("{0} ve {1}. sayılar arasındaki değerler toplamı: {2}",sayi1,sayi2,toplam);
            Console.ReadLine();
        }
    }
}
