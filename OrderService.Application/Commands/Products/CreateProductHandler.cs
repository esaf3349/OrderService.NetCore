using MediatR;
using OrderService.Domain.Entities;
using OrderService.Persistence.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Application.Commands.Products
{
    public class CreateProductHandler : IRequestHandler<CreateProduct, int>
    {
        private readonly IUnitOfWork _uow;

        public CreateProductHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<int> Handle(CreateProduct request, CancellationToken cancellationToken)
        {
            var entity = new Product
            {
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                SupplierId = request.SupplierId,
                UnitPrice = request.UnitPrice,
                Image = request.Image,
                Active = request.Active
            };

            _uow.Products.Add(entity);

            await _uow.Save(cancellationToken);

            return entity.Id;
        }
    }
}
