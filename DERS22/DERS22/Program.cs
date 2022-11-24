using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             while(sart)
            {
                şart doğru olduğu sürece burada bulunan kodlar çalışsın
            }
            */

            /*0 dan 10 kadar sayıları ekrana bastırma
            int sayac = 0;
            while (sayac < 10)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            */

            /*1 dan 10 kadar sayıları ekrana bastırma
            int sayac = 0;
            while (sayac < 10)
            {
                Console.WriteLine(sayac++);
                sayac++;
            }
            */

            /*10 dan 1 kadar sayıları ekrana bastırma
            int sayac = 10;
            while (sayac > 1)
            {
                Console.WriteLine(sayac);
                sayac--;
            }
            */

            /*10 tane isim ekrana bastırma
            string isim = "taha";
            int sayac = 1;
            while (sayac < 10)
            {
                Console.WriteLine(isim);
                sayac++;
            }
            */

            string isim = "taha";
            int sayac = 0;
            while (isim == "taha")
            {
                Console.WriteLine(isim);
                sayac++;
                if(sayac == 10)
                {
                    isim = "";
                }
            }
            Console.ReadLine();
        }
    }
}
