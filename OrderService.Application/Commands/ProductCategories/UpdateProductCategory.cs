using MediatR;

namespace OrderService.Application.Commands.ProductCategories
{
    public class UpdateProductCategory : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    }
}