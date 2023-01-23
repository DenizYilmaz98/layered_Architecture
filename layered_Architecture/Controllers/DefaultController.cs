using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.UI.Controllers
{
    public class DefaultController : Controller
    {
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}
