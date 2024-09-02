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
        public GenericRepository()
        {
            _context = new GarantiContext();
            _dbSet = _context.Set<T>();
        }

        public T Crate(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(Guid id)
        {
            var entity = _dbSet.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _context.SaveChanges();
            }

        }

        public T GetById(Guid id)
        {
            var entity = _dbSet.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
            return entity;
        }

        public T Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.Where(x => x.IsDeleted == false);
        }

        public IQueryable<T> GetAllWithQuery(Expression<Func<T, bool>> query)
        {
            return _dbSet.Where(query).Where(x => x.IsDeleted == false);
        }
    }
}
