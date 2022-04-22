using MediatR;
using OrderService.Application.Common.Exceptions;
using OrderService.Domain.Entities;
using OrderService.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Application.Commands.ProductCategories
{
    public class DeleteProductCategoryHandler : IRequestHandler<DeleteProductCategory>
    {
        private readonly IUnitOfWork _uow;

        public DeleteProductCategoryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Unit> Handle(DeleteProductCategory request, CancellationToken cancellationToken)
        {
            var entity = await _uow.Products.Get(request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFound(nameof(ProductCategory), request.Id);
            }

            _uow.Products.Delete(entity.Id);

            await _uow.Save(cancellationToken);

            return Unit.Value;
        }
    }
}
