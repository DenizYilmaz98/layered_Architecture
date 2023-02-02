using layered_Architecture.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.UI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlog_Service _blog_Service;

        public BlogController(IBlog_Service blog_Service)
        {
            _blog_Service = blog_Service;
        }
        

        public IActionResult Index()
        {
            var value = _blog_Service.GetBlogListWithCategories();  
            return View(value);
        }
        public IActionResult BlogReadAll(int Id)
        {
            ViewBag.i = Id;
            var gtbg = _blog_Service.GetBlogById(Id);
            return View(gtbg);
        }
    }
}
