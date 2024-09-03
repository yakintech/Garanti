using Garanti.Domain.Models;
using Garanti.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Infrastructure.Repositories
{
    public class GenericRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        internal GarantiContext _context;
        internal DbSet<T> _dbSet;
        public GenericRepository(GarantiContext garantiContext)
        {
            _context = garantiContext;
            _dbSet = _context.Set<T>();
        }

        public virtual T Create(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public virtual void Delete(Guid id)
        {
            var entity = _dbSet.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
            if (entity != null)
            {
                entity.IsDeleted = true;
            }
            else
            {
                throw new Exception("Entity not found");
            }

        }

        public virtual T GetById(Guid id)
        {
            var entity = _dbSet.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
            return entity;
        }

        public virtual T GetById(Guid id, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            var entity = query.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
            return entity;
        }

        public virtual T Update(T entity)
        {
            _dbSet.Update(entity);
            return entity;
        }

        public virtual IQueryable<T> GetAll()
        {
            return _dbSet.Where(x => x.IsDeleted == false);
        }

        public virtual IQueryable<T> GetAllWithQuery(Expression<Func<T, bool>> query)
        {
            return _dbSet.Where(query).Where(x => x.IsDeleted == false);
        }

        public virtual IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.Where(x => x.IsDeleted == false);
        }
    }
}
