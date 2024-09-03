using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Domain.Models
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
