using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.UI.Controllers
{
    public class CommentsController : Controller
    {
        private readonly IComment_Service _comment_Service;

        public CommentsController(IComment_Service comment_Service)
        {
            _comment_Service = comment_Service;
        }       
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
           var values= _comment_Service.GetList(id);
            return PartialView(values);
        }
    }
}
