using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS35
{
    class Program
    {/*parametreli metot kullanımı (boş döndüren)*/
        static void Main(string[] args)
        {

            isimSoyle("TAHA");
            isimSoyle("ECEM"); //Burada kullandığımız değer tipi de string olmak zorunda şu şekilde de bir kullanım sağlayabilidrdik;

            string isim = "taha ecemi çok seviyor";
            isimSoyle(isim);
            Console.ReadLine();
        }
        static void isimSoyle(string i)
        {
            Console.WriteLine(i);
        }
    }
}
