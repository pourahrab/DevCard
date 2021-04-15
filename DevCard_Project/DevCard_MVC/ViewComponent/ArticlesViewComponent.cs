using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.ViewComponent
{
    public class ArticlesViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Models.Article>()
            {
                new Models.Article(1,"اموزش view component","تمرین ASP .Net Core view component" ,"blog-post-thumb-3.jpg" ),
                new Models.Article(2,"اموزش Partial View","تمرین ASP .Net Core Partial View" ,"blog-post-thumb-6.jpg" ),
                new Models.Article(3,"اموزش MVC","تمرین ASP .Net Core MVC" ,"blog-post-banner.jpg" ),
                new Models.Article(4,"اموزش .net core","تمرین ASP .Net Core" ,"blog-post-thumb-2.jpg" ),
            };
            return View("_Articles", articles);
        }
    }
}
