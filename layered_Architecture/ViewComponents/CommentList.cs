using layered_Architecture.Models;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           var commentValues = new List<UserComment>
           {
               new UserComment()
               {
                   UserId=1,
                   UserName="Deniz"
               },
               new UserComment()
               {
                   UserId = 2, 
                   UserName="Aslı"
               },
               new UserComment(){ 
               UserId= 3,
               UserName="Okyanus"

               }
           };
            return View(commentValues);
        }
     }
}
