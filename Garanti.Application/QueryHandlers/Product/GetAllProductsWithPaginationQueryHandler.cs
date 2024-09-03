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
    public class GetAllProductsWithPaginationQueryHandler : IRequestHandler<GetAllProductsWithPaginationQuery, List<GetAllProductsResponseDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllProductsWithPaginationQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<GetAllProductsResponseDto>> Handle(GetAllProductsWithPaginationQuery request, CancellationToken cancellationToken)
        {
            var page = request.Page;
            var pageSize = request.PageSize;

            var products = _unitOfWork.ProductRepository.GetAll(page, pageSize, x => x.Category);

            var result = new List<GetAllProductsResponseDto>();

            result = products.Select(x => new GetAllProductsResponseDto
            {
                Id = x.Id,
                Name = x.Name,
                Stock = x.Stock,
                Price = x.Price,
                CategoryName = x.Category.Name
            }).ToList();
    

            return result;
        }
    }
}
