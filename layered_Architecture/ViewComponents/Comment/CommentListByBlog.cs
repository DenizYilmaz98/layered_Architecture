using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.UI.ViewComponents
{
    public class CommentListByBlog:ViewComponent
    {
        private readonly Comment_Manager _comment_Manager;
        public CommentListByBlog(Comment_Manager comment_Manager)
        {
            _comment_Manager = comment_Manager;
        }
        public IViewComponentResult Invoke(int id )
        {
            var values=_comment_Manager.GetList(id);
            return View(values);

        }
      
    }
}
