using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Models
{
    public class DVDPlayer
    {
        public void Play()
        {
            Console.WriteLine("DVD Player is playing");
        }

        public void Stop()
        {
            Console.WriteLine("DVD Player is stopped");
        }
    }
}
