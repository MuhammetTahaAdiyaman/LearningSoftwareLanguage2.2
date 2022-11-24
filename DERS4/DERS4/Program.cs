using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS4
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan ismini, yaşını ve boy bilgisini ekrana bastıran bir program yazalım.

            Console.WriteLine("************ Welcome To The System ************");
            string Name;
            string Surname;
            int Age;
            float Weight;

            Console.WriteLine("Please enter the name");
            Name = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Please enter the surname");
            Surname = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Please enter the age");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Please enter the weight");
            Weight = (float)Convert.ToDouble(Console.ReadLine());
            //Weihht = float.parse(Console.WriteLine());
            Console.WriteLine("\n");
            Console.WriteLine("************ Print To The System ************");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("NAME: " + Name);
            Console.WriteLine("SURNAME: " + Surname);
            Console.WriteLine("AGE: " + Age);
            Console.WriteLine("WEIGHT: " + Weight);
            Console.WriteLine("-------------------------------------------");
            Console.ReadLine(); //pencereyi ekranda tutmak için yazdığım bir kod 




        }
    }
}
