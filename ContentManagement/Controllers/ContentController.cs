using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ContentManagement.StartPageModels.PageModel;
using ContentManagement.StartPageModels.HeaderModels;
using ContentManagement.Data;
using ContentManagement.Models;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using ContentManagement.UnderPageModels.PageModel;

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
        public IActionResult Content()
        {
            if (User.Identity.IsAuthenticated)
            {      /*
                List<UnderPage> underPages = context.UnderPages.ToList();
                List<UnderPage_TitleContents> titles = context.UnderPages_titlecontents.ToList();
                List<UnderPage_TextContents> textContents = context.UnderPages_TextContents.ToList();
                List<UnderPage_ImgContents> Imges = context.UnderPages_imgcontents.ToList();
          
                for (int i = 0; i < underPages.Count(); i++)
                {
                    underPages[i].UnderPage_TextContents == titles.Find(item => item.UnderPage.Id == underPages[i].Id).FirstOrDefault();
                }

                foreach (var s in underPages)
                {
                    for (int i = 0; i < titles.Count(); i++)
                    {
                        if (s.Id.Equals(titles[i].UnderPage.Id))
                        {
                            s.UnderPage_TitleContents.Add(titles[i]);
                        }
                    }
                    for(int i = 0; i < textContents.Count(); i++)
                    {
                        if (s.Id.Equals(textContents[i].UnderPage.Id))
                        {
                            s.UnderPage_TextContents.Add(textContents[i]);
                        }
                    }
                    for(int i = 0; i < Imges.Count(); i++)
                    {
                        if (s.Id.Equals(Imges[i].UnderPage.Id))
                        {
                            s.UnderPage_ImgContents.Add(Imges[i]);
                            //s.UnderPage_ImgContents[i] = Imges.Where(item => item.UnderPage.Id == i).FirstOrDefault();
                        }

                    }
       
                }*/

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
