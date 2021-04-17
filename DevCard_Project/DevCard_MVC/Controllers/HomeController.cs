using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Http;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1,"نقره ای"),
            new Service(2,"طلایی"),
            new Service(3,"پلاتین"),
             new Service(4,"الماس"),
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_services,"Id","Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            form.Services = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده معتبر نیست لطفا دوباره تلاش کنید";

                return View(form);
            }
            // return RedirectToAction("Index");

            ModelState.Clear();
            form = new Contact
            {
                Services = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_services, "Id", "Name")
            };
            ViewBag.success  = "پیام شما با موفقیت ثبت شد با تشکر.";
            return View(form);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
