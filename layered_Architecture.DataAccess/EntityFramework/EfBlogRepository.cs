using layered_Architecture.DataAccess.Abstract;
using layered_Architecture.DataAccess.Concrete.Context;
using layered_Architecture.DataAccess.Repository;
using layered_Architecture.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.DataAccess.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        private readonly Context _context;

        public EfBlogRepository(Context context) : base(context)
        {
            _context = context;
        }

        public List<Blog> GetListByCategories()
        {
                return _context.blogs.Include(c => c.Category).ToList(); 
                }
    }
}
