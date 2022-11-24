using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS36
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bos Döndüren Parametreli Metotlar*/
            /*kullanıcıdan aldığımız bilgilerle bilgilerini ekrana bastıran ve yaşını hesaplayan metot yazmak*/
            string isimSoyisim;
            int yas;
            double boy;

            Console.WriteLine("Lutfen Adinizi ve Soyadinizi Giriniz: ");
            isimSoyisim = Console.ReadLine();

            Console.WriteLine("Lutfen Yasinizi Giriniz: ");
            yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lutfen Boyunuzu Giriniz: ");
            boy = double.Parse(Console.ReadLine());

            Console.WriteLine();

            bilgileriGoster(isimSoyisim, yas, boy);
            dogumYiliHesapla(yas);

            Console.ReadLine();        
        }

        static void bilgileriGoster(string i, int y, double b)
        {
            Console.WriteLine("Adınız ve Soyadınız: {0} \n Yaşınız: {1} \n Boyunuz: {2}",i, y, b);
        }
        static void dogumYiliHesapla(int y2)
        {
            Console.WriteLine("Doğum Yılınız: " + (2022-y2));

        }
    }
}
