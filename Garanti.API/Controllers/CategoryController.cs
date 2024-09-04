using Garanti.Application.Exceptions;
using Garanti.Domain.Models;
using Garanti.Dto;
using Garanti.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garanti.API.Controllers
{
    public class CategoryController : BaseController
    {

        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
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
               throw new DataNotFoundException($"Category with id {id} not found");
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

            _categoryRepository.Create(category);
            
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

