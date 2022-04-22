using OrderService.Domain.Entities;
using OrderService.Persistence.Interfaces.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Persistence.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IOrderRepository<Order> Orders { get; set; }
        public IOrderDetailRepository<OrderDetail> OrderDetails { get; set; }
        public IProductCategoryRepository<ProductCategory> ProductCategories { get; set; }
        public IProductRepository<Product> Products { get; set; }

        public Task<int> Save(CancellationToken cancellationToken);
    }
}