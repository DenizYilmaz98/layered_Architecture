using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.UI.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        Category_Manager cm = new Category_Manager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = cm.GetCategories();
            return View(values);
        }
    }
}
