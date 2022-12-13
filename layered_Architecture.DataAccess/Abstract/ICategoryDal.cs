using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.DataAccess.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        List<Category> listAllCategory();
        void AddCategory(Category category);
        void RemoveCategory(Category category);
        void UpdateCategory(Category category);
        Category getCategoryId(int caetgoryId);
    }
}
