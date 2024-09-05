using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Dto
{
    public class CreateOrderRequestDto
    {
        public Guid CustomerId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
        public string PaymentMethod { get; set; }
        public string Platform { get; set; }



    }

    public class OrderItemDto
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }

}

