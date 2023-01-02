using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       public PartialViewResult partialAddComment()
        {
            return PartialView();
        }
        public PartialViewResult CommentsListByBlog()
        { 
            return PartialView();
        }
    }
}
