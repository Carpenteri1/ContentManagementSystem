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
        private string dropdownValue = string.Empty;
        public UnderPageController(CMSDbContext context, IWebHostEnvironment host)
        {
            this.context = context;
            this.host = host;
        }

        [HttpGet]
        // GET: UnderPageController/Create
        public ActionResult Create(string dropdownValue)
        {
            if (User.Identity.IsAuthenticated)
            {
                UnderPageControllerHelper controllerHelper = new UnderPageControllerHelper(context, host);
                List<HeaderContent> headerContent = controllerHelper.GetAllHeadContent();
                ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme");
                ViewData["AmmountOfAdds"] = new SelectList("10", "AmmountOfAdverts"); 
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
                    newPage.AmmountOfAdverts = 3;
                    newPage = controllerHelper.CreateNewPageData(newPage, user, int.Parse(selecterDropDownValue));
                    if (newPage != null)
                    {
                        controllerHelper.SaveToDb();
                    }
                    return RedirectToAction("Index", new { dropdownValue = selecterDropDownValue });
                }
                catch
                {
                    return RedirectToAction("Index", new { dropdownValue = selecterDropDownValue });
                }
            }
            else
            {
                return Redirect(nameof(Index));
            }

        }

    
        [HttpGet]
        public ActionResult Index(string dropdownValue)
        {
            if (User.Identity.IsAuthenticated)
            {
                
                UnderPageControllerHelper underPageControllerHelper = new UnderPageControllerHelper(context,host);
                List<HeaderContent> headerContent = underPageControllerHelper.GetAllHeadContent();
              
                if(dropdownValue != null)
                {
                    var underPage = underPageControllerHelper.GetUnderPageByDropDownValue(int.Parse(dropdownValue));
                    ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme", dropdownValue);
                    return View(underPage);
                }
                else
                {
                    var underPage = underPageControllerHelper.GetUnderPageByDropDownValue(int.Parse(DefaultDropDownValue));
                    ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme", DefaultDropDownValue);
                    return View(underPage);
                }
                    
            }
            else
            {
                return Redirect(Url.Content("~/Login"));
            }
        }

        [HttpPost]
        public ActionResult MoveUp(int Id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var currentPage = context.UnderPages.Where(item => item.Id == Id).FirstOrDefault(); 
                UnderPageControllerHelper underPageControllerHelper = new UnderPageControllerHelper(context, host);
                underPageControllerHelper.ChangeOrderPosition(currentPage,true);
                return RedirectToAction("Index", new { dropdownValue = currentPage.HeaderContent.Id.ToString()});
            }
            else
            {
                return Redirect(Url.Content("~/Login"));
            }

        }
        [HttpPost]
        public ActionResult MoveDown(int Id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var currentPage = context.UnderPages.Where(item => item.Id == Id).FirstOrDefault();
                UnderPageControllerHelper underPageControllerHelper = new UnderPageControllerHelper(context, host);
                underPageControllerHelper.ChangeOrderPosition(currentPage, false);
                return RedirectToAction("Index", new { dropdownValue = currentPage.HeaderContent.Id.ToString() });

            }
            else
            {
                return Redirect(Url.Content("~/Login"));
            }
        }

        // POST: UnderPageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string selecterDropDownValue,int id)
        {
            try
            {
                UnderPageControllerHelper underPageControllerHelper = new UnderPageControllerHelper(context, host);
                List<HeaderContent> headerContent = underPageControllerHelper.GetAllHeadContent();
                ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme",selecterDropDownValue);
                ViewData["DropDownValue"] = selecterDropDownValue;
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
             

                var page = underPageControllerHelper.GetUnderPageById(id);
                ViewData["Headerid"] = page.HeaderContent.Id;
                ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme", page.HeaderContent.Id.ToString());
                page.TopImage = underPageControllerHelper.GetImgeContentById(id);

                //page.UnderPage_ImgContent = underPageControllerHelper.GetImgeContentById(page.Id);
                //page.UnderPage_TextContents = underPageControllerHelper.GetTextContentById(page.Id);
                //page.UnderPage_TitleContents = underPageControllerHelper.GetTitleContentById(page.Id);

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
                var header = context.UnderPages.Where(item => item.Id == underPage.Id).FirstOrDefault().HeaderContent; 
                ViewData["HeaderTheme"] = new SelectList(headerContent, "Id", "HeaderTheme");
                underPage.HeaderContent = controllerHelper.GetHeaderContentByDropDownValue(int.Parse(controllerHelper.CheckDropDownValue(selecterDropDownValue)));
                
                try
                {
                    if (!controllerHelper.DoesAllContentMatch(underPage, user))
                    {
                            controllerHelper.SaveToDb();
                            var oldUnderPage = context
                        .UnderPages
                        .Where(item => item.HeaderContent.Id == header.Id)
                        .FirstOrDefault();
                        if (controllerHelper.ReMatchOrder(oldUnderPage))
                        {
                            controllerHelper.SaveToDb();
                        }
                    }
                    return RedirectToAction("Index", new { dropdownValue = selecterDropDownValue });
                }
                catch(Exception e)
                {
                    Debug.WriteLine(e.Message);
                    return RedirectToAction("Index", new { dropdownValue = selecterDropDownValue });
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
                var page = controllerHelper.GetUnderPageById(underPage.Id);
                //page.im = controllerHelper.GetImgeContentById(page.Id);
                page.TopImage = controllerHelper.GetImgeContentById(page.Id);
                //page.UnderPage_TextContents = controllerHelper.GetTextContentById(page.Id);
                //page.UnderPage_TitleContents = controllerHelper.GetTitleContentById(page.Id);

    
                if (controllerHelper.Remove(page))
                {
                    controllerHelper.SaveToDb();
                }
                if (controllerHelper.ReMatchOrder(page))
                {
                    controllerHelper.SaveToDb();
                }
                return RedirectToAction("Index", new { dropdownValue = page.HeaderContent.Id.ToString() });
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return RedirectToAction("Index");
            }
        }
    }
}
