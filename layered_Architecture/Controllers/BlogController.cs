using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.Controllers
{
    public class BlogController : Controller
    {
        Blog_Manager bm = new Blog_Manager(new EfBlogRepository());

        public IActionResult Index()
        {
            var value = bm.GetBlogs();  
            return View(value);
        }
    }
}
