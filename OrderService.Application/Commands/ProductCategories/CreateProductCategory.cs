using MediatR;

namespace OrderService.Application.Commands.ProductCategories
{
    public class CreateProductCategory : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    }
}