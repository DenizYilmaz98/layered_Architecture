using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.UI.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        private readonly Category_Manager _category_Manager;
        public CategoryList( Category_Manager category_Manager)
        {
            _category_Manager = category_Manager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _category_Manager.GetCategories();
            return View(values);
        }
    }
}
