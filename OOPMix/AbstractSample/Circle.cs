using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMix.AbstractSample
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalcArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
