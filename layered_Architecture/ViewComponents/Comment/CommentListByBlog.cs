using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.UI.ViewComponents
{
    public class CommentListByBlog:ViewComponent
    {
        Comment_Manager cm = new Comment_Manager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id )
        {
            var values=cm.GetList(id);
            return View(values);

        }
      
    }
}
