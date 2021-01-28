﻿using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ContentManagement.Models.StartPageModels;
using ContentManagement.Models.HeaderModels;
using ContentManagement.Data;
using ContentManagement.Models;
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
        public IActionResult Content()
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