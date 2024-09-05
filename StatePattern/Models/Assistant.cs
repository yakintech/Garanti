using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Models
{
    public class Assistant
    {
        IMode _mode;

        public Assistant()
        {
            _mode = new OnlineMode();
        }

        public void Answer()
        {
            _mode.Answer();
        }

        public void Change(IMode mode)
        {
            _mode = mode;
        }
    }
}
