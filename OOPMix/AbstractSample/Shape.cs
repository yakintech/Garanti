using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMix.AbstractSample
{
    //abstract classlar instance alınamazlar.
    public abstract class Shape
    {
        //abstract metotlar sadece tanımlanır, içerikleri alt sınıflarda yazılır.( ZORUNLU )
        public abstract double CalcArea();

        public void DisplayInfo()
        {
            Console.WriteLine("Area: " + CalcArea());
        }
    }
}
