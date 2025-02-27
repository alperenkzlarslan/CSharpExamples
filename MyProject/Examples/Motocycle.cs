using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public class Motocycle //sealed class Car - şeklinde yazılsaydı bu sınıf kalıtım olarak alınamazdı 
    {
        
        public string color;
        public string model;
        public string brand;
        public string gearType;
        public int topSpeed;
        public int horsePower;
        public int year;

        private string headLight = "Led";

        public void horn()
        {
            Console.WriteLine("bippp biiiiiiiiipp !!!");
        }
        public static void runEngine()
        {
            Console.WriteLine("Motor çalıştırıldı");
        }
    }
}



