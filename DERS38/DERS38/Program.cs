using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS38
{
    class Program
    {
        static void Main(string[] args)
        {
            //main içidne değer ataması ile yapalım.
            Console.WriteLine("Alan: "+dikdortgenAlan(5, 6));

            //main içinde parametre isimlerine göre atama yapalım ayrıca ilk yukseklik sonra da genislik verelim sırayla olmasın
            Console.WriteLine("Alan: " + dikdortgenAlan(yukseklik: 10, genislik: 5));

            //ikinci methodu boş olarak çağıralım
            ekranaBas(); //normalde boş olarak method çağırdığımızda hata alırdık ama burada method içinde değer ataması yaptık bundan dolayı hata almadı ve ekrana opsiyonel olarak atadığımız değerleri gördük.

            //ikinci method üzerinde s1 ve s2 e değer ataması yapalım ancak s3 ye yapmayalım
            ekranaBas(5, 3);

            //ikinci method üzerinde s1 ve s3 e değer ataması yapalım ancak s2 ye yapmayalım (parametre isimlerine göre değer ataması yapalım)
            ekranaBas(s1: 5, s3: 6);
            Console.ReadLine();


        }

        static int dikdortgenAlan(int genislik, int yukseklik)
        {
            return genislik * yukseklik;
        }

        //opsiyonel olarak değer ataması yapalım 3 sayıyı ekrana yazdıran bir method üzerinde

        static void ekranaBas(int s1=0, int s2=0, int s3=0)
        {
            Console.WriteLine("s1: " + s1 + " s2: " + s2 + " s3: " + s3);
        }
    }
}
