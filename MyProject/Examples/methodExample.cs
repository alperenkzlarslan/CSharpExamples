using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public static class methodExample
    {
        public static void Run()
        { 
            //Methodşar önceden oluşturulur ve çağırıldığı zaman içerisindeki kodları çalıştırır
            static void myMethod()
            {
                Console.WriteLine("Method Çağırıldı");
            }
            myMethod();

            //Method Paramaters 
            static void anyMethod(string isim)
            {
                Console.WriteLine(isim + " Bey");
            }
            anyMethod("Alperen");
            anyMethod("Bilal");
            anyMethod("Fatih");

            static void myNewMethod(string isim, string soyisim, int yas)
            {
                Console.WriteLine("Ad:" + isim + " Soyad:" + soyisim + " Yaşı:" + yas);
            }
            myNewMethod("Alperen", "Kızılarslan", 23);
            myNewMethod("Merve", "Aktaş", 23);

            //Default parametre verme - Diğer adı optional parameter 
            static void myCountry(string country = "Türkiye")
            {
                Console.WriteLine("Ülke:" + country);
            }
            myCountry("ABD");
            myCountry("Finlandiya");
            myCountry();

            // Return - Geriye değer döndüren Method Tanımlama
            static int myXMethod(int s)
            {
                return 10 * s;
            }
            Console.WriteLine(myXMethod(5));

            static int myYMethod(int z, int c)
            {
                return z + c;
            }
            Console.WriteLine(myYMethod(5, 17));

            //Named Method 
            static void namedMethod(string child1, string child2, string child3)
            {
                Console.WriteLine("En genç çocuk: " + child3);
            }
            namedMethod(child1: "alperen", child2: "hilal", child3: "yağmur");
        }
    }
}
