using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Domain.Models
{
    public class Invoice : BaseEntity, ICloneable
    {
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal Balance { get; set; }
        public decimal Tax { get; set; }

        public string Country { get; set; } = "";


        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
   
}
