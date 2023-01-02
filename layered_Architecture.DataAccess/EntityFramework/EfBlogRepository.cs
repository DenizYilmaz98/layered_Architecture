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
        
        public List<Blog> GetListByCategories()
        {
            using (var cx = new Context())
                return cx.blogs.Include(c => c.Category).ToList(); 
                }
    }
}
