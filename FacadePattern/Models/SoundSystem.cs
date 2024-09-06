using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Models
{
    public class SoundSystem
    {
        public void setVolume(int volume)
        {
            Console.WriteLine("Volume is set to " + volume);
        }
        public void TurnOn()
        {
            Console.WriteLine("Sound system is on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sound system is off.");
        }
    }
}
