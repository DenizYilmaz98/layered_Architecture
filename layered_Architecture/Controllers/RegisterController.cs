using FluentValidation.Results;
using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.BusinessLayer.Validation_Rules;
using layered_Architecture.DataAccess.Concrete.Context;
using layered_Architecture.DataAccess.EntityFramework;
using layered_Architecture.Entity.Concrete;
using layered_Architecture.UI.Models;
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

            ViewBag.Country_Cities = new SelectList(_context.writerscountry_city.ToList(), "CountryId", "Name");

            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p ,RegisterModelDto rdo)
        {
            WriterValidator wv = new WriterValidator();

            ValidationResult result = wv.Validate(p);
           
            if (result.IsValid)
            {
                p.CCID = rdo.CCID;
                p.writerStatus = true;
                p.writerAbout = "Deneme";
                _writer_Service.writerAdd(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
           return View(p);
        }

    }
}
