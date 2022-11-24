using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS53
{
    class Program
    {
        class Isci
        {
            public const double PI = 3.14;
            readonly public double maas;
            public Isci(double maas)
            {
                this.maas = maas;
            }

            readonly double MutA = Math.Abs(-2);
        }
        //const ve readonly farkı.
        //readonly olan değeri yalnızca constructor içerisinden değiştirebilirken;
        //const olan değeri hiç bir yerden değiştiremeyiz.
        //readonly ve const ikiside sadece okunabilir bir tiptir.
        //const oluştuğunda direkt olarak değer ataması yapılması gerek.
        //readonly yalnızca class'lar içerisinde kullanılabilir.
        //biz bir mutlak değerin sonucunu readonly olan değere atayabiliriz ancak const'da bu atama asla yapılamaz.
        static void Main(string[] args)
        {
            Isci i1 = new Isci(4500);
            Isci i2 = new Isci(8899.4);

            Console.WriteLine(i1.maas + " " + i2.maas);

            Console.ReadLine();
        }
    }
}
