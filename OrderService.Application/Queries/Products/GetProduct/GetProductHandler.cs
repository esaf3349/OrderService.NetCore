using AutoMapper;
using MediatR;
using OrderService.Application.Common.Exceptions;
using OrderService.Domain.Entities;
using OrderService.Persistence.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Application.Queries.Products.GetProduct
{
    public class GetProductHandler : IRequestHandler<GetProduct, GetProductVm>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GetProductHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<GetProductVm> Handle(GetProduct request, CancellationToken cancellationToken)
        {
            var model = await _uow.Products.Get(request.Id, cancellationToken);
            var vm = _mapper.Map<GetProductVm>(model);

            if (vm == null)
            {
                throw new NotFoundException(nameof(Product), request.Id);
            }

            return vm;
        }
    }
}
