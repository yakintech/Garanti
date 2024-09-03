using Garanti.Domain.Models;
using Garanti.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Infrastructure.Repositories
{
    public interface IOrderDetailRepository : IBaseRepository<OrderDetails>
    {
    }
}
