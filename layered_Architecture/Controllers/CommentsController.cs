using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.UI.Controllers
{
    public class CommentsController : Controller
    {
      Comment_Manager cm = new Comment_Manager(new EfCommentRepository());
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
           var values= cm.GetList(id);
            return PartialView(values);
        }
    }
}
