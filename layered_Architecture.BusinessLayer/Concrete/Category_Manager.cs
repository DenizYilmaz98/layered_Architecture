using layered_Architecture.BusinessLayer.Abstract;
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
        private readonly EfCategoryRepository _efcategoryRepository;

        public Category_Manager()
        {
            _efcategoryRepository = new EfCategoryRepository();
                
        }
        public void CategoryAdd(Category category)
        {
            _efcategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _efcategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _efcategoryRepository.Update(category);
        }

        public Category GetById(int Id)
        {
             return _efcategoryRepository.GetById(Id);
        }

        public List<Category> GetCategories()
        {
            return _efcategoryRepository.GetListAll();
                }
    }
}
