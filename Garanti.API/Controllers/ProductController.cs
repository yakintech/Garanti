using Garanti.Domain.Models;
using Garanti.Dto;
using Garanti.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garanti.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productRepository.GetAll(q => q.Category);
            var response = new List<GetAllProductsResponseDto>();

            foreach (var product in products)
            {
                response.Add(new GetAllProductsResponseDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Stock = product.Stock,
                    CategoryName = product.Category?.Name
                });
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(Guid id)
        {
            var product = _productRepository.GetById(id, q => q.Category);
            if (product == null)
            {
                return NotFound();
            }

            var response = new GetProductByIdResponseDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                CategoryName = product.Category?.Name
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductRequestDto request)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock,
                CategoryId = request.CategoryId
            };

            _productRepository.Create(product);
            return Ok(product.Id);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(Guid id)
        {
            _productRepository.Delete(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(Guid id, UpdateProductRequestDto request)
        {
            var product = _productRepository.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            product.Name = request.Name;
            product.Price = request.Price;
            product.Stock = request.Stock;
            product.CategoryId = request.CategoryId;

            _productRepository.Update(product);
            return Ok();
        }
    }
}
