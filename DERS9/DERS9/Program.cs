using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*matematiksel denklem çözme programı*/
            //f(x) = ax^2 + bx + c
            //delta = b^2 - 4ac

            double a, b, c, x;
            double sonuc, delta;
            Console.WriteLine("Lutfen değerleri giriniz: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());

            //işlemlerin yapıldığı bölge
            sonuc = a * x * x + b * x + c;
            delta = b * b - 4 * a * c;

            //sonuç bölge
            Console.WriteLine("f({0}): " + sonuc,x);
            Console.WriteLine("delta: " + delta);

            Console.ReadLine();

        }
    }
}
