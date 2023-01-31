using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.DataAccess.Concrete.Context;
using layered_Architecture.DataAccess.EntityFramework;
using layered_Architecture.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace layered_Architecture.UI.Controllers
{
    public class RegisterController : Controller
    {
        Writer_Manager wm = new Writer_Manager(new EfWriterRepository());
        Context cx = new Context();
        
        
        [HttpGet]
        public IActionResult Index()
        {
            List<SelectListItem> SehirList = (from i in cx.writerscountry_city.ToList()
                                              select new SelectListItem()
                                              {
                                                  Text = i.Country_City ,
                                                  Value = i.CCID.ToString()
                                              }).ToList();
            ViewBag.Country_Cities = SehirList;
            return View();
            }
        [HttpPost] 
        public IActionResult Index(Writer p)
        {
            var cc = cx.writerscountry_city.Where(m => m.CCID == p.CCID).FirstOrDefault();
            p.writerscountry_city = cc;
            p.writerStatus = true;
            p.writerAbout = "Deneme";
            wm.writerAdd(p);
            return RedirectToAction("Index", "Blog");
        }

    }
}
