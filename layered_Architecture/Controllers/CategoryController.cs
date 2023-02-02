using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategory_Service _category_Service;

        public CategoryController(ICategory_Service category_Service)
        {
            _category_Service = category_Service;
        }        public IActionResult Index()
        {
            var values=_category_Service.GetCategories();
            return View(values);
        }
    }
}
