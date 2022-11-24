using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS14
{
    class Program
    {
        static void Main(string[] args)
        { /*Kullanıcıdan almış olduğu vize ve final notlarına göre geçme durumunu hesaplayan program*/

            /*ilk önce basit bir örnek ile başlayalım. 50 üstü notlar geçsin. 50 altı notlar kalsın.

            int puan;
            Console.WriteLine("Lutfen almis oldugunuz sinav notunu giriniz: ");
            puan = int.Parse(Console.ReadLine());

            if (puan > 50)
            {
                Console.WriteLine("Başarılı! Tebrikler, sınavı geçtiniz.");
            }
            else
            {
                Console.WriteLine("Başarısız! Üzgünüz, sınavdan kaldınız.");
            }

            */

            //şimdi biraz daha zor bir örnek yapalım kullanıcının girmiş olduğu notu harf notuna göre değerlendiren bir program yazalım.
            /*85 üstü alırsa AA
              70-85 arası alırsa BA
              55-70 arası alırsa BB
              40-55 arası alırsa CB
              25-55 arası alırsa DC
              25 altı alırsa FF olsun.
             

            double sinavNotu;
            Console.WriteLine("Lutfen sinavdan almis oldugunuz puani yaziniz: ");
            sinavNotu = double.Parse(Console.ReadLine());

            if (sinavNotu > 85)
            {
                Console.WriteLine("Başarılı! AA ile geçtiniz.");
            }
            else if (sinavNotu > 70 && sinavNotu < 85)
            {
                Console.WriteLine("Başarılı! BA ile geçtiniz.");
            }
            else if (sinavNotu > 55 && sinavNotu < 70)
            {
                Console.WriteLine("Başarılı! BB ile geçtiniz.");
            }
            else if (sinavNotu > 40 && sinavNotu < 55)
            {
                Console.WriteLine("CB ile geçtiniz.");
            }
            else if (sinavNotu > 25 && sinavNotu < 40)
            {
                Console.WriteLine("DC ile geçtiniz.");
            }
            else
            {
                Console.WriteLine("Başarısız! kaldiniz.");
            }
            */

            /*yukarıdaki örneği biraz daha detaylandıralım vize1 vize2 ve final ortalamasını hesaplayıp yaptıralım */

            double vize1, vize2, Final, ortalama;
            Console.WriteLine("Lutfen 1.vizeden almis oldugunuz puani yaziniz: ");
            vize1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen 2.vizeden almis oldugunuz puani yaziniz: ");
            vize2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen finalden almis oldugunuz puani yaziniz: ");
            Final = double.Parse(Console.ReadLine());

            ortalama = vize1 * 0.25 + vize2 * 0.35 + Final * 0.4;

            if (ortalama >= 85)
            {
                Console.WriteLine("Notunuz: {0}",ortalama+" Başarılı! AA ile geçtiniz.");
            }
            else if (ortalama >= 70 && ortalama < 85)
            {
                Console.WriteLine("Notunuz: {0}", ortalama + " Başarılı! BA ile geçtiniz.");
            }
            else if (ortalama >= 55 && ortalama < 70)
            {
                Console.WriteLine("Notunuz: {0}", ortalama + " Başarılı! BB ile geçtiniz.");
            }
            else if (ortalama >= 40 && ortalama < 55)
            {
                Console.WriteLine("Notunuz: {0}", ortalama + " CB ile geçtiniz.");
            }
            else if (ortalama >= 25 && ortalama < 40)
            {
                Console.WriteLine("Notunuz: {0}", ortalama + " DC ile geçtiniz.");
            }
            else
            {
                Console.WriteLine("Notunuz: {0}", ortalama + " Başarısız! kaldiniz.");
            }
            Console.ReadLine();
        }
    }
}
