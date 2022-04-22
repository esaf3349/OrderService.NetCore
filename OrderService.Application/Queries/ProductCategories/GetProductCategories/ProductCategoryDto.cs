using AutoMapper;
using OrderService.Application.Common.Mappings;
using OrderService.Domain.Entities;

namespace OrderService.Application.Queries.ProductCategories.GetProductCategories
{
    public class ProductCategoryDto : IMapFrom<ProductCategory>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ProductCategory, ProductCategoryDto>();
        }
    }
}