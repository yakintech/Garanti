using Garanti.Application.Commands;
using Garanti.Domain.Models;
using Garanti.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Application.CommandHandler
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Guid>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category
            {
                Name = request.Name,
                Description = request.Description
            };

            await unitOfWork.CategoryRepository.CreateAsync(category);
            await unitOfWork.CommitAsync();

            return category.Id;
        }
    }


    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
           await unitOfWork.CategoryRepository.DeleteAsync(request.Id);
           await unitOfWork.CommitAsync();

            
        }
    }
}
