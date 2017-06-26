using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin.Database.Repositories
{
    public abstract class AbstractRepository<T> : IRepository<T> where T: class
    {
        private readonly IDataContext _context;
        protected AbstractRepository(IDataContext context)
        {
            _context = context;
        }
        public IQueryable<T> GetQueryable()
        {
            return _context.Set<T>();
        }

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity;
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}
