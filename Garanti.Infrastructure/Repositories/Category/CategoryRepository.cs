using Garanti.Domain.Models;
using Garanti.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(GarantiContext context) : base(context)
        {

        }


        public override IQueryable<Category> GetAll()
        {
            //add test category
            var category = new Category
            {
                Name = "Test Category",
                Description = "Test Description",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            };
            
            var data = _dbSet.ToList();
            data.Add(category);

            return data.AsQueryable();
        }

    }
}
