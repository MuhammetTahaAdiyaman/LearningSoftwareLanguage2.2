using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS44
{
    class Program
    {
        class Futbolcu
        {
            private int bonservisBedeli;

            public void setBonservisBedeli(int fiyat)
            {
                this.bonservisBedeli = fiyat;
            }

            public int getBonservisBedeli()
            {
                return bonservisBedeli;

            }
        }
        static void Main(string[] args)
        {
            Futbolcu f1 = new Futbolcu();

            f1.setBonservisBedeli(1500000);

            Console.WriteLine("Futbolcunun Bonservis Bedeli: " + f1.getBonservisBedeli());

            Console.ReadLine();
        }
    }
}
