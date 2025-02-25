using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public static class inputExample
    {
        public static void Run()
        {
            // İnput Alma Kullanıcıdan 
            Console.WriteLine("Enter Username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Lütfen Yaşınızı Giriniz: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kullanıcı Yaşı: " + userAge);


        }
    }
}
