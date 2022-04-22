using MediatR;
using OrderService.Application.Common.Exceptions;
using OrderService.Domain.Entities;
using OrderService.Persistence.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Application.Commands.Products
{
    public class DeleteProductHandler : IRequestHandler<DeleteProduct>
    {
        private readonly IUnitOfWork _uow;

        public DeleteProductHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Unit> Handle(DeleteProduct request, CancellationToken cancellationToken)
        {
            var entity = await _uow.Products.Get(request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFound(nameof(Product), request.Id);
            }

            _uow.Products.Delete(entity.Id);

            await _uow.Save(cancellationToken);

            return Unit.Value;
        }
    }
}
