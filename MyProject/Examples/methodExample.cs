using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    class Program
    {

    }
    public static class methodExample
    {
        public static void Run()
        { 
            //Methodşar önceden oluşturulur ve çağırıldığı zaman içerisindeki kodları çalıştırır
           
            myMethod();


            //Method Paramaters 
            
            anyMethod("Alperen");
            anyMethod("Bilal");
            anyMethod("Fatih");

            
            myNewMethod("Alperen", "Kızılarslan", 23);
            myNewMethod("Merve", "Aktaş", 23);


            //Default parametre verme - Diğer adı optional parameter 
           
            myCountry("ABD");
            myCountry("Finlandiya");
            myCountry();


            // Return - Geriye değer döndüren Method Tanımlama
          
            Console.WriteLine(myXMethod(5));

           
            Console.WriteLine(myYMethod(5, 17));


            //Named Method 
           
            namedMethod(child1: "alperen", child2: "hilal", child3: "yağmur");


           
            int intsum = toplamaMethod(7, 4);
            double doublesum = toplamaMethod(2.2, 17.9);
            Console.WriteLine("Int: " + intsum);
            Console.WriteLine("Double: " + doublesum);

        }
        // 1. Method 
        static int toplamaMethod(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        // 2. Method 
        static double toplamaMethod(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
        static void namedMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("En genç çocuk: " + child3);
        }
        static int myYMethod(int z, int c)
        {
            return z + c;
        }
        static void myMethod()
        {
            Console.WriteLine("Method Çağırıldı");
        }
        static void anyMethod(string isim)
        {
            Console.WriteLine(isim + " Bey");
        }
        static void myNewMethod(string isim, string soyisim, int yas)
        {
            Console.WriteLine("Ad:" + isim + " Soyad:" + soyisim + " Yaşı:" + yas);
        }
        static void myCountry(string country = "Türkiye")
        {
            Console.WriteLine("Ülke:" + country);
        }
        static int myXMethod(int s)
        {
            return 10 * s;
        }
    }
}
