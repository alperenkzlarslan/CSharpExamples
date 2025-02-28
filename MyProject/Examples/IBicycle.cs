using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    interface IBicycle
    {
        void bicycleRide(); 
    }

    class RaceBicycle : IBicycle
    {
        public void bicycleRide()
        {
            Console.WriteLine("Yarış bisikleti sürülmeye hazır");
        }
    }
}
