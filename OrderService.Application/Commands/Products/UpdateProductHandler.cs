using MediatR;
using OrderService.Application.Common.Exceptions;
using OrderService.Domain.Entities;
using OrderService.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Application.Commands.Products
{
    public class UpdateProductHandler : IRequestHandler<UpdateProduct>
    {
        private readonly IUnitOfWork _uow;

        public UpdateProductHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Unit> Handle(UpdateProduct request, CancellationToken cancellationToken)
        {
            var entity = await _uow.Products.Get(request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Product), request.Id);
            }

            entity.Name = request.Name;
            entity.Description = request.Description;
            entity.CategoryId = request.CategoryId;
            entity.SupplierId = request.SupplierId;
            entity.UnitPrice = request.UnitPrice;
            entity.Image = request.Image;
            entity.Active = request.Active;

            _uow.Products.Update(entity);

            await _uow.Save(cancellationToken);

            return Unit.Value;
        }
    }
}
