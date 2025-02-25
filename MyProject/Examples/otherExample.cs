using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public static class otherExample
    {
        public static void Run()
        {
            // Other Types 
            int sayi1 = 10;
            double myDouble = 10.15D;
            char myChar = 'A';
            bool myBool = true;
            string myString = "Aktaş";

            //Display Variables 
            string name1 = "Alperen";
            Console.WriteLine("Hello " + name1);

            //Declare Many Variables 
            int a = 10, b = 5, c = 7;
            Console.WriteLine(a + b + c);

            // Değişkenler açıklayıcı olmalıdır 
            double piNumber = 3.14;
            Console.WriteLine(piNumber);

            // Math methods 
            Console.WriteLine(Math.Max(10, 15));
            /* Math.Max(x,y) = En büyük sayıyı alır 
            Math.Min(x,y) = En küçük sayıyı alır 
            Math.Sqrt(x) = Sayının karesini alır 
            Math.Abs(x) = Sayının Mutlak değerini alır 
            Math.Round() = Sayıyı en yakın sayıya yuvarlar */
        }

    }
}
