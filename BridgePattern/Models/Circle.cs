using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Models
{
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color)
        {
        }

        public override string Draw()
        {
            return $"Draw Circle with {color.FillColor()}";
        }
    }
}
