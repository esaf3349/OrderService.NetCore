using MediatR;

namespace OrderService.Application.Queries.ProductCategories.GetProductCategories
{
    public class GetProductCategories : IRequest<GetProductCategoriesVm>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
