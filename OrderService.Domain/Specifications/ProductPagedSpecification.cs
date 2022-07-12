using OrderService.Domain.Entities;

namespace OrderService.Domain.Specifications
{
    public class ProductPagedSpecification : BaseSpecification<Product>
    {
        public ProductPagedSpecification(int skip, int take) : base(criteria => true)
        {
            ApplyPaging(skip, take);
        }
    }
}
