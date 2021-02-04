using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.UnderPageModels.PageModel;
using ContentManagement.HeaderModel;
using ContentManagement.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContentManagement.HelperClasses;
using Microsoft.AspNetCore.Hosting;

namespace ContentManagement.Controllers
{
    public class UnderPageController : Controller
    {

        private readonly CMSDbContext context;
        private const string DefaultDropDownValue = "1";
        private readonly IWebHostEnvironment host;
        private int Id;
        public UnderPageController(CMSDbContext context, IWebHostEnvironment host)
        {
            this.context = context;
            this.host = host;
        }

        [HttpGet]
        // GET: UnderPageController/Details/5
        public ActionResult Details(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return Redirect("~/Login");
            }
        }

        [HttpGet]
        // GET: UnderPageController/Create
        public ActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View(new UnderPage());
            }
            else
            {
                return Redirect("~/Login");
            }
 
        }

        // POST: UnderPageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return View();
            }
            catch
            {
                return View();
            }
        }

    
        [HttpGet]
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                List<HeaderContent> headerContent = context.HeaderContent.ToList();
                ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme");

                var underPage = context.UnderPages.Where(s => s.HeaderContent.Id == int.Parse(DefaultDropDownValue)).ToList();
                return View(underPage);
            }
            else
            {
                return Redirect(Url.Content("~/Login"));
            }
        }

        // POST: UnderPageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string selecterDropDownValue)
        {
            try
            {

                List<HeaderContent> headerContent = context.HeaderContent.ToList();
                ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme");

                if (selecterDropDownValue == null)
                {
                    selecterDropDownValue = DefaultDropDownValue;
                }
                var underPage = context.UnderPages.Where(s => s.HeaderContent.Id == int.Parse(selecterDropDownValue)).ToList();
                return View(underPage);
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        // GET: UnderPageController/Edit/5
        public ActionResult Edit(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                UnderPageHelper helper = new UnderPageHelper(context,host);
                var page = helper.FetchUnderFromDB(new UnderPage(),id);
                page.UnderPage_ImgContent = helper.FetchAllImgeContentFromDB(page,id);
                page.UnderPage_TextContents = helper.FetchAllTextContentFromDB(page,id);
                page.UnderPage_TitleContents = helper.FetchAllTitleContentFromDB(page,id);

                if (page == null ||
                   page.UnderPage_ImgContent == null ||
                   page.UnderPage_TitleContents == null ||
                   page.UnderPage_TextContents == null)
                {
                    return NotFound();
                }

                return View(page);
            }
            else
            {
                return Redirect(Url.Content("~/Login"));
            }
        }


        // POST: UnderPageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UnderPage underPage)
        {
            if (ModelState.IsValid)
            {
                UnderPageHelper controllerHelper = new UnderPageHelper(context, host);
                var user = context.Users.Where(item => item.UserName == User.Identity.Name).FirstOrDefault();
                try
                {
                    if (controllerHelper.DoesAllImagesMatch(underPage, user))
                    {
                        controllerHelper.SaveToDb();
                    }
                    if (controllerHelper.DoesAllTextsMatch(underPage, user))
                    {
                        controllerHelper.SaveToDb();
                    }
                    if (controllerHelper.DoesAllTitlesMatch(underPage, user))
                    {
                        controllerHelper.SaveToDb();
                    }
                    if (controllerHelper.DoesAllUnderPageLinkTitleMatch(underPage, user))
                    {
                        controllerHelper.SaveToDb();
                    }
                    return RedirectToAction("Edit", new { id = underPage.Id }); ;
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
         
        }

        [HttpGet]
        // GET: UnderPageController/Delete/5
        public ActionResult Delete(int id)
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

        // POST: UnderPageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
