using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Examples.Examples;

namespace C_Examples.Examples
{
    public class Car
    {
        public string color;
        public string model;
        public string brand;
        public string gearType;
        public int topSpeed;
        public int horsePower;
        public int year;

        public Car(string carColor, string carGearType, int carHorsePower, int carYear, int carTopSpeed, string carModel, string carBrand) 
        {
            color = carColor;
            model = carModel;
            brand = carBrand;
            gearType = carGearType;
            topSpeed = carTopSpeed;
            horsePower = carHorsePower;
            year = carYear;

        }

    } 

}





