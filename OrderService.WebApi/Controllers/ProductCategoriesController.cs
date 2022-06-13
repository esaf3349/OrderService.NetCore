using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Application.Commands.ProductCategories;
using OrderService.Application.Queries.ProductCategories.GetProductCategories;
using System.Threading.Tasks;

namespace OrderService.WebApi.Controllers
{
    public class ProductCategoriesController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetProductCategoriesVm))]
        public async Task<ActionResult<GetProductCategoriesVm>> GetAll(int pageNumber = 0, int pageSize = 20)
        {
            return Ok(await Mediator.Send(new GetProductCategories { PageNumber = pageNumber, PageSize = pageSize }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> Create(CreateProductCategory command)
        {
            var id = await Mediator.Send(command);

            return Ok(id);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Update(UpdateProductCategory command)
        {
            await Mediator.Send(command);

            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(DeleteProductCategory command)
        {
            await Mediator.Send(command);

            return Ok();
        }
    }
}
