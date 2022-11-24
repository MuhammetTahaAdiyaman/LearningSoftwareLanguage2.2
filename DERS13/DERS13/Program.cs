using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TOPLAMA İŞLEMİNİ ÖĞRETMEYİ AMAÇLAYAN OYUN*/
            /*Program aiming to teach addition operation*/
            /*bu programı yazarken sürekli olarak google dan yararlanacağız*/

            /*int sayi1, sayi2;
            int kullaniciCevabi;
            int toplam;
            Random rastgele = new Random(); /*Random diye bir class var. Bu bir sınıf(class) rastgele ise bu class'dan üretilmiş bir obje diyebiliriz. 
                                            Bu konu ileride olan bir konu sadece burada rastgele sayı üretmek için kullanacağız.
            sayi1 = rastgele.Next(1, 101);
            sayi2 = rastgele.Next(1, 101); //bu kod ise rastgele objemizle birlikte next adında bir fonksiyon sayesinde 1 ile 100 arasında bir sayı üretmesini sağlayacağız rastgele şekilde

            //iki sayimizin toplam doğru olan değeri
            toplam = sayi1 + sayi2;
            
            //şimdi bu rastgele sayılarımızı ekrana bastıralım.
            Console.WriteLine("birinci sayimiz: " + sayi1 + "\nikinci sayimiz: " + sayi2);

            Console.WriteLine("");

            //şimdi kullanicidan bu iki sayimizin toplamını soralım.
            Console.WriteLine("Ekranda gösterilen iki sayinin toplami nedir ? ");
            kullaniciCevabi = int.Parse(Console.ReadLine());

            //şimdi kullanicimizin girdiği cevap doğru mu değil mi buna bakalım.
            if(kullaniciCevabi == toplam)
            {
                Console.WriteLine("Tebrikler bildiniz.");
            }
            else
            {
                Console.WriteLine("Uzgunum bilemediniz.");
            }
            */
            //her döngüden sonra tekrar oynamak istiyor musunuz sorusu için do-while döngüsü kullanmak her zaman daha mantıklı çünkü döngüye bir kez giriyor daha sonra çıkması için şart koyuyoruz.
            //buraya kadar olan kısmın yorumsuz hali ve do while içine kattığımız hali ile aşağıdan devam edeceğim.
            int sayi1, sayi2;
            int kullaniciCevabi;
            int toplam;
            char devamMi;
            int dogruCevapSayisi = 0;
            int yanlisCevapSayisi = 0;
            int puan = 0;
            do
            {
                
                Random rastgele = new Random();
                
                sayi1 = rastgele.Next(1, 101);
                sayi2 = rastgele.Next(1, 101);

                toplam = sayi1 + sayi2;
                Console.WriteLine("*************************************************");
                Console.WriteLine("birinci sayimiz: " + sayi1 + "\nikinci sayimiz: " + sayi2);

                Console.WriteLine("");
                Console.WriteLine("*************************************************");
                Console.WriteLine("Ekranda gösterilen iki sayinin toplami nedir ? ");
                kullaniciCevabi = int.Parse(Console.ReadLine());

                if (kullaniciCevabi == toplam)
                {
                    Console.WriteLine("Tebrikler bildiniz.");
                    dogruCevapSayisi++; //soruyu bildiğimizde dogru cevap sayisini bir arttır
                    puan = puan + 5; //soruyu bildiğimizde puanımıza +5 ekle
                }
                else
                {
                    Console.WriteLine("Uzgunum bilemediniz.");
                    yanlisCevapSayisi++; //soruyu yanlis bildigimizde yanlis cevap sayisini 1 arttır.
                    puan -= 2; //soruyu yanlis bildiğimizde puanimizden -2 puan düşür.
                }

                //kullanıcıya soru sormamiz gerekiyordu devam mi diye şimdi burada onu sordurtalım.
                Console.WriteLine("Tekrar oynamak istiyor musunuz ? 'e/E '");
                devamMi = char.Parse(Console.ReadLine());

            } while (devamMi == 'e' || devamMi == 'E'); //burada bir sorun oluştu do içinde tanımladığımız yalnızca do içinde geçerli while dahil olmak üzere dışarıda tanımladığımız değişkenler geçerli olmuyor. bundan dolayı değişkenleri en yukarda tanımlamamız gerekiyor.
                                                        //while(devamMi == 'E') --> anlamı şu; do döngüsü e harfi yazdıkça devam etsin. devamMi == e olunca döngüye gir anlamındadır.

            //oyun bitince kullanıcının verdiği doğru cevap sayisi, yanlis cevap sayisi, puanını görüntüleyelim.
            Console.WriteLine("*************************************************");
            Console.WriteLine("Dogru Cevap Sayisi: " + dogruCevapSayisi);
            Console.WriteLine("Yanlis Cevap Sayisi: {0}", yanlisCevapSayisi);
            Console.WriteLine("Toplam Puan: " + puan);
            Console.WriteLine("*************************************************");




            Console.ReadLine();
        }
    }
}
