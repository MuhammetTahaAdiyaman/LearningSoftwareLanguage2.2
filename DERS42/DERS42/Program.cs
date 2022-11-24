using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS42
{
    /* Public
    class Insan
    {
        public string isim;
        public int yas;
        public void Yurumek()
        {
            Console.WriteLine("Yuruyor.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            i1.isim = "Taha";
            i1.yas = 21;

            Console.WriteLine(i1.isim + " " + i1.yas);

            i1.Yurumek();

            Console.ReadLine();
        }
    }
    */

    //private
    class Insan
    {
         string isim;
         int yas;
        public void Yurumek()
        {
            Console.WriteLine("Yuruyor.");
        }
        public void isimVeYasDuzenle(string isim, int yas)
        {
            this.isim = isim;
            this.yas = yas;
        }
        public string isimVeYasSoyle()
        {
            return isim + " " + yas;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            i1.isimVeYasDuzenle("Muhammet Taha", 24);
            Console.WriteLine(i1.isimVeYasSoyle());

            i1.Yurumek();

            Console.ReadLine();
        }
    }
}
