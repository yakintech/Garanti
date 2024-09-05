using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern.Models
{
    public class CreditTCControl : CreditAnswerBase
    {
        public override void CreditRequest(Customer customer)
        {
            if (customer.TCNo)
            {

                Console.WriteLine("TC kontrolü yapıldı");
                base.IsApproved = true;
            }
            else
            {
                Console.WriteLine("TC kontrolü yapılamadı");
                base.IsApproved = false;
            }
        }
    }
}
