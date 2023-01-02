using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.DataAccess.Abstract;
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
        private readonly IBlogDal _blogDal;

        public Blog_Manager(IBlogDal _blogDal)
        {
            this._blogDal = _blogDal;
        }
        public void BLogAdd(Blog blog)
        {
            _blogDal.Insert(blog);
                }

        public void BlogDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> GetBlogListWithCategories()
        {
            return _blogDal.GetListByCategories();
        }

        public List<Blog> GetBlogs()
        {
            return _blogDal.GetListAll();

        }

        public List<Blog> GetBlogById(int Id)
        {

            return _blogDal.GetListAll(x => x.blogId == Id);
        }
    }
}
