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
        List<Blog> GetBlogs();
        void BLogAdd(Blog blog);
        void BlogUpdate(Blog blog);
        void BlogDelete(Blog blog);
        Blog GetById(int Id);
    }
}
