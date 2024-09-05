using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern.Models
{
    public class CreditSponsor : CreditAnswerBase
    {
        public override void CreditRequest(Customer customer)
        {
            if (customer.SponsorStatus)
            {
                Console.WriteLine("Sponsor approved");
                base.IsApproved = true;
            }
            else
            {
                Console.WriteLine("Sponsor not approved");
                base.IsApproved = false;
            }
        }
    }
}
