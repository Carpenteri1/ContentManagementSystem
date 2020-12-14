using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContentManagement.Data;
using ContentManagement.Models;
using Microsoft.AspNetCore.Http;

namespace ContentManagement.Controllers
{
    public class UserController : Controller
    {
        [Route("admin")]
        public IActionResult Index()
        {
            // MysqlStoreContext context = HttpContext.RequestServices.GetService(typeof(MysqlStoreContext)) as MysqlStoreContext;
            //return View(context.GetListOfUsers());
            return View();
        }
/*
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
            UserModel content = context.FindUser("SELECT * FROM user WHERE Id = ", id);

            if (content == null)
            {
                return RedirectToAction("Index");
            }

            return View(content);
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
            UserModel content = context.FindUser("SELECT * FROM user WHERE Id = ", id);

            if (content == null)
            {
                return RedirectToAction("Index");
            }

            return View(content);
        }



        // POST: TextContentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserModel user)
        {
            MysqlStoreContext context = HttpContext.RequestServices.GetService(typeof(MysqlStoreContext)) as MysqlStoreContext;
            try
            {
                context.Edit($"UPDATE  user SET UserPassword = '{user.UserPassword}', UserName = '{user.UserName}' WHERE Id = {user.Id}", user.Id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message.ToString());
                return View(context.FindTextContent("SELECT * FROM user WHERE Id = ", user.Id));
            }
        }*/
    }
}
