﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMix.AbstractSample
{
    public class Square : Shape
    {
        public double SideLength { get; set; }
        public override double CalcArea()
        {
            return SideLength * SideLength;
        }
    }
}
