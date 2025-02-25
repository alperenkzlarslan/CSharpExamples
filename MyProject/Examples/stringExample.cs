using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public static class stringExample
    {
        public static void Run()
        {
            //Char Examples 
            char singleLetter = 'a'; //char veri tipi tek tırnak içine yazılır tek bir harf tutabilir 
            Console.WriteLine(singleLetter);

            //String Examples 
            string nickname = "hyperbird";
            Console.WriteLine(nickname);

             
            string ornek1 = "Hello";
            string ornek2 = "Merhabalar! Adınız Nedir ?";

            Console.WriteLine("ornek2 stringinin uzunluğu: " + ornek2.Length);
            Console.WriteLine(ornek1.ToUpper());
            Console.WriteLine(ornek1.ToLower());

            string firstName = "Alperen";
            string lastName = " Kızılarslan";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            string name = "Merve ";
            string lastname = "Aktaş";
            string allName = string.Concat(name, lastname);
            Console.WriteLine(allName);

            int x = 10; //İnt ler birbirlerine eklenir 
            int y = 20;
            int z = x + y;
            Console.WriteLine(z);

            string x1 = "10"; //stringler birbirleri ile birleştirilir 
            string y1 = "20";
            string z1 = x1 + y1;
            Console.WriteLine(z1);

            string myString = "Merhaba";
            Console.WriteLine("Kelimenin ilk harfi: " + myString[0]);
            Console.WriteLine("a harfinin indeksi: " + myString.IndexOf("a"));
            string ad = "Alperen Kızılarslan";
            int charPos = ad.IndexOf("K");
            string soyad = ad.Substring(charPos);
            Console.WriteLine(soyad);

            //Escape Character - Backslash \
            string txt = "Alperen 'in \"maviş\" adında bir kedisi vardı.";
            Console.WriteLine(txt);

            string parca = "Bu parçanın 1. satırı \nBu parçanın 2. satırı"; // \n yeni satıra geçer 
            Console.WriteLine(parca);
            string paragraf = "Paragrafın 1. satırı \n\tParagrafın 2. satırı"; // \t bir tab boşluk bırakır 
            Console.WriteLine(paragraf);
            string myNewString = "Merhaba C\b#"; // \b backspace yapar 
            Console.WriteLine(myNewString);
            
        }
    }
}
