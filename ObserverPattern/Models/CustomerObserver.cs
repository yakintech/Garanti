using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Models
{
    public class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Customers stock has been updated.");
        }
    }
}
