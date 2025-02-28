using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    class PraticVehicle : IScooter, IBicycle
    {
        public void bicycleRide()
        {
            throw new NotImplementedException();
        }

        public void Ride()
        {

        }

        public void scooterRide()
        {
            throw new NotImplementedException();
        }
    }
    
}
