using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*girilen sayinin tek mi cift mi oldugunu söyleyen program*/
            int sayi;
            Console.WriteLine("Lutfen bir sayi giriniz: ");
            sayi = int.Parse(Console.ReadLine());

            if(sayi % 2 == 0)
            {
                Console.WriteLine("Girilen Sayı Çifttir");
            }
            else
            {
                Console.WriteLine("Girilen Sayi Tektir.");
            }

            /*yukarıdaki if-else mantığını şu şekilde de yazabiliriz.
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girilen Sayı Çifttir");
            }
            if (sayi % 2 != 0)
            {
                Console.WriteLine("Girilen Sayi Tektir.")
            }
            */
            //iki if alt alta yazılırsa iki if de sorgulanır doğru veya yanlış şeklinde. 

            //Ancak bir if altına if-else yazılırsa ilki doğruysa altına yazılan if-else kontrol edilmez çünkü else if, if'in devamı niteliğindedir.

            Console.ReadLine();
        }
    }
}
