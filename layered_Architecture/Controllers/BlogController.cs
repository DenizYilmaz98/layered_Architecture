using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.UI.Controllers
{
    public class BlogController : Controller
    {
        Blog_Manager bm = new Blog_Manager(new EfBlogRepository());

        public IActionResult Index()
        {
            var value = bm.GetBlogListWithCategories();  
            return View(value);
        }
        public IActionResult BlogReadAll(int Id)
        {
            ViewBag.i = Id;
            var gtbg = bm.GetBlogById(Id);
            return View(gtbg);
        }
    }
}
