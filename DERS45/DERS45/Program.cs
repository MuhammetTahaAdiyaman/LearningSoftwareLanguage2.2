using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS45
{
    class Program
    {
        class BankHesap
        {
            private int bakiye;

            public void paraYatir(int miktar)
            {
                bakiye = bakiye + miktar;
            }

            public void paraCek(int miktar)
            {
                bakiye = bakiye - miktar;
            }

            public int bakiyeSorgu()
            {
                return bakiye;
            }
        }
        static void Main(string[] args)
        {
            BankHesap b1 = new BankHesap();

            Console.WriteLine("Güncel Bakiyeniz: " + b1.bakiyeSorgu());

            b1.paraYatir(17500);

            Console.WriteLine("Güncel Bakiyeniz: " + b1.bakiyeSorgu());

            b1.paraCek(4250);

            Console.WriteLine("Güncel Bakiyeniz: " + b1.bakiyeSorgu());

            Console.ReadLine();
        }
    }
}
