using Garanti.Infrastructure.EF;
using Garanti.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GarantiContext _context;

        private ICategoryRepository _categoryRepository;
        private IOrderRepository _orderRepository;
        private IProductRepository _productRepository;
        private IOrderDetailRepository _orderDetailRepository;
        private IAdminUserRepository _adminUserRepository;
        private IInvoiceRepository _invoiceRepository;

        public UnitOfWork(GarantiContext context
             , ICategoryRepository categoryRepository
            , IOrderRepository orderRepository
            , IProductRepository productRepository
            , IOrderDetailRepository orderDetailRepository
            , IAdminUserRepository adminUserRepository
,
IInvoiceRepository invoiceRepository

            )
        {
            _context = context;
            _categoryRepository = categoryRepository;
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _orderDetailRepository = orderDetailRepository;
            _adminUserRepository = adminUserRepository;
            _invoiceRepository = invoiceRepository;

        }

        public ICategoryRepository CategoryRepository => _categoryRepository;
        public IOrderRepository OrderRepository => _orderRepository;
        public IProductRepository ProductRepository => _productRepository;
        public IOrderDetailRepository OrderDetailRepository => _orderDetailRepository;
        public IAdminUserRepository AdminUserRepository => _adminUserRepository;
        public IInvoiceRepository InvoiceRepository => _invoiceRepository;


        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
