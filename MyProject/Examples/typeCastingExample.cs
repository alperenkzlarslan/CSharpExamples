using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public static class typeCastingExample
    {
        public static void Run()
        {
            //Type Casting - veri tipi dönüşümü 
            //Implicit - otomatik dönüşüm - küçük sayıdan büyük sayıya 
            int number2 = 9;
            double number3 = number2;
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            //exclipt - manuel dönüşüm - büyük tipten küçük tipe 
            double number4 = 15.65;
            int number5 = (int)number4;
            Console.WriteLine(number4);
            Console.WriteLine(number5);

            // Açık veri tipi dönüşümü 
            Console.WriteLine(Convert.ToString(number2));
            Console.WriteLine(Convert.ToInt32(number4));
        }
    }
}
