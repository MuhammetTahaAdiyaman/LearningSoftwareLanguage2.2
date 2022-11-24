using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*İki sayının değerlerini birbirleri arasında değiştirme*/

            int sayi1, sayi2;
            Console.WriteLine("Lutfen ilk sayiyi giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen ikinci sayiyi giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("girdiğiniz sayı değerleri: \n birinci sayi: " + sayi1 + "\n ikinci sayi:" + sayi2);
            //ana işlemin yapıldığı alan (SWAP)
            int temp;
            temp = sayi1;
            sayi1 = sayi2;
            sayi2 = temp;
            //burada kafan karışmasın atamalar her zaman sağdan sola doğru yapılır.
            Console.WriteLine("");
            Console.WriteLine("değiştirilmiş sayı değerleri: \n birinci sayi: " + sayi1 + "\n ikinci sayi:" + sayi2);

            Console.ReadLine();

        }
    }
}
