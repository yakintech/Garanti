using Garanti.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garanti.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCQRSController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ProductCQRSController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{page}/{pageSize}")]
        public async Task<IActionResult> GetAllProducts(int page, int pageSize)
        {
            var query = new GetAllProductsWithPaginationQuery
            {
                Page = page,
                PageSize = pageSize
            };
            var response = await _mediator.Send(query);
            return Ok(response);
        }

      
        
    }
}
