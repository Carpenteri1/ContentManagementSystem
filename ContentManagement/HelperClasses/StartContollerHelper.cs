using ContentManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.StartPageModels.PageModel;
using ContentManagement.Models.Account;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;


namespace ContentManagement.ControllerHelperClasses
{
    public class StartContollerHelper
    {
        private readonly CMSDbContext context;
        private readonly IWebHostEnvironment host;

        public StartContollerHelper(CMSDbContext context,IWebHostEnvironment host)
        {
            this.context = context;
            this.host = host;
        }

        public bool DoesAllContentMatch(StartPage page, Users user)
        {
            bool match = true;

            if (!DoesAllImagesMatch(page, user))
                match = false;
            if (!DoesAllTextsMatch(page,user))
                match = false;
            if (!DoesAllTitlesMatch(page,user))
                match = false;
            if (!DoesAllLinksContentMatch(page,user))
                match = false;

            return match;
        }

        private bool DoesAllTextsMatch(StartPage Page,Users user)
        {
            List<StartPage_TextContents> DbTexts = context.StartPage_TextContents.ToList();
            bool match = true;
            for (int i = 0; i < Page.StartPage_TextContents.Count(); i++)
            {
                if (DbTexts[i].TextContent != Page.StartPage_TextContents[i].TextContent)//if they dont match, save new content
                {
                    DbTexts[i].TextContent = Page.StartPage_TextContents[i].TextContent.ToString();
                    DbTexts[i].Edited = DateTime.Now;
                    match = false;
                    if(DbTexts[i].User.UserName != user.UserName)
                    {
                        DbTexts[i].User = user;
                    }
                   
                        context.Update(DbTexts[i]);
                }
            }
            return match;
        }

        private bool DoesAllTitlesMatch(StartPage Page,Users user)
        {
            List<StartPage_TitleContents> DbTitles = context.StartPage_TitleContents.ToList();
            bool match = true;
            for (int i = 0; i < Page.StartPage_TitleContents.Count(); i++)
            {
                if (DbTitles[i].TextContent != Page.StartPage_TitleContents[i].TextContent)//if they dont match, save new content
                {
                    match = false;
                    DbTitles[i].TextContent = Page.StartPage_TitleContents[i].TextContent.ToString();
                    DbTitles[i].Edited = DateTime.Now;
                    if (DbTitles[i].User.UserName != user.UserName)
                    {
                        DbTitles[i].User = user;
                    }
                    match = false;
                    context.Update(DbTitles[i]);
                }
            }

            return match;
        }

        public Users GetUserByName(string nameof)
        {
            return context.Users.Where(item => item.UserName == nameof).FirstOrDefault();
        }

        private bool DoesAllLinksContentMatch(StartPage Page, Users user)
        {
            List<StartPage_Links> DbLinkContent = context.StartPage_Links.ToList();
            bool match = true;
            for (int i = 0; i < Page.StartPage_TitleContents.Count(); i++)
            {
                if (DbLinkContent[i].Url != Page.StartPage_Links[i].Url)//if they dont match, save new content
                {
                    match = false;
                    DbLinkContent[i].Url = Page.StartPage_Links[i].Url.ToString();
                    DbLinkContent[i].Edited = DateTime.Now;
                    DbLinkContent[i].User = user;
                    if (DbLinkContent[i].User.UserName != user.UserName)
                    {
                        DbLinkContent[i].User = user;
                    }
                    context.Update(DbLinkContent[i]);
                }
            }

            return match;
        }


        private bool DoesAllImagesMatch(StartPage Page,Users user)
        {
            List<StartPage_ImgContents> DbImages = context.StartPage_ImgContents.ToList();
            bool match = true;
            for (int i = 0; i < Page.StartPage_ImgContents.Count(); i++)
            {
                if (Page.StartPage_ImgContents[i].File != null)
                {
                    Page.StartPage_ImgContents[i] = CopyToRootFolder(Page.StartPage_ImgContents[i]);

                    if (Page.StartPage_ImgContents[i].ImgSrc != DbImages[i].ImgSrc)//if they dont match, save new content
                    {
                        match = false;
                        DbImages[i].ImgSrc = Page.StartPage_ImgContents[i].ImgSrc;
                        if (DbImages[i].User.UserName != user.UserName)
                        {
                            DbImages[i].User = user;
                        }
                        DbImages[i].Uploaded = DateTime.Now;
                        context.Update(DbImages[i]);
                    }
                }

            }

            return match;
        }


        private StartPage_ImgContents CopyToRootFolder(StartPage_ImgContents imgContents)
        {
            if (imgContents.File != null)
            {

                string rootPath = host.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(imgContents.File.FileName);
                string extension = Path.GetExtension(imgContents.File.FileName);
                string path = Path.Combine(rootPath + "/Upload/StartPage/Images/" + fileName + extension);
                string imgUrl = "/Upload/StartPage/Images/" + fileName + extension;

                if (!File.Exists(path))
                {
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        imgContents.File.CopyTo(fileStream);
                    }
            
                }

                imgContents.ImgSrc = imgUrl;
                return imgContents;
            }
            return imgContents;

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
        public List<StartPage_Links> FetchAllLinksContentFromDB(StartPage startPage)
        {
            return startPage.StartPage_Links = context
                    .StartPage_Links
                    .ToList();
        }
        public void SaveToDb()
        {
            context.SaveChanges();
        }
    }
}
