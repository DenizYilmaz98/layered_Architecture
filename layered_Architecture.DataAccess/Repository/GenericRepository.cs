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
    public class GenericRepository<T> : IGenericDal <T> where T : class
    {
        public void Delete(T entity)
        {
            using var c = new Context();

            c.Remove(entity);
            c.SaveChanges();

        }

        public T GetById(int Id)
        {
            using var c = new Context();
            return c.Set<T>().Find(Id);
        }

        public List<T> GetListAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();

        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();

            return c.Set<T>().Where(filter).ToList();
        }

        public void Insert(T entity)
        {
            using var c = new Context();

            c.Add(entity);
            c.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();

        }

        public void Update(T entity)
        {
            using var c = new Context();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
