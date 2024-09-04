using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMix.VirtualSample
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

        public override void Move()
        {
            Console.WriteLine("Dog is moving");
        }
    }
}
