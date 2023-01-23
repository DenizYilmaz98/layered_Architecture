using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.UI.Controllers
{
    public class CategoryController : Controller
    {
        Category_Manager cm = new Category_Manager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values=cm.GetCategories();
            return View(values);
        }
    }
}
