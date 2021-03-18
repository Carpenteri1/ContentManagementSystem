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
using ContentManagement.Models.ImageModels;

namespace ContentManagement.Controllers
{
    public class UnderPageController : Controller
    {

        private readonly CMSDbContext context;
        private const string DefaultDropDownValue = "1";
        private readonly IWebHostEnvironment host;
        private string dropdownValue = string.Empty;
        private const string LocalHostName= "https://localhost:44398";
        private const string DevHostName = "https://golf.amvdev.se/";
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
                var newPage = new UnderPage();
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
                    if (TempData["imgsrc"] != null)
                        newPage.underPageImgSource = TempData["imgsrc"].ToString();
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
        public ActionResult ShowAllImageComponent()
        {
            return ViewComponent("ShowAllImages");
        }

        [HttpPost]//posted with ajax form has references
        public ActionResult UploadFile(IFormFile File,string id)
        {
            UnderPageControllerHelper controllerHelper = new UnderPageControllerHelper(context, host);
            if (controllerHelper.FileManager(File))
            {
                controllerHelper.SaveToDb();
            }
            if(id != null)//if page is created id is null
            {
                char[] charsToTrim = { '?', 'i', 'd', '=' };
                return RedirectToAction(nameof(Edit), new { id = int.Parse(id.Trim(charsToTrim)) });
            }
            else
            {
                
                return RedirectToAction(nameof(Create));
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

        [HttpPost]//Has references check underpage index view
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
        [HttpPost]//Has references check underpage index view
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

        [HttpPost]
        public ActionResult DeleteImage(string imgsrc, string id)
        {
            UnderPageControllerHelper underPageControllerHelper = new UnderPageControllerHelper(context, host);

            if (imgsrc.Contains(LocalHostName))
                imgsrc = imgsrc.Replace(LocalHostName, "");

            if (imgsrc.Contains(DevHostName))
                imgsrc = imgsrc.Replace(DevHostName, "");

            TempData["imgsrc"] = imgsrc;
            if(underPageControllerHelper.DeleteImage(imgsrc))
            underPageControllerHelper.SaveToDb();

            if (id != null)//if page is created id is null
            {
                char[] charsToTrim = { '?', 'i', 'd', '=' };
                var page = underPageControllerHelper.GetUnderPageById(int.Parse(id.Trim(charsToTrim)));
                return RedirectToAction(nameof(Edit), new { id = page.Id });
            }
            return RedirectToAction(nameof(Create));
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
                    
                return View(page);
            }
            else
            {
                return Redirect(Url.Content("~/Login"));
            }
        }


        [HttpPost]//posted by ajax and has references
        public ActionResult SetImage(string imgsrc,string id)
        {
            UnderPageControllerHelper underPageControllerHelper = new UnderPageControllerHelper(context, host);
      
            if (imgsrc.Contains(LocalHostName))
            {
                TempData["imgsrc"] = imgsrc.Replace(LocalHostName, "");
            }
            if (imgsrc.Contains(DevHostName))
            {
                TempData["imgsrc"] = imgsrc.Replace(DevHostName, "");
            }
            if (id != null)//if page is created id is null
            {
                char[] charsToTrim = { '?', 'i', 'd', '=' };
                var page = underPageControllerHelper.GetUnderPageById(int.Parse(id.Trim(charsToTrim)));
                return RedirectToAction(nameof(Edit), new { id = page.Id });
            }
            return RedirectToAction(nameof(Create));
       
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
                if(TempData["imgsrc"] != null)
                underPage.underPageImgSource = TempData["imgsrc"].ToString();

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
