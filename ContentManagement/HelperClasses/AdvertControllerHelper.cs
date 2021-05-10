using ContentManagement.Data;
using ContentManagement.Data.Services;
using ContentManagement.Models.Account;
using ContentManagement.Models.Adverts;
using ContentManagement.Models.FilesModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        private const string ToFolder = "/Upload/Sponsors/";


        public AdvertControllerHelper(CMSDbContext context, IWebHostEnvironment host) 
        {
            this.context = context;
            this.host = host;
        }
        public AdvertsModel CreateNewAdvertData(List<string> values)
        {
            var newAdvert = new AdvertsModel
            {
                LinkTitle = values.ElementAt(0),
                LinkTo = values.ElementAt(1),
                isActive = Convert.ToBoolean(values.ElementAt(2)),
            };
            var advertType = GetAdvertTypeByDropDownValue(CheckDropDownValue(values.ElementAt(3))); //element 3 is dropdown value
            //var allAds = GetAllAdverts();
            if(advertType != null)
                newAdvert.TypeOfAdd = advertType;

            newAdvert.AdvertImage = PopulateImg(values.ElementAt(4).Replace(values.ElementAt(5),""));//element 5 removes location.origin from the img string
            context.Add(newAdvert);
            return newAdvert;
        }

        public AdvertsModel GetAdvertsData(List<string> values)
        {
            var newAdvert = new AdvertsModel
            {
                LinkTitle = values.ElementAt(0),
                LinkTo = values.ElementAt(1),
                isActive = Convert.ToBoolean(values.ElementAt(2)),
                Id = int.Parse(values.ElementAt(6)),
            };
            var advertType = GetAdvertTypeById(int.Parse(values.ElementAt(3)));
            if (advertType != null)
                newAdvert.TypeOfAdd = advertType;

            newAdvert.AdvertImage = GetImage(values.ElementAt(4).Replace(values.ElementAt(5), ""));//element 5 removes location.origin from the img string
            return newAdvert;
        }

        private AdvertImageGallery GetImage(string imgsrc)
        {
            var newImage = context.AdvertImageGallery.Where(img => img.ImgSrc == imgsrc).FirstOrDefault();
            return newImage;
        }

        private AdvertImageGallery PopulateImg(string imgsrc)
        {
            var newImage = context.AdvertImageGallery.Where(img => img.ImgSrc == imgsrc).FirstOrDefault();
            if(newImage == null)
            {
                newImage = new AdvertImageGallery();
                newImage.ImgSrc = imgsrc;
                context.Add(newImage);
            }
                   
            return newImage;
        }


        public AdvertType GetAdvertTypeByDropDownValue(string selectDropDownValue)
        {
           return context.AdvertTypes.Where(item => item.Id == int.Parse(selectDropDownValue)).First();
        }

        public List<AdvertsModel> GetAdsByDropDownValue(string selecterDropDownValue)
        {
           return context.Adverts.Where(s => s.TypeOfAdd.Id == int.Parse(selecterDropDownValue)).ToList();
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
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            return true;
        }


        public List<AdvertImageGallery> GetAdvertImages()
        {
            return context.AdvertImageGallery.ToList();
        }



        public bool DoesAllContentMatch(AdvertsModel advert)
        {
            bool match = true;
            var allAdvertsType = GetAllAdvertTypes();
            var advertImages = GetAdvertImages();
            var Dbadverts = GetAdvertById(advert.Id);
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
                if (Dbadverts.TypeOfAdd != null)
                {
                    if (Dbadverts.TypeOfAdd.TypeOfAd != advert.TypeOfAdd.TypeOfAd)
                    {
                        Dbadverts.TypeOfAdd = advert.TypeOfAdd;
                        context.Update(Dbadverts);
                        match = false;
                    }
                }
                if(Dbadverts.AdvertImage != null)
                {
                    if (Dbadverts.AdvertImage.ImgSrc != advert.AdvertImage.ImgSrc)
                    {
                        Dbadverts.AdvertImage = GetImage(advert.AdvertImage.ImgSrc);
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


        public AdvertImageGallery GetImgeContentById(int Id)
        {
            return context.Adverts.Where(item => item.Id == Id)
                .Select(item => item.AdvertImage).FirstOrDefault();
        }
        
        public bool DeleteImageFile(string imageName)
        {
            FileManager filemanager = new FileManager(context,host);
            return filemanager.DeleteAdvertImage(imageName);
        }

        public bool UploadImageFile(IFormFile file)
        {
            var filemanager = new FileManager(context, host);
            return filemanager.UploadAdvertImage(file,ToFolder);
        }
    }
}
