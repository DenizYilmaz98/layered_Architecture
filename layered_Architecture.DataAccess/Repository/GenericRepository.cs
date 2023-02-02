using layered_Architecture.DataAccess.Abstract;
using layered_Architecture.DataAccess.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal <T> where T : class, new()
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }
        public void Delete(T entity)
        {

            _context.Remove(entity);
            _context.SaveChanges();

        }

        public T GetById(int Id)
        {
            
            return _context.Set<T>().Find(Id);
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();

        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {

            return _context.Set<T>().Where(filter).ToList();
        }

        public void Insert(T entity)
        {

            _context.Add(entity);
            _context.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();

        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
