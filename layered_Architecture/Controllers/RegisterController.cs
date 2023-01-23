using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.EntityFramework;
using layered_Architecture.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace layered_Architecture.UI.Controllers
{
    public class RegisterController : Controller
    {
        Writer_Manager wm = new Writer_Manager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p)
        {
            p.writerStatus = true;
            p.writerAbout = "Deneme"; 
            wm.writerAdd(p);
            return RedirectToAction("Index","Blog");
        }
    }
}
