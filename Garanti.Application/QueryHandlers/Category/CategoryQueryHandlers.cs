using Garanti.Application.Queries;
using Garanti.Domain.Models;
using Garanti.Dto;
using Garanti.Infrastructure;
using Garanti.Infrastructure.Repositories.Base;
using Garanti.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Application.QueryHandlers
{

    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<GetAllCategoriesResponseDto>>
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetAllCategoriesQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<GetAllCategoriesResponseDto>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = _unitOfWork.CategoryRepository.GetAll();
            var result = new List<GetAllCategoriesResponseDto>();
            result = categories.Select(x => new GetAllCategoriesResponseDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            }).ToList();

            return result;
        }
    }


    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdResponseDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryRepository _categoryRepository;
        private readonly LoggingRepository<Category> _loggingCategoryRepository;

        public GetCategoryByIdQueryHandler(IUnitOfWork unitOfWork
            , ICategoryRepository categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
            _loggingCategoryRepository = new LoggingRepository<Category>(categoryRepository);
        }

        public async Task<GetCategoryByIdResponseDto> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = _loggingCategoryRepository.GetById(request.Id);
            var result = new GetCategoryByIdResponseDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                CreatedDate = category.CreatedDate
            };

            return result;
        }
    }
}
