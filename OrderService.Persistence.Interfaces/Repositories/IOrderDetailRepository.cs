using OrderService.Domain.Entities;
using OrderService.Persistence.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderService.Persistence.Interfaces.Repositories
{
    public interface IOrderDetailRepository<T> : ICrudRepository<T> where T : OrderDetail
    {

    }
}