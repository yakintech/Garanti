using Garanti.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Infrastructure.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {

        IQueryable<T> GetAllWithQuery(Expression<Func<T, bool>> query);
        IQueryable<T> GetAll();
        T GetById(Guid id);
        T Crate(T entity);
        T Update(T entity);
        void Delete(Guid id);
    }
}
