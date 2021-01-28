using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContentManagement.Data;
using ContentManagement.Models.StartPageModels;
using ContentManagement.ControllerHelperClasses;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ContentManagement.Controllers
{
    public class StartPageController : Controller
    {
        private readonly CMSDbContext context;
        private readonly IWebHostEnvironment host;
        public StartPageController(CMSDbContext context,IWebHostEnvironment host) 
        {
            this.host = host;
            this.context = context;
        }

        // GET: StartPages/Edit/5
        public IActionResult Edit()
        {
            if (User.Identity.IsAuthenticated)
            {
                StartPageHelper controllerHelper = new StartPageHelper(context,host);
                var startPage = controllerHelper.FetchStartPageFromDB();
                startPage.StartPage_TitleContents = controllerHelper.FetchAllTitleContentFromDB(startPage);
                startPage.StartPage_TextContents = controllerHelper.FetchAllTextContentFromDB(startPage);
                startPage.StartPage_ImgContents = controllerHelper.FetchAllImgeContentFromDB(startPage);

                if (startPage == null ||
                    startPage.StartPage_TextContents == null ||
                    startPage.StartPage_TitleContents == null ||
                    startPage.StartPage_ImgContents == null)
                {
                    return NotFound();
                }
                return View(startPage);
            }
            else
            {
                return Redirect("~/login");
            }

        }

        // POST: StartPages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(StartPage Page)
        {
            if (ModelState.IsValid)
            {
                if (Page != null)
                {
                    Page.Id = context.StartPages.FirstOrDefault().Id;
                    var titles = context.StartPage_TitleContents.ToList();
                    var text = context.StartPage_TextContents.ToList();
                    var imges = context.StartPage_ImgContents.ToList();
                    StartPageHelper controllerHelper = new StartPageHelper(context,host);
                    var user = context.Users.ToList().Where(item =>item.UserName == User.Identity.Name).FirstOrDefault();

                    try
                    {
                        if (!controllerHelper.DoesAllContentMatch(Page,imges,user) ||
                            !controllerHelper.DoesAllContentMatch(Page, text,user) ||
                            !controllerHelper.DoesAllContentMatch(Page, titles,user))
                            controllerHelper.SaveToDb();      
                        else
                            return RedirectToAction("Edit");

                    }

                    catch (DbUpdateConcurrencyException)
                    {
                        if (!StartPageExists(Page.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }catch(ArgumentNullException)
                    {
                        throw;
                    }
                    catch(Exception )
                    {
                        throw;
                    }

                    return RedirectToAction("Edit");

                }
                else
                {
                    return NotFound();
                }
            }
            return Redirect("~/Content");
        }

        private bool StartPageExists(int id)
        {
            return context.StartPages.Any(e => e.Id == id);
        }

    }
}
