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
                    newAd.Adverts_ImageContents[0].User = user;
                    context.Add(newAd);
            }

            return newAd;
        }

        private AdvertsModel PopulateImg(AdvertsModel newAd)
        {
            if (newAd.Adverts_ImageContents[0].File != null)
            {
                FileManager manager = new FileManager(context, host);
                newAd.Adverts_ImageContents[0].ImgSrc = manager.CopyToRootFolder(newAd.Adverts_ImageContents[0].File, ToFolder);
          
            }
            else
            {
                newAd.Adverts_ImageContents[0].ImgSrc ="\"\"";
            }
            newAd.ImgUrl = newAd.Adverts_ImageContents[0].ImgSrc;
            newAd.Adverts_ImageContents[0].Uploaded = DateTime.Now;
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
            return context.AdvertTypes.Where(item => item.Id == id).FirstOrDefault();
        }

        public Adverts_ImageContent GetAdvertImageContentById(int id)
        {
            return context.adverts_imagecontent.Where(item => item.Advert.Id == id).FirstOrDefault();
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



        public bool DoesAllContentMatch(AdvertsModel advert,Users user)
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
                if (advert.Adverts_ImageContents[0].File != null)
                {
                    FileManager manages = new FileManager(context, host);
                    advert.Adverts_ImageContents[0].ImgSrc = manages.CopyToRootFolder(advert.Adverts_ImageContents[0].File, ToFolder);
                    advert.ImgUrl = advert.Adverts_ImageContents[0].ImgSrc;

                    if (!advert.ImgUrl.Equals(Dbadverts.ImgUrl))
                    {
                        advert.Adverts_ImageContents[0].Uploaded = DateTime.Now;
                        Dbadverts.ImgUrl = advert.ImgUrl;
                        Dbadverts.Uploaded = advert.Uploaded;
                        var DbadvertImageContent = context.adverts_imagecontent.Where(item => item.Advert.Id == advert.Id).FirstOrDefault();
                        DbadvertImageContent.ImgSrc = advert.ImgUrl;
                        DbadvertImageContent.Uploaded = advert.Uploaded;
                        DbadvertImageContent.User = Dbadverts.User;

                        context.Attach(DbadvertImageContent);
                        context.Attach(Dbadverts);
                        context.Update(DbadvertImageContent);
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
                if(Dbadverts.User != null)
                {
                    if (Dbadverts.User.UserName != user.UserName)
                    {
                        Dbadverts.User = user;
                        context.Update(Dbadverts);
                    }
                }
           
            }
            return match;
        }

        public bool Remove(AdvertsModel advert,Adverts_ImageContent adverts_ImageContent)
        {
            try
            {
                context.Attach(adverts_ImageContent);
                context.Attach(advert);
                context.Remove(advert);
                context.Remove(adverts_ImageContent);
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
