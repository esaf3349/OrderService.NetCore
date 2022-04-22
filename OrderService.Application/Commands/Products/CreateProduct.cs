using MediatR;

namespace OrderService.Application.Commands.Products
{
    public class CreateProduct : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public decimal? UnitPrice { get; set; }
        public byte[] Image { get; set; }
        public bool Active { get; set; }
    }
}
