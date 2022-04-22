using MediatR;

namespace OrderService.Application.Queries.Products.GetProduct
{
    public class GetProduct : IRequest<GetProductVm>
    {
        public int Id { get; set; }
    }
}
