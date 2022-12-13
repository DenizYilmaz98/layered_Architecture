using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.DataAccess.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {

        List<Blog> lisAllBlog();
        void AddBlog(Blog blog);
        void RemoveBlog(Blog blog);
        void UpdateBlog(Blog blog);
        Blog getBlogId(int blogId);
    }
}
