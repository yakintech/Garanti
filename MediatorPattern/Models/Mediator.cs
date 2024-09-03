using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Models
{
    //Abstract classlardan instance alınamaz.
    public abstract class Mediator
    {

        //Abstarct methodlar miras alan sınıflar tarafından implemente edilmek ZORUNDADIR.

        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
    }
}
