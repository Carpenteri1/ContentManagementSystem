using ContentManagement.Data;
using ContentManagement.Data.Services;
using ContentManagement.Models.Account;
using ContentManagement.Models.Adverts;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.HelperClasses
{
    public class AdvertControllerHelper
    {
        private readonly IWebHostEnvironment host;
        private readonly CMSDbContext context;
        private const int PlusOne = 1;
        private const string DefaultDropDownValue = "1";
        private const string ToFolder = "/Upload/Extra/";


        public AdvertControllerHelper(CMSDbContext context, IWebHostEnvironment host)
        {
            this.context = context;
            this.host = host;
        }
        public AdvertsModel CreateNewAdvertData(AdvertsModel newAd, Users user, string selectDropDownValue)
        {
            var advertType = GetAdvertTypeByDropDownValue(selectDropDownValue); 
            var allAds = GetAllAdverts();
            newAd = PopulateImg(newAd);

            if (advertType != null &&
                user != null)
            {
                newAd.TypeOfAdd = advertType;
                newAd.Id = allAds.Last().Id + PlusOne;
                newAd.User = user;
                context.Add(newAd);
            }

            return newAd;
        }

        private AdvertsModel PopulateImg(AdvertsModel newAd)
        {
            FileManager manager = new FileManager(context, host);
            newAd.ImgUrl = manager.CopyToRootFolder(newAd.File, ToFolder);
            newAd.Uploaded = DateTime.Now;
            return newAd;
        }


        public AdvertType GetAdvertTypeByDropDownValue(string selectDropDownValue)
        {
           return context.AdvertTypes.Where(item => item.Id == int.Parse(selectDropDownValue)).First();
        }

        public List<AdvertsModel> GetAdsByDropDownValue(string selecterDropDownValue)
        {
           return context.Adverts.Where(s => s.TypeOfAdd.Id == int.Parse(selecterDropDownValue)).ToList();
        }

        public Users GetUser(string nameof)
        {
           return context.Users.Where(user => user.UserName == nameof).FirstOrDefault();
        }

        public AdvertsModel GetAdvertById(int id)
        {
            return context.Adverts.Where(item => item.Id == id).FirstOrDefault();
        }


        public List<AdvertsModel> GetAllAdverts()
        {
            return context.Adverts.ToList();
        }

        public AdvertType GetAdvertTypeById(int id)
        {
            return context.AdvertTypes.Where(item => item.AdvertsModel[0].Id == id).FirstOrDefault();
        }


        public List<AdvertType> GetAllAdvertTypes()
        {
            return context.AdvertTypes.ToList(); 
        }

        public string CheckDropDownValue(string selecterDropDownValue)
        {
            if (selecterDropDownValue == null)
            {
                selecterDropDownValue = DefaultDropDownValue;
            }
            return selecterDropDownValue;
        }

        public bool SaveToDb()
        {
            try
            {
                context.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DoesAllImageContentMatch(AdvertsModel advert)
        {
            var DbAdvert = context
             .Adverts
             .Where(item => item.Id == advert.Id)
             .FirstOrDefault();

            if (DbAdvert != null)
            {
                if (advert.File != null)
                {
                    FileManager manages = new FileManager(context, host);
                    advert.ImgUrl = manages.CopyToRootFolder(advert.File, ToFolder);

                    if (!advert.ImgUrl.Equals(DbAdvert.ImgUrl))
                    {
                        DbAdvert.ImgUrl = advert.ImgUrl;
                        DbAdvert.Uploaded = DateTime.Now;
                        context.Update(DbAdvert);
                        return false;
                    }
                }
            }
            return true;
        }


        public bool DoesAllContentMatch(AdvertsModel advert)
        {
            var Dbadverts = GetAdvertById(advert.Id);
            bool match = true;
            if (Dbadverts != null)//if they dont match, save new content
            {
                if (Dbadverts.LinkTitle != null)
                {
                    if (Dbadverts.LinkTitle != advert.LinkTitle)
                    {
                        Dbadverts.LinkTitle = advert.LinkTitle;
                        context.Update(Dbadverts);
                        match = false;
                    }
                }
                if(Dbadverts.LinkTo != null)
                {
                    if (Dbadverts.LinkTo != advert.LinkTo)
                    {
                        Dbadverts.LinkTo = advert.LinkTo;
                        context.Update(Dbadverts);
                        match = false;
                    }
                }
                if (Dbadverts.isActive != advert.isActive)
                {
                    Dbadverts.isActive = advert.isActive;
                    context.Update(Dbadverts);
                    match = false;
                }
                if (advert.File != null)
                {
                    FileManager manages = new FileManager(context, host);
                    advert.ImgUrl = manages.CopyToRootFolder(advert.File, ToFolder);

                    if (!advert.ImgUrl.Equals(Dbadverts.ImgUrl))
                    {
                        Dbadverts.ImgUrl = advert.ImgUrl;
                        Dbadverts.Uploaded = DateTime.Now;
                        context.Update(Dbadverts);
                        match = false;
                    }
                }
                if (Dbadverts.TypeOfAdd != null)
                {
                    if (Dbadverts.TypeOfAdd != advert.TypeOfAdd)
                    {
                        Dbadverts.TypeOfAdd = advert.TypeOfAdd;
                        context.Update(Dbadverts);
                        match = false;
                    }
                }
            }
            return match;
        }

        public bool Remove(AdvertsModel advert)
        {
            try
            {
                context.Remove(advert);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
