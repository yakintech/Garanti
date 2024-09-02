using Garanti.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public override IQueryable<Category> GetAll()
        {
            var baseResponse = base.GetAll().ToList();
            baseResponse.Add(new Category
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Description = "Test"
            });
            return baseResponse.AsQueryable();
        }
    }
}
