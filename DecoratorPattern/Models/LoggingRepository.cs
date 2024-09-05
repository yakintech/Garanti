using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Models
{
    internal class LoggingRepository<T> : IRepository<T>
    {
        private readonly IRepository<T> _repository;

        public LoggingRepository(IRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {
            Console.WriteLine("Adding entity");
            _repository.Add(entity);
        }

        public void Delete(T entity)
        {
            Console.WriteLine("Deleting entity");
            _repository.Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
            Console.WriteLine("Getting all entities");
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            Console.WriteLine("Getting entity by id " + id);
            return _repository.GetById(id);
        }
    }
}
