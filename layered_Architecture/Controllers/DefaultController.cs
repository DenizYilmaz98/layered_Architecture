using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.Controllers
{
    public class DefaultController : Controller
    {
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}
