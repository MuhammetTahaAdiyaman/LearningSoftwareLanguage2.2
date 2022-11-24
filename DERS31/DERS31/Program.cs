using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS31
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ekrana yıldızlardan kare yazdıralım
            int satir= 5;
            
            for(int i=0; i < satir; i++)
            {
                for(int j=0; j<5; j++) //kare yapacağımızdan dolayı satır 5 ise burada yani yıldız sayımızda 5 tane yazması lazım ki kare görünümünü elde edelim.
                {
                    Console.Write("*"); /*şimdi bunun mantığı şu şekilde 0<5 evet o zaman * yazdık 
                                          sonra j yi bir arttık 1<5 evet o zaman bir yıldız daha ekledik sonuc ** oldu 
                                          bu şekilde 5 yıldıza kadar devam ediyor. yani sonuc = *****
                                          j li olan for döngüsü tamamlandı bir alt satıra yani 2.satıra geçti şimdi aynı işlemleri bu satır adına da yapacak
                                          2.satırda olan görünüm şu şekilde : *****
                                                                              *****
                                          bu işlem 5.satıra kadar devam ededcek ve döngümüz bitecek.
                                         
                }

                Console.WriteLine();
            }
            */

            /*şimdi şu şekilde bir ekrana çıktı yazdıralım
                
            *****
            ****
            ***
            **
            *
             
            bunu yazdırmak içinde birinci satır tamamlandıktan sonra 2.satır için bir azaltılmış şekilde olması lazım
             
             

            int satir = 5;
            int sutun = 5;
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++) 
                {
                    Console.Write("*"); 
                                         
                }

                Console.WriteLine();
                sutun--;
            }
            */

            /*yukarıdaki simgenin tam tersini yapmak istersek sutunu 0 yapıp 1 er 1 er artmasını sağlayacağız.
            int satir = 5;
            int sutun = 1;
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("*");

                }

                Console.WriteLine();
                sutun++;
            }
            */

            /*şimdi sıra gelsin baklava dilimi şeklinde yıldız yazdırmaya 
                  *
                 ***
                *****
                 ***
                  *
            bu şekilde yapabilmemiz için 1.satırda 2 boşluk bırakıp 1 yıldız bırakması 2.satıra ge.tiğinde 1 boşluk verip 3 yıldız yazması lazım 
            3.satırda boşluk vermeden 5 yıldız yazmazı lazım. 4.satırda 1 boşluk verip 3 yıldız 5.satırda ise 2 boşluk verip 1 yıldız yazmazı lazım.
            burada farkettiysek boşluk vermemizin sebebi sola dayalı şekilde yazmasını engellemek amacıyla
             */

            int satir, bosluk, yildiz;
            Console.WriteLine("Kac satir baklaca yazdirmak istiyorsunuz.");
            satir = Convert.ToInt32(Console.ReadLine());
            bosluk = satir / 2; //bunu neden bu şekilde yazdık yukarıdaki baklava diliminde 5 satir vardı başlangıçtaki boşluk sayısı 2 peki bunu nasıl bulduk 5/2 = 2.5 ancak int olduğu için 2 şeklinde alacağız.
            yildiz = 1; //başlangıçtaki yildiz değerimiz. 1.satırda 1 yıldız var.
            
            for(int i=0; i<satir; i++)
            {
                //her satırın içinde boşluk bırakıyoruz.
                for(int j=0; j<bosluk; j++)
                {
                    Console.Write(" ");
                }
                //daha sonraki amacım boşluk bıraktıktan sonra yıldız yazdırmak.
                for(int z=0; z<yildiz; z++)
                {
                    Console.Write("*");
                }
                /*iki boşluk bırakıp bir yıldız yazdı şimdi alt satırda şu şekilde yapması gerekiyor boşluğu 1 azaltması yıldızı 2 arttırması lazım 
                ancak 3.satırdan sonra azaltma olmuyor çünkü biz boşluğa yukarıda bir kural koymuştuk bosluk = satir/2 yani boşluğu satır sayısına göre ayarlıyordu.
                biz 5 satırlık yazdığımızda boşluk etkisi 3.satıra kadar yapıyor 3.satırdan sonra boşluk bırakmıyordu bunun çözümü if yapısı ile bu şart sağlanıyorsa 
                boşluğu bir azalt yıldızı 2 arttır. eğer bu şart uygulanmıyorsa yani 3.satırdan sonrası için ise boşluğu 1 arttır yıldızı 2 azalt.*/
                if(i< satir / 2)
                {
                    bosluk--;
                    yildiz += 2;
                }
                else
                {
                    bosluk++;
                    yildiz-=2;
                }
                Console.WriteLine();
                

            }
            
            
            Console.ReadLine();
        }
        
       
    }
}
