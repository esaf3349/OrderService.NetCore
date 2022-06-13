using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Application.Commands.Products;
using OrderService.Application.Queries.Products.GetProducts;
using System.Threading.Tasks;

namespace OrderService.WebApi.Controllers
{
    public class ProductsController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetProductsVm))]
        public async Task<ActionResult<GetProductsVm>> GetAll(int pageNumber = 0, int pageSize = 20)
        {
            return Ok(await Mediator.Send(new GetProducts { PageNumber = pageNumber, PageSize = pageSize }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> Create(CreateProduct command)
        {
            var id = await Mediator.Send(command);

            return Ok(id);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Update(UpdateProduct command)
        {
            await Mediator.Send(command);

            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(DeleteProduct command)
        {
            await Mediator.Send(command);

            return Ok();
        }
    }
}
