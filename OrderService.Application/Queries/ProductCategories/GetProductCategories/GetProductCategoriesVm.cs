using System.Collections.Generic;

namespace OrderService.Application.Queries.ProductCategories.GetProductCategories
{
    public class GetProductCategoriesVm
    {
        public IList<ProductCategoryDto> Categories { get; set; }

        public int Count { get; set; }
    }
}
