using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContentManagement.Data;
using ContentManagement.Models.StartPage;
using ContentManagement.ControllerHelperClasses;

namespace ContentManagement.Controllers
{
    public class StartPageController : Controller
    {
        private readonly CMSDbContext context;
        public StartPageController(CMSDbContext context)
        {
            this.context = context;
        }

        // GET: StartPages/Edit/5
        public IActionResult Edit()
        {
            if (User.Identity.IsAuthenticated)
            {
                StartPageControllerHelper controllerHelper = new StartPageControllerHelper(context);
                var startPage = controllerHelper.FetchStartPageFromDB();
                startPage.StartPage_TitleContents = controllerHelper.FetchAllTitleContentFromDB(startPage);
                startPage.StartPage_TextContents = controllerHelper.FetchAllTextContentFromDB(startPage);

                if (startPage == null ||
                    startPage.StartPage_TextContents == null ||
                    startPage.StartPage_TitleContents == null)
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
                    var titles = context.StartPage_TitleContents.ToList();
                    var text = context.StartPage_TextContents.ToList();
                    StartPageControllerHelper controllerHelper = new StartPageControllerHelper(context);

                    try
                    {
                        if (!controllerHelper.DoesAllTextContentMatch(Page, text) ||
                            !controllerHelper.DoesAllTitleContentMatch(Page, titles))
                             controllerHelper.SaveToDb();
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
