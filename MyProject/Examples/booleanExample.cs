using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public static class booleanExample
    {
        public static void Run()
        {
            // Bool Exmaples 
            bool winner = true;
            bool loser = false;
            Console.WriteLine(winner);
            Console.WriteLine(loser);

            
            bool evet = true;
            bool hayır = false;
            Console.WriteLine(evet);
            Console.WriteLine(hayır);

            int sayi1 = 10;
            int sayi2 = 5;
            Console.WriteLine(sayi1 > sayi2);

            Console.WriteLine(sayi1 == 10);
            Console.WriteLine(sayi2 == 15);

            int myAge = 22;
            int myVotingAge = 18;
            Console.WriteLine(myAge >= myVotingAge);

            if (myAge >= myVotingAge)
            {
                Console.WriteLine("Yaşı yeterli oy kullanabilir.");
            }
            else
            {
                Console.WriteLine("Yaşı 18'den küçük oy kullanamaz.");
            }


        }
    }
}
