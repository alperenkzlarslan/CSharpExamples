using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("Hayvanlar ses çıkarıyor");
        }
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Kedi: miyavvv miyavv");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Köpek: Onlar arkadan hav hava havaav raarrraravvv");
        }
    }
}
