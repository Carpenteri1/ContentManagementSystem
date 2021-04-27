using ContentManagement.Data;
using ContentManagement.Data.Services;
using ContentManagement.HelperClasses;
using ContentManagement.Models.Adverts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Controllers
{
    public class AdvertsController : Controller
    {
        private CMSDbContext context;
        private readonly IWebHostEnvironment host;

        public AdvertsController(CMSDbContext context, IWebHostEnvironment host)
        {
            this.context = context;
            this.host = host;
        }

        // GET: AdvertsController
        public ActionResult Index(string selecterDropDownValue)
        {
            if (User.Identity.IsAuthenticated)
            {
                AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context, host);
                var advertTypes = advertControllerHelper.GetAllAdvertTypes();
                if(selecterDropDownValue == null)
                    ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd");
                else
                ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd", selecterDropDownValue);
                var adverts = advertControllerHelper.GetAdsByDropDownValue(advertControllerHelper.CheckDropDownValue(null));

                return View(adverts);
            }
            else
            {
                return Redirect("~/login");
            }

        }

        [HttpPost]
        public ActionResult Index(string selecterDropDownValue,int id)
        {
            try
            {
                AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context, host);
                var advertTypes = advertControllerHelper.GetAllAdvertTypes();
                ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd", selecterDropDownValue);
                var adverts = advertControllerHelper.GetAdsByDropDownValue(advertControllerHelper.CheckDropDownValue(selecterDropDownValue));
                return View(adverts);
            }
            catch
            {
                return Redirect(nameof(Index));
            }
        }

        // GET: AdvertsController/Create
        public ActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context, host);
                var advertTypes = advertControllerHelper.GetAllAdvertTypes();
                ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd");
                return View(new AdvertsModel());
            }
            else
            {
                return Redirect("~/login");
            }

        }

        // POST: AdvertsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdvertsModel newAdvert, string selecterDropDownValue)
        {
            if (newAdvert.LinkTitle != null)
            {
                AdvertControllerHelper advertHelper = new AdvertControllerHelper(context,host);
                try
                {
                    newAdvert = advertHelper.CreateNewAdvertData(newAdvert,advertHelper.GetUser(User.Identity.Name),
                        advertHelper.CheckDropDownValue(selecterDropDownValue));

                    if (newAdvert != null)
                        advertHelper.SaveToDb();
                }
                catch(Exception e)
                {
                    return RedirectToAction("Index", new { selecterDropDownValue = selecterDropDownValue });
                }
            }
            return RedirectToAction("Index", new { selecterDropDownValue = selecterDropDownValue });
        }

        [HttpGet]
        // GET: AdvertsController/Edit/5
        public ActionResult Edit(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AdvertControllerHelper advertHelper = new AdvertControllerHelper(context, host);
                var advertTypes = advertHelper.GetAllAdvertTypes();
                var advertImage = advertHelper.GetAdvertImageContentById(id);
                var advert = advertHelper.GetAdvertById(id);
                ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd", advert.TypeOfAdd.Id.ToString());


                advert.Adverts_ImageContents[0] = advertImage;
                return View(advert);
            }
            else
            {
                return Redirect("~/login");
            }
        }

        // POST: Adverts/Edit/5
        [HttpPost]
        public IActionResult Edit(AdvertsModel advert,string selecterDropDownValue)
        {
            AdvertControllerHelper advertHelper = new AdvertControllerHelper(context, host);
            var user = context.Users.Where(item => item.UserName == User.Identity.Name).FirstOrDefault();
            var advertTypes = advertHelper.GetAllAdvertTypes();
            ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd", selecterDropDownValue);

            advert.TypeOfAdd = advertHelper.GetAdvertTypeById(int.Parse(selecterDropDownValue));
            try
            {
                if (!advertHelper.DoesAllContentMatch(advert, user))
                {
                    advertHelper.SaveToDb();
                }

            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                return RedirectToAction("Index", new { selecterDropDownValue = selecterDropDownValue });
            }
            return RedirectToAction("Index", new { selecterDropDownValue = selecterDropDownValue });
        }

        // POST: AdvertsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(AdvertsModel advert)
        {
            AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context,host);
            var advertImageContent = context.adverts_imagecontent.Where(item => item.Advert.Id == advert.Id).FirstOrDefault();
            try
            {
                if (advertControllerHelper.Remove(advert,advertImageContent))
                {
                    advertControllerHelper.SaveToDb();
                }
                return Redirect(nameof(Index));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return Redirect(nameof(Index));
            }
        }
    }
}
