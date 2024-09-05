using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Models
{
    public class Square : Shape
    {
        public Square(IColor color) : base(color)
        {
        }

        public override string Draw()
        {
            return $"Draw Square with {color.FillColor()}";
        }
    }
}
