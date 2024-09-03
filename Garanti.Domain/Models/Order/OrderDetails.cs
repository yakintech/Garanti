using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Domain.Models
{
    public class OrderDetails : BaseEntity
    {
        public Guid OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }


        public Guid ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }


        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
