using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContentManagement.Models.ContentManagement;

namespace ContentManagement.Controllers
{
    [BindProperties]
    public class TextContentController : Controller
    {
        // GET: TextContentController
        [Route("text")]
        public ActionResult Index()
        {
            MysqlStoreContext context = HttpContext.RequestServices.GetService(typeof(MysqlStoreContext)) as MysqlStoreContext;
            return View(context.GetListOfTextContent());
        }
        
        // GET: TextContentController/Details/5
        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Index");
            }

            MysqlStoreContext context = 
                HttpContext.RequestServices.GetService(typeof(MysqlStoreContext)) 
                as MysqlStoreContext;
            TextContentModel grabTextContent = context.FindTextContent("SELECT * FROM textcontent WHERE Id = ", id);

            if (grabTextContent == null)
            {
                return RedirectToAction("Index");
            }

            return View(grabTextContent);
        }

            // GET: TextContentController/Create
        public ActionResult Create()
        {            
             return View();
            
        }

        // POST: TextContentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TextContentModel newTextContent)
        {
            try
            {
                MysqlStoreContext context = HttpContext.RequestServices.GetService(typeof(MysqlStoreContext)) as MysqlStoreContext;
                context.Add(newTextContent);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TextContentController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            MysqlStoreContext context =
                HttpContext.RequestServices.GetService(typeof(MysqlStoreContext))
                as MysqlStoreContext;
            TextContentModel grabTextContent = context.FindTextContent("SELECT * FROM textcontent WHERE Id = ", id);

            if (grabTextContent == null)
            {
                return RedirectToAction("Index");
            }

            return View(grabTextContent);
        }

        // POST: TextContentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TextContentModel textContentModel)
        {
            MysqlStoreContext context = HttpContext.RequestServices.GetService(typeof(MysqlStoreContext)) as MysqlStoreContext;
            try
            {
                context.Edit($"UPDATE  textcontent SET Content = '{textContentModel.Content}',Name = '{textContentModel.ContentName}' WHERE Id = ",textContentModel.Id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message.ToString());
                return View(context.FindTextContent("SELECT * FROM textcontent WHERE Id = ", textContentModel.Id));
            }
        }

        // GET: TextContentController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            MysqlStoreContext context =
                HttpContext.RequestServices.GetService(typeof(MysqlStoreContext))
                as MysqlStoreContext;
            TextContentModel grabTextContent = context.FindTextContent("SELECT * FROM textcontent WHERE Id = ",id);
            
            if (grabTextContent == null)
            {
                return RedirectToAction("Index");
            }


            return View(grabTextContent);
        }

        // POST: TextContentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            MysqlStoreContext context = HttpContext.RequestServices.GetService(typeof(MysqlStoreContext)) as MysqlStoreContext;
            try
            {
                context.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(context.FindTextContent("SELECT * FROM textcontent WHERE Id = ", id));
            }
        }
    }
}
