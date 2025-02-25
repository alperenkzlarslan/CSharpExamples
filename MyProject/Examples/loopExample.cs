using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public static class loopExample
    {
        public static void Run()
        { 

            //While loop - koşul doğru ise çalışır 
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //Do while loop - Döngü 1 kere çalışır sonra kontrol sağlar 
            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 1);


            // For Loop 
            for (int l = 0; l < 6; l++)
            {
                Console.WriteLine(l);
            }

            //Nested Loop 
            for (int s1 = 0; s1 <= 2; ++s1)
            {
                Console.WriteLine("Dış Blok: " + s1);

                for (int s2 = 0; s2 <= 3; s2++)
                {
                    Console.WriteLine("İç Blok: " + s2);
                }
            }

            //foreach loop - Listelerin her bir elemanını döngüye sokabilir 
            string[] cars = { "Volvo", "BMW", "Mercedes", "Ford", "Renault", "Fiat" };
            foreach (string a1 in cars)
            {
                Console.WriteLine(a1);
            }


        }
    }
}
