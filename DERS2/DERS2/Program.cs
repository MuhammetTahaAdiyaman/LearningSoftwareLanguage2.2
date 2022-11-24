using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DERS2
{
    class Program
    {
        static void Main(string[] args)
        {
            char karakter = 'K'; //2byte
            string isim = "Kaan Academy"; //8byte
            int tamSayi = 15; //4byte
            float kesirliSayi = 3.5f; //4 byte
            double buyukKesirliSayi = 4.5; // 8byte
            bool anahtar = true; //1byte

            /*
            Console.Write(karakter + " " + isim + tamSayi + kesirliSayi + buyukKesirliSayi + " " + anahtar); //+ ile boşluksuz yan yana ekrana basma
            Console.Write(karakter + " " + isim + (tamSayi + kesirliSayi) + buyukKesirliSayi + " " + anahtar); //+ ile parantez kullanımı: aynı değişken ifadeleri toplama olarak kullanma
            Console.Write(karakter + " " + isim + " " + tamSayi + " " + kesirliSayi + " " + buyukKesirliSayi + " " + anahtar); //
            */

            /*
            Console.Write("Degiskenlerin Degerleri: \n" 
                + karakter + " " + isim + tamSayi + kesirliSayi + buyukKesirliSayi + " " + anahtar); // /n kullanımı alt satıra geçmek için.
            Console.Write("\n");
            Console.WriteLine("Degiskenlerin Degerleri: "); //Console.WriteLine() kullanımı. Bu fonksiyon kullanımından sonra Otomatik olarak alt satırdan başlar. <<endl mantığı
            Console.WriteLine(karakter + " " + isim + tamSayi + kesirliSayi + buyukKesirliSayi + " " + anahtar);
            */

            /*
            Console.WriteLine("sayi = {0}, isim = {1}", kesirliSayi, isim); //kullanım şekli 1
            Console.WriteLine("sayi = " + kesirliSayi + " isim = " + isim); //kullanım şekli 2
            */

            /*
            Değişkenlerin RAM'de olan boyutlarını ölçmek için uzun yol

            int buyukKesirliSayiBoyutu = Marshal.SizeOf(buyukKesirliSayi);
            int kesirliSayiBotutu = Marshal.SizeOf(kesirliSayi);
            int tamSayiBoyutu = Marshal.SizeOf(tamSayi);
            int isimBoyutu = System.Text.ASCIIEncoding.Unicode.GetByteCount(isim)

            Console.WriteLine("boyut: " + buyukKesirliSayiBoyutu);
            Console.WriteLine("boyut: " + kesirliSayiBotutu);
            Console.WriteLine("boyut: " + tamSayiBoyutu);
            Console.WriteLine("boyut: " + isimBoyutu);

            */


            /*Değişkenlerin RAM'de olan boyutlarını ölçmek için daha kısa yol 
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(char));
            Console.WriteLine(sizeof(float));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(isim.Length*sizeof(char));
            */



            Console.ReadLine();

}
}
}
