using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.DataAccess.Abstract;
using layered_Architecture.DataAccess.EntityFramework;
using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Concrete
{
    public class Category_Manager : ICategory_Service
    {
        private readonly ICategoryDal _categoryDal;

        public Category_Manager(ICategoryDal categoryDal)
        {
       _categoryDal = categoryDal;
        }
        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int Id)
        {
             return _categoryDal.GetById(Id);
        }

        public List<Category> GetCategories()
        {
            return _categoryDal.GetListAll();

                }
    }
}
