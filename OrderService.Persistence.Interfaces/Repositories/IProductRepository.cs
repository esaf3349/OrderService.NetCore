using OrderService.Domain.Entities;
using OrderService.Persistence.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderService.Persistence.Interfaces.Repositories
{
    public interface IProductRepository<T> : ICrudRepository<T> where T : Product
    {
        
    }
}