using OrderService.Domain.Entities;
using OrderService.Persistence.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderService.Persistence.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IOrderRepository<Order> Orders { get; set; }
        public IOrderDetailRepository<OrderDetail> OrderDetails { get; set; }
        public IProductCategoryRepository<ProductCategory> ProductCategories { get; set; }
        public IProductRepository<Product> Products { get; set; }

        public void Save();
    }
}