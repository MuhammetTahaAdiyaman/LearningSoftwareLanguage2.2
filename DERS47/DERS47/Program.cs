using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS47
{
    class Insan
    {
        private string isim;
        private int yas;

        /*
        //normalde biz private olan özelliğe bu class dışından erişmek için class içinde aşağıdaki gibi bir method yazmamız gerekli.
        public void setIsım(string isim)
        {
            this.isim = isim;
        }
        //değeri almak yani ekrana bastırmak için de yeni bir method yazmamız gerekmektedir.
        public string getIsım()
        {
            return isim;
        }
        //ancak bu get ve set methodları yazmak yerine c# da yeni bir kavram geliştirildi çok daha basit bir yöntem ve bu yöntem sayesinde class dışından bu özeliklere direkt olarak erişim sağlaybiliyoruz.
        */

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        //yukarıda yazdığımız getIsım() ve setIsım() methodu yerine bu şekilde property şeklinde kullanabiliyoruz ve main fonksiyonu içinde doğrudan erişim sağlayabiliyoruz.

        //tabi property içinde kullandığımız get ve set methodlarında kontrol de sağlayabiliriz yukarıda hemen bir yas field oluşturalım ve onun adına bir property yapalım.
        public int Yas
        {
            get { return yas; }
            set { if (value >= 10) yas = value; }
        }

        //biz daha önceden tanımlanmamış bir özelliği (field) ise auto implemented property sayesinde de tanımlayabiliyoruz
        public string Cinsiyet { get; }  //burada direkt olarak hem atama yapabiliriz hem de atadığımız değeri ekrana bastırabiliriz. Şimdi yalnızca get metodunu kullanalım yani ekrana bastırmada kullanılsın. 

        //objemizin set metodunu constructor metod ile başlangıçta cinsiyet atamasını tanımlayalım.
        public Insan(string cinsiyet)
        {
            this.Cinsiyet = cinsiyet;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Insan i1 = new Insan("Erkek");

            i1.Isim = "Muhamme Taha"; //set
            i1.Yas = 10;
            //i1.Cinsiyet = "Erkek";
            Console.WriteLine("İsim: " + i1.Isim + " " + "Yas: " + i1.Yas + " " + "Cinsiyet: " + i1.Cinsiyet); //get

            Console.ReadLine();
        }
    }
}
