using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public static class numberExample
    {
        public static void Run()
        {
            //Number examples 
            Console.WriteLine(5 + 5);
            Console.WriteLine(10 / 2);

            int myNum = 23;
            Console.WriteLine(myNum);

            int myNewNum;
            myNewNum = 44;
            Console.WriteLine(myNewNum);

            int myNumber = 2344;
            myNumber = 4423;
            Console.WriteLine(myNumber);

            int x = 10;
            int y = 12;
            Console.WriteLine(x + y);

            //Bilimsel Sayılar / e den sonraki sayı 10 üzeri demek 
            float f1 = 35e3F; // 35 x 10 üzeri 3 
            double d1 = 12E4D; // 12 x 10 üzeri 4 
            Console.WriteLine(f1);
            Console.WriteLine(d1);
        }
    }
}
