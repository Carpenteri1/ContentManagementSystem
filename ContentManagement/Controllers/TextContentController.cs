using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContentManagement.Models.ContentManagement;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Authorization;

namespace ContentManagement.Controllers
{
    [BindProperties]
    [Authorize]
    public class TextContentController : Controller
    {
        private readonly CMSDbContext context;

        public TextContentController(CMSDbContext context)
        {
            this.context = context;
        }

        // GET: TextContentController
        public async Task<IActionResult> Index()
        {
            return View(await context.Content.ToListAsync());
        }
       
        // GET: TextContentController/Details/5
        public IActionResult Details(int? id)
        {
            return View(context.Content.Find(id));
        }

            // GET: TextContentController/Create
        public ActionResult Create()
        {            
             return View();
            
        }

        // POST: TextContentController/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(TextContentModel newTextContent)
        {
            if (User.Identity.IsAuthenticated)
            {
                try
                {
                    context.Add(newTextContent);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            else
            {
              return  Redirect("/Login");
            }
          
        }

        // GET: TextContentController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            TextContentModel grabTextContent = context.Content.Find(id);

            if (grabTextContent == null)
            {
                return RedirectToAction("Index");
            }
            context.Remove(grabTextContent);
            context.SaveChanges();
            return View(grabTextContent);
        }

        // POST: TextContentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TextContentModel textContentModel)
        {
            try
            {
                context.Add(textContentModel);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: TextContentController/Delete/5
        public ActionResult Delete(int? id)
        {
            try
            {
                var content = context.Users.Find(id);
                return View(content);
            }
            catch
            {
                return View();
            }
          
        }

        // POST: TextContentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(TextContentModel content)
        {
            try
            {
                context.Content.Remove(content);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
