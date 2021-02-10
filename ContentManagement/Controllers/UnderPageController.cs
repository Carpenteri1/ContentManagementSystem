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
using System.Diagnostics;
using ContentManagement.Models.Account;
using Microsoft.EntityFrameworkCore;

namespace ContentManagement.Controllers
{
    public class UnderPageController : Controller
    {

        private readonly CMSDbContext context;
        private const string DefaultDropDownValue = "1";
        private readonly IWebHostEnvironment host;
        public UnderPageController(CMSDbContext context, IWebHostEnvironment host)
        {
            this.context = context;
            this.host = host;
        }

        [HttpGet]
        // GET: UnderPageController/Create
        public ActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                List<HeaderContent> headerContent = context.HeaderContent.ToList();
                ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme");
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
        public ActionResult Create(UnderPage newPage,string selecterDropDownValue)
        {
            if (ModelState.IsValid && 
                newPage.LinkTitle != null)
            {
                UnderPageHelper controllerHelper = new UnderPageHelper(context,host);
                var user = context.Users.Where(user => user.UserName == User.Identity.Name).FirstOrDefault();
                try
                {
                    newPage = controllerHelper.CreateNewPageData(newPage, user, int.Parse(selecterDropDownValue));
                    if (newPage != null)
                    {
                        controllerHelper.SaveToDb();
                    }
                    return Redirect(nameof(Index));
                }
                catch
                {
                    return Redirect(nameof(Index));
                }
            }
            else
            {
                return Redirect(nameof(Index));
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
                return Redirect(nameof(Index));
            }
        }

        [HttpGet]
        // GET: UnderPageController/Edit/5
        public ActionResult Edit(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                UnderPageHelper helper = new UnderPageHelper(context,host);
                var page = helper.FetchUnderPageFromDB(new UnderPage(),id);
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
                    return RedirectToAction("Edit", new { id = underPage.Id }); 
                }
                catch
                {
                    return Redirect(nameof(Index));
                }
            }
            else
            {
                return Redirect(nameof(Index));
            }
         
        }

        [HttpGet]
        // GET: UnderPageController/Delete/5
        public ActionResult Delete(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                UnderPageHelper controllerHelper = new UnderPageHelper(context, host);
                var page = controllerHelper.FetchUnderPageFromDB(new UnderPage(),id);
                page.UnderPage_ImgContent = controllerHelper.FetchAllImgeContentFromDB(page, id);
                page.UnderPage_TextContents = controllerHelper.FetchAllTextContentFromDB(page, id);
                page.UnderPage_TitleContents = controllerHelper.FetchAllTitleContentFromDB(page, id);

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

        // POST: UnderPageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(UnderPage underPage)
        {
            try
            {
                UnderPageHelper controllerHelper = new UnderPageHelper(context, host);
                if (controllerHelper.Remove(underPage))
                {
                    controllerHelper.SaveToDb();
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
