using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4 tane sayıdan en büyük olanı bulan program*/
            
            
            int a, b, c, d, buyuk;
            /*ilk önce iki sayının kıyaslamasını yapalım
            a = 5;
            b = 4;

            if (a < b)
            {
                buyuk = b;
            }
            else
            {
                buyuk = a;

            }
            */

            /*şimdi 4 sayi kiyaslamasini yapalım
            a = 7;
            b = 6;
            c = 5;
            d = 4;

            if (a > b) //a
            {
                if (c > d) //c
                {
                    if (a > c)//a
                    {
                        buyuk = a;
                    }
                    else//c
                    {
                        buyuk = c;
                    }
                }
                else
                {
                    if (a > d) //a
                    {
                        buyuk = a;
                    }
                    else//d
                    {
                        buyuk = d;
                    }
                }
            }
            else //b
            {
                if (c > d)
                {
                    if (b > c)
                    {
                        buyuk = b;
                    }
                    else
                    {
                        buyuk = c;
                    }
                }
                else
                {
                    if (b > d)
                    {
                        buyuk = b;
                    }
                    else
                    {
                        buyuk = d;
                    }
                }
            }
            */
            //yukarıdaki iç içe if mantığını kullanarak en büyük sayıyı bulmuş olduk.
            //daha kolay şekilde karşılaştırma yapabiliriz geçen derslerde öğrendiğimiz math kütüphanesini kullanarak şimdi aşağıda gösterelim.
            a = 50;
            b = 55;
            c = 45;
            d = 47;

            buyuk = Math.Max(a, b); //bu fonksiyon sadece iki sayıyı kıyaslıyor bundan dolayı buradan gelen sonuc buyuk değişkenimize atayacak aşağıda büyük değişken ile sıradaki sayıyı kıyaslıyacağız.
            buyuk = Math.Max(buyuk, c);
            buyuk = Math.Max(buyuk, d);
            Console.WriteLine(buyuk);
            Console.ReadLine();
        }
    }
}
