using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public static class condinationExample
    {
        public static void Run()
        {
            if (44 > 23)
            {
                Console.WriteLine("44 sayısı 23 sayısından büyüktür");
            }

            int a = 15;
            int b = 20;
            if (b > a)
            {
                Console.WriteLine("B sayısı A dan daha büyüktür");
            }

            int saat = 16;
            if (saat <= 12)
            {
                Console.WriteLine("Günaydın");
            }
            else
            {
                Console.WriteLine("Tünaydın");
            }

            int puan = 65;
            if (puan > 70)
            {
                Console.WriteLine("Dersten başarıyla geçtiniz");
            }
            else if (puan >= 50)
            {
                Console.WriteLine("Dersten sorumlu geçtiniz");
            }
            else
            {
                Console.WriteLine("Dersten kaldınız");
            }

            int zaman = 20;
            string result = (zaman < 18) ? "İyi Günler" : "İyi Akşamlar";
            Console.WriteLine(result);
            
        }
    }
}
