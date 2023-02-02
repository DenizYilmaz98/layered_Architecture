using layered_Architecture.BusinessLayer.Abstract;
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
        private readonly IWriter_Service _writer_Service;
        private readonly Context _context;

        public RegisterController(IWriter_Service writer_Service, Context context)
        {
            _writer_Service = writer_Service;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<SelectListItem> SehirList = (from i in _context.writerscountry_city.ToList()
                                              select new SelectListItem()
                                              {
                                                  Text = i.Country_City,
                                                  Value = i.CCID.ToString()
                                              }).ToList();
            ViewBag.Country_Cities = SehirList;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p ,writersCountry_City wc)
        {
            p.CCID=wc.CCID;
            p.writerStatus = true;
            p.writerAbout = "Deneme";
            _writer_Service.writerAdd(p);
            return RedirectToAction("Index", "Blog");
        }

    }
}
