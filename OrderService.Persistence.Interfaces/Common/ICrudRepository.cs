using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Persistence.Interfaces.Common
{
    public interface ICrudRepository<T> where T : class
    {
        public Task<T> Get(int id, CancellationToken cancellationToken);

        public Task<IEnumerable<T>> GetRange(int pageNumber, int pageSize, CancellationToken cancellationToken);

        public int Add(T model);

        public void Update(T model);

        public void Delete(int id);
    }
}