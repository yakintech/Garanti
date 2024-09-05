using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Models
{
    public class TurnOnCommand : ICommand
    {
        private Light Light;

        public TurnOnCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.TurnOn();
        }

        public void Undo()
        {
            Light.TurnOff();
        }
    }

    public class TurnOffCommand : ICommand
    {
        private Light Light;

        public TurnOffCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.TurnOff();
        }

        public void Undo()
        {
            Light.TurnOn();
        }
    }
}
