using HS11PR001.Application.Features.Products.Commands.ProductCreate;
using HS11PR001.Application.Features.Products.Queries.GetProductList;
using HS11PR001.Application.Features.Products.Queries.GetProductListByName;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductSystem.Application.Features.Products.Commands.ProductUpdate;

namespace HS11PR001.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<bool>> CreateAsync([FromBody] ProductCreateCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<bool>> GetListByNameAsync([FromBody] GetProductListByNameQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<bool>> GetListAsync()
        {
            var result = await mediator.Send(new GetProductListQuery());
            return Ok(result);
        }
		[HttpPost("[action]")]
		public async Task<ActionResult<ProductUpdateCommand>> Update([FromBody] ProductUpdateCommand command)
		{
			var result = await mediator.Send(command);
			return Ok(result);
		}
	} 
}
