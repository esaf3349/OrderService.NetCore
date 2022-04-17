using System;
using System.Collections.Generic;
using System.Text;

namespace OrderService.Persistence.Interfaces.Common
{
    public interface ICrudRepository<T> where T : class
    {
        public IEnumerable<T> Get(int id);

        public IEnumerable<T> GetRange(int pageNumber, int pageSize);

        public int Add(T model);

        public void Update(T model);

        public void Delete(int id);
    }
}