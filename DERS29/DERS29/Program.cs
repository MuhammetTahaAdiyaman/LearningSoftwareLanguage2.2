using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS29
{
    class Program
    {
        static void Main(string[] args)
        {
            /*İki sayının EBOB değerini bulan program*/
            int sayi1, sayi2;
            Console.WriteLine("Lütfen 1.sayıyı giriniz");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2.sayıyı giriniz");
            sayi2 = int.Parse(Console.ReadLine());

            int orgSayi1 = sayi1;
            int orgSayi2 = sayi2;

            sayi1 = (sayi1 < 0) ? -sayi1 : sayi1;
            sayi2 = (sayi2 < 0) ? -sayi2 : sayi2;
            while(sayi1 != sayi2)
            {
                if (sayi1 > sayi2)
                {
                    sayi1 = sayi1 - sayi2;
                }
                else
                {
                    sayi2 = sayi2 - sayi1;
                }
            }

            Console.WriteLine("EBOB({0},{1}) = {2}", orgSayi1, orgSayi2, sayi1);
            
            Console.ReadLine();
        }
    }
}
