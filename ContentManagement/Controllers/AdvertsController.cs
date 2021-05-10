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
                {
                    ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd");
                    var adverts = advertControllerHelper.GetAdsByDropDownValue(advertControllerHelper.CheckDropDownValue(null));
                   
                    return View(adverts);
                }
                else
                {
                    ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd", selecterDropDownValue);
                    var adverts = advertControllerHelper.GetAdsByDropDownValue(advertControllerHelper.CheckDropDownValue(selecterDropDownValue));

                    return View(adverts);
                }
                 

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
        public ActionResult Create(List<String> values)
        {
            AdvertControllerHelper advertHelper = new AdvertControllerHelper(context, host);
                try
                {                
                    var newAdvert = advertHelper.CreateNewAdvertData(values);
                    if (newAdvert != null)
                        advertHelper.SaveToDb();
                }
                catch (Exception e)
                {
                Debug.WriteLine(e.Message);
                return Json(Url.Action("Index", "Adverts", new { selecterDropDownValue = "1" }));
                }
            return Json(new { redirectToUrl = Url.Action("Index", "Adverts", new { selecterDropDownValue = advertHelper.CheckDropDownValue(values.ElementAt(3)) }) });
        }

        [HttpGet]
        // GET: AdvertsController/Edit/5
        public ActionResult Edit(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AdvertControllerHelper advertHelper = new AdvertControllerHelper(context, host);
                var advertTypes = advertHelper.GetAllAdvertTypes();
                var advert = advertHelper.GetAdvertById(id);
                advert.AdvertImage = advertHelper.GetImgeContentById(id);
                ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd", advert.TypeOfAdd.Id.ToString());
                return View(advert);
            }
            else
            {
                return Redirect("~/login");
            }
        } 

        // POST: Adverts/Edit/5
        [HttpPost] //AJAX post
        public ActionResult Edit(List<String> values)
        {
            AdvertControllerHelper advertHelper = new AdvertControllerHelper(context, host);
            var advert = advertHelper.GetAdvertsData(values);
            if (values.Count() == 7)
            {
                try
                {
                    if (!advertHelper.DoesAllContentMatch(advert))
                        advertHelper.SaveToDb();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }

           return Json(new { redirectToUrl = Url.Action("Index", "Adverts", new { selecterDropDownValue = advertHelper.CheckDropDownValue(values.ElementAt(3))}) });
        }

        // POST: AdvertsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(AdvertsModel advert,string selecterDropDownValue)
        {
            AdvertControllerHelper advertHelper = new AdvertControllerHelper(context, host);
            try
            {
                if (advertHelper.Remove(advert))
                {
                    advertHelper.SaveToDb();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return RedirectToAction("Index","Adverts", new { selecterDropDownValue = advertHelper.CheckDropDownValue(selecterDropDownValue)});
        }


        [HttpPost]//ajax post
        public void SetImage(string imgsrc, string id, string domain)
        {
            AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context, host);
                TempData["imgsrc"] = imgsrc.Replace(domain, string.Empty);//used in edit and creat action
        }

        [HttpPost]//Ajax Post
        public void UploadImage(IFormFile file, string id)
        {
            AdvertControllerHelper advertHelper = new AdvertControllerHelper(context, host);
            if (advertHelper.UploadImageFile(file))
            {
                advertHelper.SaveToDb();
            }
            if (id != null)//if page is created id is null
            {
                char[] charsToTrim = { '?', 'i', 'd', '=' };
                var advert = advertHelper.GetAdvertById(int.Parse(id.Trim(charsToTrim)));
            }

        }


        [HttpPost]//Ajax Post
        public void DeleteImage(string imgsrc, string id,string domain)
        {
            AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context, host);
            if (advertControllerHelper.DeleteImageFile(imgsrc.Replace(domain, string.Empty)))
                advertControllerHelper.SaveToDb();

            if (id != null)//if page is created id is null
            {
                char[] charsToTrim = { '?', 'i', 'd', '=' };
                var advert = advertControllerHelper.GetAdvertById(int.Parse(id.Trim(charsToTrim)));
            }
        }
    }
}
