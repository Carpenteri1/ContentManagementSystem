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
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context, host);
                var advertTypes = advertControllerHelper.GetAllAdvertTypes();
                ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd");
                var adverts = advertControllerHelper.GetAdsByDropDownValue(advertControllerHelper.CheckDropDownValue(null));

                return View(adverts);
            }
            else
            {
                return Redirect("~/login");
            }

        }

        [HttpPost]
        public ActionResult Index(string selecterDropDownValue)
        {
            try
            {
                AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context, host);
                var advertTypes = advertControllerHelper.GetAllAdvertTypes();
                ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd");
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
                    newAdvert = advertHelper.CreateNewAdvertData(newAdvert,advertHelper.GetUser(User.Identity.Name),advertHelper.CheckDropDownValue(selecterDropDownValue));
                    if (newAdvert != null)
                        advertHelper.SaveToDb();
                   
                    return RedirectToAction(nameof(Index));

                }
                catch
                {
                    return Redirect(nameof(Create));
                }
            }
            else
            {
                return Redirect(nameof(Create));
            }

         
        }

        [HttpGet]
        // GET: AdvertsController/Edit/5
        public ActionResult Edit(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AdvertControllerHelper advertHelper = new AdvertControllerHelper(context, host);
                var advertTypes = advertHelper.GetAllAdvertTypes();
                ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd");
                var advert = advertHelper.GetAdvertById(id);

                return View(advert);
            }
            else
            {
                return Redirect("~/login");
            }
        }

        // POST: AdvertsController/Edit/5
        [HttpPost]
        public ActionResult Edit(AdvertsModel adverts, string selecterDropDownValue)
        {
            AdvertControllerHelper advertHelper = new AdvertControllerHelper(context, host);
            try
            {
                var advertTypes = advertHelper.GetAllAdvertTypes();
                ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd");
                adverts.TypeOfAdd = advertHelper.GetAdvertTypeByDropDownValue(advertHelper.CheckDropDownValue(selecterDropDownValue));


                if (!advertHelper.DoesAllContentMatch(adverts))
                {
                    adverts.User = advertHelper.GetUser(User.Identity.Name);
                    advertHelper.SaveToDb();
                }


                return RedirectToAction("Edit", new { id = adverts.Id });
            }
            catch(Exception e )
            {
                Debug.WriteLine(e.Message);
                return Redirect(nameof(Index));
            }
        }

        // GET: AdvertsController/Delete/5
        public ActionResult Delete(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context,host);
                var advert = advertControllerHelper.GetAdvertById(id);
          
                if (advert != null)
                {
                    return View(advert);
                }
                else
                {
                    return Redirect(nameof(Index));
                }
           
            }
            else
            {
                return Redirect("~/login");
            }
 
        }

        // POST: AdvertsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(AdvertsModel advert)
        {
            AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context,host);
            try
            {
                if (advertControllerHelper.Remove(advert))
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
            return Redirect(nameof(Index));
        }
    }
}
