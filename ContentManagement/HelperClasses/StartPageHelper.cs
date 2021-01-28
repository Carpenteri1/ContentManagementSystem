using ContentManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.StartPageModels;
using ContentManagement.Models.HeaderModels;
using ContentManagement.Models.Account;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace ContentManagement.ControllerHelperClasses
{
    public class StartPageHelper
    {
        private readonly CMSDbContext context;
        private readonly IWebHostEnvironment host;

        public StartPageHelper(CMSDbContext context,IWebHostEnvironment host)
        {
            this.context = context;
            this.host = host;
        }

        public bool DoesAllContentMatch(StartPage Page, List<StartPage_TextContents> text,Users users)
        {

            for (int i = 0; i < Page.StartPage_TextContents.Count(); i++)
            {
                if (!text[i].TextContent.Equals(Page.StartPage_TextContents[i].TextContent))//if they dont match, save new content
                {
                        text[i].TextContent = Page.StartPage_TextContents[i].TextContent.ToString();
                        text[i].Edited = DateTime.Now;
                        text[i].User = users;
                        context.Update(text[i]);
                        return false;
                }
            }
            return true;
        }

        public bool DoesAllContentMatch(StartPage Page,List<StartPage_TitleContents> titles,Users user)
        {

            for (int i = 0; i < Page.StartPage_TitleContents.Count(); i++)
            {
                if (!titles[i].TextContent.Equals(Page.StartPage_TitleContents[i].TextContent))//if they dont match, save new content
                {
                        titles[i].TextContent = Page.StartPage_TitleContents[i].TextContent.ToString();
                        titles[i].Edited = DateTime.Now;
                        titles[i].User = user;
                        context.Update(titles[i]);
                        return false;
                }
            }

            return true;
        }

        public bool DoesAllContentMatch(StartPage Page, List<StartPage_ImgContents> imges,Users user)
        {

            for (int i = 0; i < Page.StartPage_ImgContents.Count(); i++)
            {
                if (Page.StartPage_ImgContents[i].File != null)
                {
                    Page = CopyToRootFolder(Page);

                    if (!Page.StartPage_ImgContents[i].ImgSrc.Equals(imges[i].ImgSrc))//if they dont match, save new content
                    {
                        imges[i].ImgSrc = Page.StartPage_ImgContents[i].ImgSrc;
                        imges[i].User = user;
                        imges[i].Uploaded = DateTime.Now;
                        context.Update(imges[i]);
                    }
                    else
                    {
                        DoesAllContentMatch(Page, imges, user);
                    }
                }

            }

            return false;
        }


        private StartPage CopyToRootFolder(StartPage Page)
        {
            for(int i = 0; i < Page.StartPage_ImgContents.Count(); i++)
            {
                if (Page.StartPage_ImgContents[i].File != null)
                {
     
                    string rootPath = host.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(Page.StartPage_ImgContents[i].File.FileName);
                    string extension = Path.GetExtension(Page.StartPage_ImgContents[i].File.FileName);
                    string path = Path.Combine(rootPath + "/Upload/StartPage/" + fileName + extension);
                    string imgUrl = "/Upload/StartPage/" + fileName + extension;

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        Page.StartPage_ImgContents[i].File.CopyTo(fileStream);
                    }
                    Page.StartPage_ImgContents[i].ImgSrc = imgUrl;
                }
            }
            return Page;
        }

        public StartPage FetchStartPageFromDB()
        {
            var startpage = context.StartPages.First();
            return startpage;
        }

        public List<StartPage_TitleContents> FetchAllTitleContentFromDB(StartPage startPage)
        {
            return startPage.StartPage_TitleContents = context
                .StartPage_TitleContents
                .ToList();
        }

        public List<StartPage_TextContents> FetchAllTextContentFromDB(StartPage startPage)
        {
            return startPage.StartPage_TextContents = context
                    .StartPage_TextContents
                    .ToList();
        }

        public List<StartPage_ImgContents> FetchAllImgeContentFromDB(StartPage startPage)
        {
            return startPage.StartPage_ImgContents = context
                    .StartPage_ImgContents
                    .ToList();
        }

        public void SaveToDb()
        {
            context.SaveChanges();
        }
    }
}
