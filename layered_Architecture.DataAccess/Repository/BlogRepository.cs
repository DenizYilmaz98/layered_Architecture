using layered_Architecture.DataAccess.Abstract;
using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.DataAccess.Repository
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Blog getBlogId(int blogId)
        {
            throw new NotImplementedException();
        }

        public List<Blog> lisAllBlog()
        {
            throw new NotImplementedException();
        }

        public void RemoveBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
