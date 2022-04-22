using AutoMapper;
using OrderService.Application.Common.Mappings;
using OrderService.Domain.Entities;

namespace OrderService.Application.Queries.Products.GetProduct
{
    public class GetProductVm : IMapFrom<Product>
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

        public bool EditEnabled { get; set; }
        public bool DeleteEnabled { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, GetProductVm>()
                .ForMember(d => d.EditEnabled, opt => opt.Ignore())
                .ForMember(d => d.DeleteEnabled, opt => opt.Ignore())
                .ForMember(d => d.CategoryName, opt => opt.MapFrom(s => s.Category != null ? s.Category.Name : string.Empty));
        }
    }
}
