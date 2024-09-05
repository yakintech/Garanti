using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern.Models
{
    public class CreditKKBScore : CreditAnswerBase
    {
        public override void CreditRequest(Customer customer)
        {
            if (customer.KKBScore > 500)
            {
                Console.WriteLine("KKBScore is approved");
                base.IsApproved = true;
            }
            else
            {
                Console.WriteLine("KKBScore is not approved");
                base.IsApproved = false;
            }
        }
    }
}
