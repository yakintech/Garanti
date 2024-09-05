using Garanti.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Infrastructure.Repositories.Base
{
    public class LoggingRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> _repository;

        public LoggingRepository(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public T Create(T entity)
        {
            Console.WriteLine("Adding entity");
            return _repository.Create(entity);
        }

        public Task<T> CreateAsync(T entity)
        {
            Console.WriteLine("Adding entity");
            return _repository.CreateAsync(entity);
        }

        public void Delete(Guid id)
        {
            Console.WriteLine("Deleting entity");
            _repository.Delete(id);
        }

        public Task DeleteAsync(Guid id)
        {
            Console.WriteLine("Deleting entity");
            return _repository.DeleteAsync(id);
        }

        public T Get(Expression<Func<T, bool>> query)
        {
            Console.WriteLine("Getting entity by query");
            return _repository.Get(query);
        }

        public IQueryable<T> GetAll()
        {
            Console.WriteLine("Getting all entities. Class: " + typeof(T).Name);
            return _repository.GetAll();
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            Console.WriteLine("Getting all entities with include properties");
            return _repository.GetAll(includeProperties);
        }

        public IQueryable<T> GetAll(int page, int pageSize, params Expression<Func<T, object>>[] includeProperties)
        {
            Console.WriteLine("Getting all entities with include properties and paging");
            return _repository.GetAll(page, pageSize, includeProperties);
        }

        public IQueryable<T> GetAllWithQuery(Expression<Func<T, bool>> query)
        {
            Console.WriteLine("Getting all entities with query");
            return _repository.GetAllWithQuery(query);
        }

        public T GetById(Guid id)
        {
            Console.WriteLine("Getting entity by id " + id);
            return _repository.GetById(id);
        }

        public T GetById(Guid id, params Expression<Func<T, object>>[] includeProperties)
        {
            Console.WriteLine("Getting entity by id with include properties");
            return _repository.GetById(id, includeProperties);
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            Console.WriteLine("Getting entity by id async");
            return _repository.GetByIdAsync(id);
        }

        public T Update(T entity)
        {
            Console.WriteLine("Updating entity");
            return _repository.Update(entity);
        }

        public Task<T> UpdateAsync(T entity)
        {
            Console.WriteLine("Updating entity async");
            return _repository.UpdateAsync(entity);
        }
    }
}
