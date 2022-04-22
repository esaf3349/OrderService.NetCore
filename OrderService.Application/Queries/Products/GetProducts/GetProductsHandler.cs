using AutoMapper;
using MediatR;
using OrderService.Persistence.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Application.Queries.Products.GetProducts
{
    public class GetProductsHandler : IRequestHandler<GetProducts, GetProductsVm>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GetProductsHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<GetProductsVm> Handle(GetProducts request, CancellationToken cancellationToken)
        {
            var model = await _uow.Products.GetRange(request.PageNumber, request.PageSize, cancellationToken);
            var dto = _mapper.Map<List<ProductDto>>(model);

            var vm = new GetProductsVm
            {
                Products = dto,
                CreateEnabled = true
            };

            return vm;
        }
    }
}
