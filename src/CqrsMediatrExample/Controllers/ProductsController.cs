using CqrsMediatrExample.Commands;
using CqrsMediatrExample.Models;
using CqrsMediatrExample.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatrExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase, IProductsController
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            var products = await _mediator.Send(new GetProductsQuery());
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProductBy(int id)
        {
            var product = await _mediator.Send(new GetProductByIdCommand(id));
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> AddAProduct([FromBody]Product product)
        {
            await _mediator.Send(new AddProductCommand(product));

            return StatusCode(201);

        }
    }
}
