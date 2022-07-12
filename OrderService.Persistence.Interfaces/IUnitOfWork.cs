using System;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Persistence.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public Task<int> Commit(CancellationToken cancellationToken);
    }
}