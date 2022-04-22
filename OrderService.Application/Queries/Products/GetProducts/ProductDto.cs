using AutoMapper;
using OrderService.Application.Common.Mappings;
using OrderService.Domain.Entities;

namespace OrderService.Application.Queries.Products.GetProducts
{
    public class ProductDto : IMapFrom<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public decimal? UnitPrice { get; set; }
        public byte[] Image { get; set; }
        public bool Active { get; set; }

        public string CategoryName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, ProductDto>()
                .ForMember(d => d.CategoryName, opt => opt.MapFrom(s => s.Category != null ? s.Category.Name : string.Empty));
        }
    }
}
