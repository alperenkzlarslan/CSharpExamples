using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public class ThrowExample
    {
        public static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Erişim engellendi - yaş en az 18 olmalı");
            }
            else
            {
                Console.WriteLine("Erişim sağlandı - yaşınız yeterli");
            } 
        }   
            
    }
}
