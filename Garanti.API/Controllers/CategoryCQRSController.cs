using Garanti.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garanti.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryCQRSController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryCQRSController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = await _mediator.Send(new GetAllCategoriesQuery());
            return Ok(result);
        }

    }
}
