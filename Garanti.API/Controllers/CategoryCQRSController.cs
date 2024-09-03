using Garanti.Application.Commands;
using Garanti.Application.Queries;
using Garanti.Dto;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(Guid id)
        {
            var result = await _mediator.Send(new GetCategoryByIdQuery { Id = id });
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequestDto model)
        {
            var command = new CreateCategoryCommand
            {
                Name = model.Name,
                Description = model.Description
            };
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            var command = new DeleteCategoryCommand
            {
                Id = id
            };
            await _mediator.Send(command);
            return Ok();
        }

       

    }
}
