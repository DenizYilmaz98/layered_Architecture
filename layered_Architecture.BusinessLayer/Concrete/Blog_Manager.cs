using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Concrete
{
    public class Blog_Manager : IBlog_Service
    {
        public void BLogAdd(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogDelete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogs()
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
