using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS16
{
    class Program
    {
        static void Main(string[] args)
        { /*Hesap Makinesi Örneği*/

            double sayi1, sayi2, sonuc;
            int islem;


            Console.WriteLine("Lütfen işlem yapmak istediğiniz ilk sayıyı giriniz: ");
            sayi1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen işlem yapmak istediğiniz ikinci sayıyı giriniz: ");
            sayi2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz: \n 1-Toplama (+) \n 2-Çıkarma(-) \n 3-Çarpma(X) \n 4-Bölme (/)");
            islem = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (islem == 1)
            {
                Console.WriteLine("Toplama İslemine Hoşgeldiniz");
                sonuc = sayi1 + sayi2;
                Console.WriteLine(sayi1 + "+" + sayi2 + "=" + sonuc);
            }
            else if (islem == 2)
            {
                Console.WriteLine("Çıkarma İslemine Hoşgeldiniz");
                sonuc = sayi1 - sayi2;
                Console.WriteLine(sayi1 + "-" + sayi2 + "=" + sonuc);
            }
            else if (islem == 3)
            {
                Console.WriteLine("Çarpma İslemine Hoşgeldiniz");
                sonuc = sayi1 * sayi2;
                Console.WriteLine(sayi1 + "X" + sayi2 + "=" + sonuc);
            }
            else if (islem == 4)
            {
                Console.WriteLine("Bölme İslemine Hoşgeldiniz");
                sonuc = sayi1 / sayi2;
                Console.WriteLine(sayi1 + "/" + sayi2 + "=" + sonuc);
            }
            else
            {
                Console.WriteLine("Geçersiz işlem girdiniz.");
            }

            Console.ReadLine();
        }
    }
}
