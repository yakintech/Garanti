using Garanti.Application.Queries;
using Garanti.Dto;
using Garanti.Infrastructure;
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
}
