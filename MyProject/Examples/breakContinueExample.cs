using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public static class breakContinueExample
    {
        public static void Run()
        {
            // Break and Contiune anahtar kelimelerini while loop için de kullanabiliriz 
            for (int i1 = 0; i1 < 5; i1++)
            {
                if (i1 == 4)
                {
                    break;
                }
                Console.WriteLine(i1);
            }

            for (int i2 = 0; i2 < 7; i2++)
            {
                if (i2 == 5)
                {
                    continue;
                }
                Console.WriteLine(i2);
            }
        }
    }
}
