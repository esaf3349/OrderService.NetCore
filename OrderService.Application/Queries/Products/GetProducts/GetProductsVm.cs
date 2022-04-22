using System.Collections.Generic;

namespace OrderService.Application.Queries.Products.GetProducts
{
    public class GetProductsVm
    {
        public IList<ProductDto> Products { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
