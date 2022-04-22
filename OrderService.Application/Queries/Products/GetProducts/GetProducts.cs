using MediatR;

namespace OrderService.Application.Queries.Products.GetProducts
{
    public class GetProducts : IRequest<GetProductsVm>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
