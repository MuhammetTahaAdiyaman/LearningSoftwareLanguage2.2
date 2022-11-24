using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input/Output Operations (I/O islemler)
            //User Input --> kullanıcı girisi ya da kullanıcı girdisi


            /* String Değişkeni için I/O işlemler ve kullanılan methodlar
            string isim;
            Console.WriteLine("Lutfen bir isim giriniz: ");
            isim = Console.ReadLine(); //burada girdi almak istediğimiz değişkeni readline fonk. eşitliyoruz bunu şu şekilde düşünebiliriz cin >> isim; şeklinde
            Console.WriteLine("Girdiğiniz isim: " + isim);
            Console.ReadLine(); //açılan pencereyi ekranda tutmak amacıyla yazdık.
            */

            //-----------------------------------------------------------------------------------------------------------------------------------

            /* int Değişkeni için I/O işlemler ve kullanılan methodlar
             1-Convert.ToInt32()
             2-Int.Parse() --> genellikle kullandığımız method.
             3-Int.TryParse()
            */
            /*
            int yas;
            Console.WriteLine("Lutfen yasinizi giriniz: ");
            yas = Convert.ToInt32(Console.ReadLine()); //c++ da olduğu gibi cin tüm değişkenlerde yok bunun yerine bu şekilde bir dönüşüm yapmamız gerek evrensel bir dil olduğundan dolayı.
            yas = int.Parse(Console.ReadLine()); //bu method  kullanıcıdan veri almak istediğimizde int tipli değişkenlerde kullanıdığımız 2.method.
            Console.WriteLine("Yasiniz: " + yas);
            Console.ReadLine(); //açılan pencereyi ekranda tutmak amacıyla yazdık.
            */

            //-----------------------------------------------------------------------------------------------------------------------------------

            /*float Değişkeni için I / O işlemler ve kullanılan methodlar
             1 - (float)Convert.ToDouble()
             2 - Float.Parse()
            /*
            float sayi;
            Console.WriteLine("Lutfen bir sayi giriniz: ");
            sayi = (float)Convert.ToDouble(Console.ReadLine()); //c++ da olduğu gibi cin tüm değişkenlerde yok bunun yerine bu şekilde bir dönüşüm yapmamız gerek evrensel bir dil olduğundan dolayı.
            //sayi = float.Parse(Console.ReadLine()); //bu method  kullanıcıdan veri almak istediğimizde float tipli değişkenlerde kullanıdığımız 2.method.
            Console.WriteLine("Girmis oldugunuz sayinin karesi: " + sayi*sayi);
            Console.ReadLine(); //açılan pencereyi ekranda tutmak amacıyla yazdık.
            */

            //-----------------------------------------------------------------------------------------------------------------------------------


            /*double Değişkeni için I / O işlemler ve kullanılan methodlar
             1 - Convert.ToDouble()
             2 - Double.Parse()
            */
            /*
            double sayi2;
            Console.WriteLine("Lutfen bir sayi giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine()); //c++ da olduğu gibi cin tüm değişkenlerde yok bunun yerine bu şekilde bir dönüşüm yapmamız gerek evrensel bir dil olduğundan dolayı.
            //sayi2 = Double.Parse(Console.ReadLine()); //bu method  kullanıcıdan veri almak istediğimizde double tipli değişkenlerde kullanıdığımız 2.method.
            Console.WriteLine("Girmis oldugunuz sayinin karesi: " + sayi2*sayi2);
            Console.ReadLine(); //açılan pencereyi ekranda tutmak amacıyla yazdık.
            */

            //-----------------------------------------------------------------------------------------------------------------------------------

            /*char Değişkeni için I / O işlemler ve kullanılan methodlar
            1 - Console.ReadKey().KeyChar
            2 - Convert.ToChar()
            Not: kullanıcı girdi yaptıktan sonra enter basmasına gerek yok otomatik olarak ilerleyecektir.
            */
            /*
             char karakter;
             Console.WriteLine("Lutfen bir karakter giriniz: ");
             //karakter = Convert.ToChar(Console.ReadLine()); //c++ da olduğu gibi cin tüm değişkenlerde yok bunun yerine bu şekilde bir dönüşüm yapmamız gerek evrensel bir dil olduğundan dolayı.
             karakter = Console.ReadKey().KeyChar; //bu method  kullanıcıdan veri almak istediğimizde char tipli değişkenlerde kullanıdığımız 2.method.
             Console.WriteLine("\nGirmis oldugunuz karakter: " + karakter);
             Console.ReadLine(); //açılan pencereyi ekranda tutmak amacıyla yazdık.
            */
        }
    }
}
