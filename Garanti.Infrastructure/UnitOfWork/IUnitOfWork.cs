using Garanti.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        IOrderRepository OrderRepository { get; }
        IProductRepository ProductRepository { get; }
        IOrderDetailRepository OrderDetailRepository { get; }
        IAdminUserRepository AdminUserRepository { get; }
        void Commit();

        Task CommitAsync();
    }
}
