using MediatR;

namespace OrderService.Application.Commands.Products
{
    public class DeleteProduct : IRequest
    {
        public int Id { get; set; }
    }
}
