using Garanti.Domain.Models;
using Garanti.Dto;
using Garanti.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garanti.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly GenericRepository<Category> _categoryRepository;
        public CategoryController()
        {
            _categoryRepository = new GenericRepository<Category>();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categories = _categoryRepository.GetAll();
            var response = categories.Select(x => new GetAllCategoriesResponseDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            });
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var category = _categoryRepository.GetById(id);

            if (category == null)
            {
                return NotFound($"Category with id {id} not found");
            }

            var response = new GetCategoryByIdResponseDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                CreatedDate = category.CreatedDate
            };
            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequestDto createCategoryDto)
        {

            Category category = new Category
            {
                Name = createCategoryDto.Name,
                Description = createCategoryDto.Description
            };

            _categoryRepository.Crate(category);
            
            return Ok(category.Id);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(Guid id)
        {
            _categoryRepository.Delete(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(Guid id, UpdateCategoryRequestDto updateCategoryDto)
        {
            var category = _categoryRepository.GetById(id);

            if (category == null)
            {
                return NotFound($"Category with id {id} not found");
            }

            category.Name = updateCategoryDto.Name;
            category.Description = updateCategoryDto.Description;
            _categoryRepository.Update(category);
            return Ok();
        }






    }
}

