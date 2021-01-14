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
    public class ContentController : Controller
    {
        private readonly ILogger<ContentController> logger;
        private readonly CMSDbContext context;
        public ContentController(ILogger<ContentController> logger, CMSDbContext context)
        {
            this.logger = logger;
            this.context = context;
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

        [Route("NewPage")]
        [HttpGet]
        public ActionResult NewPage()
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


        [Route("NewPage")]
        [HttpPost]
        public ActionResult NewPage(PageModel newPage)
        {
            

            return View();
        }

        [Route("Startpage")]
        [HttpGet]
        public ActionResult StartPage()
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
        [Route("Editpage")]
        [HttpGet]
        public ActionResult EditPage()
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
        
        [Route("Editpage")]
        [HttpPost]
        public ActionResult EditPage(PageModel page)
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [Route("Events")]
        [HttpGet]
        public ActionResult Events()
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



        [Route("Adverts")]
        [HttpGet]
        public ActionResult Adverts()
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


    }
}
