using AutoMapper;
using MediatR;
using OrderService.Persistence.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Application.Queries.ProductCategories.GetProductCategories
{
    public class GetProductCategoriesHandler : IRequestHandler<GetProductCategories, GetProductCategoriesVm>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GetProductCategoriesHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<GetProductCategoriesVm> Handle(GetProductCategories request, CancellationToken cancellationToken)
        {
            var model = await _uow.ProductCategories.GetRange(request.PageNumber, request.PageSize, cancellationToken);
            var dto = _mapper.Map<List<ProductCategoryDto>>(model);

            var vm = new GetProductCategoriesVm
            {
                Categories = dto,
                Count = dto.Count
            };

            return vm;
        }
    }
}
