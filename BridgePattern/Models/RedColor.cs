using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Models
{
    public class RedColor : IColor
    {
        public string FillColor()
        {
            return "Red Color";
        }
    }
}
