using MediatR;
using OrderService.Application.Common.Exceptions;
using OrderService.Domain.Entities;
using OrderService.Persistence.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Application.Commands.ProductCategories
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCategory>
    {
        private readonly IUnitOfWork _uow;

        public UpdateProductHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Unit> Handle(UpdateProductCategory request, CancellationToken cancellationToken)
        {
            var entity = await _uow.ProductCategories.Get(request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFound(nameof(ProductCategory), request.Id);
            }

            entity.Id = request.Id;
            entity.Name = request.Name;
            entity.Description = request.Description;
            entity.Image = request.Image;

            _uow.ProductCategories.Update(entity);

            await _uow.Save(cancellationToken);

            return Unit.Value;
        }
    }
}
