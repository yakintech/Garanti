using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMix.VirtualSample
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal is moving");
        }
    }
}
