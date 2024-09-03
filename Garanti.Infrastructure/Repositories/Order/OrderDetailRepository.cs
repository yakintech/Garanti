using Garanti.Domain.Models;
using Garanti.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Infrastructure.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetails>, IOrderDetailRepository
    {
        public OrderDetailRepository(GarantiContext context) : base(context)
        {
        }
    }
}
