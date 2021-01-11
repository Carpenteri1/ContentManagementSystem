using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ContentManagement.Models;
using ContentManagement.Models.Content;
using ContentManagement.Data;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace ContentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly CMSDbContext context;
        public HomeController(ILogger<HomeController> logger, CMSDbContext context)
        {
            this.logger = logger;
            this.context = context;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return Redirect(Url.Content("~/Login"));
            }
          
        }
        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Content()
        {
            if (User.Identity.IsAuthenticated)
            {
                var model = new List<TitleModel>();
                foreach (var s in context.TitleModel)
                {
                    s.TypeOfTitle = "h1";
                    model.Add(s);
                }

                return View(model);
            }
            else
            {
                return Redirect(Url.Content("~/Login")); 
            }
          
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
