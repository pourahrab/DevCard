using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.ViewComponent
{
    public class ProjectsViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"تاکسی","سفرهای درون شهری","TaxiCar"),
                new Project(2,"غذا","ارسال غذا","FoodDelivery"),
                new Project(3,"کتاب","ارسال کتاب","BookShop"),
                new Project(4,"فیلم","تماشای انلاین فیلم","FilmMarket "),
            };
            return View("_Projects",projects);
        }
    }
}
