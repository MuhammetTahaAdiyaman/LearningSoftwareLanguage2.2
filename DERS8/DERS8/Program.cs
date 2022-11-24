using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*kare ve dikdörtgenin alanını ve çevresini hesaplayan program*/

            Console.WriteLine("********************** Programa Hosgeldiniz **********************");

            double karekenar;

            double dikdortgenUzun;
            double dikdortgenKisa;

            double kareCevre;
            double DikdortgenCevre;

            double kareAlan;
            double DikdortgenAlan;

            Console.WriteLine("Lutfen karenin kenar degerini giriniz: ");
            karekenar = double.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen dikdörtgenin uzun kenar degerini giriniz: ");
            dikdortgenUzun = double.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen dikdörtgenin kısa kenar degerini giriniz: ");
            dikdortgenKisa = double.Parse(Console.ReadLine());

            /*çevre işlem bölgesi*/
            kareCevre = (4*karekenar);
            DikdortgenCevre = (2 * (dikdortgenKisa + dikdortgenUzun));


            /*alan işlem bölgesi */
            kareAlan = (karekenar * karekenar);
            DikdortgenAlan = (dikdortgenKisa * dikdortgenUzun);

            Console.WriteLine("********************** Sonuc Ekranı **********************");
            /*print alanı*/
            Console.WriteLine("Karenin Alani: " + kareAlan);
            Console.WriteLine("Karenin Çevresi: " + kareCevre);
            Console.WriteLine("");
            Console.WriteLine("Dikdörtgenin Alani: " + DikdortgenAlan);
            Console.WriteLine("Dikdörtgenin Çevresi: " + DikdortgenCevre);
            Console.WriteLine("********************** Program Bitis **********************");

            Console.ReadLine();
        }
    }
}
