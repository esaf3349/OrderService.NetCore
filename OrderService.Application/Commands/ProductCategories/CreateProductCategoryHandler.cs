using MediatR;
using OrderService.Domain.Entities;
using OrderService.Persistence.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Application.Commands.ProductCategories
{
    public class CreateProductCategoryHandler : IRequestHandler<CreateProductCategory, int>
    {
        private readonly IUnitOfWork _uow;

        public CreateProductCategoryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<int> Handle(CreateProductCategory request, CancellationToken cancellationToken)
        {
            var entity = new ProductCategory
            {
                Name = request.Name,
                Description = request.Description,
                Image = request.Image
            };

            _uow.ProductCategories.Add(entity);

            await _uow.Save(cancellationToken);

            return entity.Id;
        }
    }
}
