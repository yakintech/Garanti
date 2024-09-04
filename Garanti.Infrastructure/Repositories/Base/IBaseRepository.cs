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


        T Get(Expression<Func<T, bool>> query);
        IQueryable<T> GetAllWithQuery(Expression<Func<T, bool>> query);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);

        //GetAll Include and pagination
        IQueryable<T> GetAll(int page, int pageSize, params Expression<Func<T, object>>[] includeProperties);
        T GetById(Guid id);
        Task<T> GetByIdAsync(Guid id);

        T GetById(Guid id, params Expression<Func<T, object>>[] includeProperties);
        T Create(T entity);
        Task<T> CreateAsync(T entity);
        T Update(T entity);
        Task<T> UpdateAsync(T entity);
        void Delete(Guid id);
        Task DeleteAsync(Guid id);
    }
}
