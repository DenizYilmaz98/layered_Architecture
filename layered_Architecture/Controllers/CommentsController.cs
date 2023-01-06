using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.Controllers
{
    public class CommentsController : Controller
    {
      Comment_Manager cm = new Comment_Manager(new EfCommetRepository());
        public IActionResult Index()
        {
            return View();
        }
       public PartialViewResult partialAddComment()
        {
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
           var values= cm.GetComments(id);
            return PartialView(values);
        }
    }
}
