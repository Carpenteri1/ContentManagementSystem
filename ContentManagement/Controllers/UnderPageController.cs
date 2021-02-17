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
                UnderPageControllerHelper controllerHelper = new UnderPageControllerHelper(context, host);
                List<HeaderContent> headerContent = controllerHelper.GetAllHeadContent();
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
            if (newPage.LinkTitle != null)
            {
                UnderPageControllerHelper controllerHelper = new UnderPageControllerHelper(context,host);
                var user = controllerHelper.GetUserByName(User.Identity.Name);
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
                UnderPageControllerHelper underPageControllerHelper = new UnderPageControllerHelper(context,host);
                List<HeaderContent> headerContent = underPageControllerHelper.GetAllHeadContent();
                ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme");
                var underPage = underPageControllerHelper.GetUnderPageByDropDownValue(int.Parse(DefaultDropDownValue));

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
                UnderPageControllerHelper underPageControllerHelper = new UnderPageControllerHelper(context, host);
                List<HeaderContent> headerContent = underPageControllerHelper.GetAllHeadContent();
                ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme");
                var underPage = underPageControllerHelper.GetUnderPageByDropDownValue(int.Parse(underPageControllerHelper.CheckDropDownValue(selecterDropDownValue)));
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

                UnderPageControllerHelper underPageControllerHelper = new UnderPageControllerHelper(context, host);
                List<HeaderContent> headerContent = underPageControllerHelper.GetAllHeadContent();
                ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme");

                var page = underPageControllerHelper.GetUnderPageById(id);
                page.UnderPage_ImgContent = underPageControllerHelper.GetImgeContentById(page.Id);
                page.UnderPage_TextContents = underPageControllerHelper.GetTextContentById(page.Id);
                page.UnderPage_TitleContents = underPageControllerHelper.GetTitleContentById(page.Id);

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
        public ActionResult Edit(UnderPage underPage, string selecterDropDownValue)
        {
                UnderPageControllerHelper controllerHelper = new UnderPageControllerHelper(context, host);
                var user = controllerHelper.GetUserByName(User.Identity.Name);
                List<HeaderContent> headerContent = controllerHelper.GetAllHeadContent();
                ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme");
                underPage.HeaderContent = controllerHelper.GetHeaderContentByDropDownValue(int.Parse(controllerHelper.CheckDropDownValue(selecterDropDownValue)));

                try
                {
                    if (!controllerHelper.DoesAllContentMatch(underPage, user))
                    {
                            controllerHelper.SaveToDb();
                    }
                    return RedirectToAction("Edit", new { id = underPage.Id }); 
                }
                catch(Exception e)
                {
                    Debug.WriteLine(e.Message);
                    return Redirect(nameof(Index));
                }        
        }

        [HttpGet]
        // GET: UnderPageController/Delete/5
        public ActionResult Delete(int id)
        {
            if (User.Identity.IsAuthenticated)
            {

                UnderPageControllerHelper controllerHelper = new UnderPageControllerHelper(context, host);
                var page = controllerHelper.GetUnderPageById(id);
                page.UnderPage_ImgContent = controllerHelper.GetImgeContentById(page.Id);
                page.UnderPage_TextContents = controllerHelper.GetTextContentById(page.Id);
                page.UnderPage_TitleContents = controllerHelper.GetTitleContentById(page.Id);

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
                UnderPageControllerHelper controllerHelper = new UnderPageControllerHelper(context, host);
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
