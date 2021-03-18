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
        private string dropdownValue = string.Empty;
        private const string LocalHostName = "https://localhost:44398";
        private const string DevHostName = "https://golf.amvdev.se/";

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
                var adverts = new List<AdvertsModel>();
                if (TempData["dropdownValue"] != null)
                {
                    ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd", TempData["dropdownValue"].ToString());
                    adverts = advertControllerHelper.GetAdsByDropDownValue(advertControllerHelper.CheckDropDownValue(TempData["dropdownValue"].ToString()));
                }
                else
                {
                    ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd");
                    adverts = advertControllerHelper.GetAdsByDropDownValue(advertControllerHelper.CheckDropDownValue(null));
                }
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
                    var advertTypes = advertHelper.GetAllAdvertTypes();
                    ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd",selecterDropDownValue);
          
                    if (newAdvert != null)
                    {
                       
                        if (TempData["imgsrc"] != null)
                        {
                            newAdvert.ImgUrl = TempData["imgsrc"].ToString();
                            newAdvert = advertHelper.CreateNewAdvertData(newAdvert, advertHelper.GetUser(User.Identity.Name), advertHelper.CheckDropDownValue(selecterDropDownValue));
                            advertHelper.SaveToDb();
                            TempData["dropdownValue"] = selecterDropDownValue;
                            return Redirect(nameof(Index));
                        } 
                    }

                    ViewData["ImageError"] = "Bild måste finnas";
                    return Redirect(nameof(Create));

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
        public ActionResult Edit(AdvertsModel adverts)
        {
            if (User.Identity.IsAuthenticated)
            {
                AdvertControllerHelper advertHelper = new AdvertControllerHelper(context, host);
                var advertTypes = advertHelper.GetAllAdvertTypes();

            
                var advert = advertHelper.GetAdvertById(adverts.Id);
                ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd", advert.TypeOfAdd.Id.ToString());
                adverts.TypeOfAdd = advertHelper.GetAdvertTypeByDropDownValue(advertHelper.CheckDropDownValue(advert.TypeOfAdd.Id.ToString()));
                return View(advert);
            }
            else
            {
                return Redirect("~/login");
            }
        }

        // POST: AdvertsController/Edit/5
        [HttpPost]
        public ActionResult Edit(AdvertsModel adverts,string selecterDropDownValue)
        {
            AdvertControllerHelper advertHelper = new AdvertControllerHelper(context, host);

            try
            {
                var advertTypes = advertHelper.GetAllAdvertTypes();
                    ViewData["TypeOfAd"] = new SelectList(advertTypes, "Id", "TypeOfAd", selecterDropDownValue);
                    adverts.TypeOfAdd = advertHelper.GetAdvertTypeByDropDownValue(advertHelper.CheckDropDownValue(selecterDropDownValue));
                if (TempData["imgsrc"] != null)
                    adverts.ImgUrl = TempData["imgsrc"].ToString();

                if (!advertHelper.DoesAllContentMatch(adverts,advertHelper.GetUser(User.Identity.Name)))
                {
                    advertHelper.SaveToDb();
                }


                return RedirectToAction("Index", new { dropdownValue = selecterDropDownValue });
            }
            catch(Exception e )
            {
                Debug.WriteLine(e.Message);
                return Redirect(nameof(Index));
            }
        }

        [HttpPost]
        public ActionResult UploadImage(IFormFile file,string id)
        {
            AdvertControllerHelper advertHelper = new AdvertControllerHelper(context, host);
            if (advertHelper.FileManager(file))
            {
                advertHelper.SaveToDb();
            }
            if (id != null)//if page is created id is null
            {
                char[] charsToTrim = { '?', 'i', 'd', '=' };
                return RedirectToAction(nameof(Edit), new { id = int.Parse(id.Trim(charsToTrim)) });
            }
            else
            {

                return RedirectToAction(nameof(Create));
            }

        }


        [HttpPost]
        public ActionResult SetImage(string imgsrc, string id)
        {
            AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context, host);
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
                var advertPage = advertControllerHelper.GetAdvertById(int.Parse(id.Trim(charsToTrim)));
                return RedirectToAction(nameof(Edit), new { id = advertPage.Id});
            }

            return RedirectToAction(nameof(Create));
        }

        [HttpPost]
        public ActionResult DeleteImage(string imgsrc, string id)
        {
            AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context, host);

            if (imgsrc.Contains(LocalHostName))
                imgsrc = imgsrc.Replace(LocalHostName, "");

            if (imgsrc.Contains(DevHostName))
                imgsrc = imgsrc.Replace(DevHostName, "");

            TempData["imgsrc"] = imgsrc;
            if (advertControllerHelper.DeleteImage(imgsrc))
                advertControllerHelper.SaveToDb();

            if (id != null)//if page is created id is null
            {
                char[] charsToTrim = { '?', 'i', 'd', '=' };
                var advert = advertControllerHelper.GetAdvertById(int.Parse(id.Trim(charsToTrim)));
                return RedirectToAction(nameof(Edit), new { id = advert.Id });
            }

            return RedirectToAction(nameof(Create));
        }

        // POST: AdvertsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(AdvertsModel advert)
        {
            AdvertControllerHelper advertControllerHelper = new AdvertControllerHelper(context,host);
            var typeofads = advertControllerHelper.GetAllAdvertTypes();
            var adverts = advertControllerHelper.GetAllAdverts();
            foreach (var s in adverts)
                if (s.Id == advert.Id)
                {
                    advert = s;
                    advert.TypeOfAdd = s.TypeOfAdd;
                }
                  
            try
            {
                if (advertControllerHelper.Remove(advert))
                {
                    advertControllerHelper.SaveToDb();
                }
                TempData["dropdownValue"] = advert.TypeOfAdd.Id;
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
