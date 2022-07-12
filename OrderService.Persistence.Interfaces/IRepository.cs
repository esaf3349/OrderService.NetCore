using OrderService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderService.Persistence.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        public TEntity Get(int id);
        public IEnumerable<TEntity> GetAll();
        public IEnumerable<TEntity> GetAll(ISpecification<TEntity> spec);
        public void Add(TEntity obj);
        public void Update(TEntity obj);
        public void Delete(int id);
    }
}
