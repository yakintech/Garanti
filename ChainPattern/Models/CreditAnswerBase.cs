using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern.Models
{
    public abstract class CreditAnswerBase
    {
        public bool IsApproved;
        protected CreditAnswerBase _nextHandler;

        public void setNextHandler(CreditAnswerBase nextHandler)
        {
            _nextHandler = nextHandler;
        }


        public void HandleRequest(Customer customer)
        {
            CreditRequest(customer);
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(customer);
            }
        }


        public abstract void CreditRequest(Customer customer);
    }
}
