using Garanti.Application.Commands;
using Garanti.Application.Queries;
using Garanti.Dto;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garanti.API.Controllers
{
    public class ProductCQRSController : BaseController
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


        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequestDto model)
        { 
            var command = new CreateProductCommand
            {
                Name = model.Name,
                Price = model.Price,
                Stock = model.Stock,
                CategoryId = model.CategoryId
            };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        
    }
}
