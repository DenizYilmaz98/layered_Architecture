using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Abstract
{
    public interface IBlog_Service
    {
       
        void BLogAdd(Blog blog);
        void BlogUpdate(Blog blog);
        void BlogDelete(Blog blog);
        List<Blog> GetBlogs();
        List<Blog> GetBlogListWithCategories();
        List<Blog> GetBlogById(int Id);
    }
}
