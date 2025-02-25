using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public static class textExample
    {
        public static void Run()
        {
            //Text examples 
            Console.WriteLine("Hello, World!"); //string 
            Console.Write("Alperen Kızılarslan");
            Console.WriteLine(" Hoş Geldin");

            string name = "Merve";
            Console.WriteLine(name);

            string firstName = "Süslü";
            string lastNeme = " Kızılarslan";
            string fullName = firstName + lastNeme;
            Console.WriteLine(fullName);
        }
    }
}
