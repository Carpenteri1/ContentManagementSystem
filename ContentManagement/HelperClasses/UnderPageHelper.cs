using ContentManagement.Data;
using ContentManagement.Models.Account;
using ContentManagement.UnderPageModels.PageModel;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.HelperClasses
{
    public class UnderPageHelper
    {
        private readonly CMSDbContext context;
        private readonly IWebHostEnvironment host;

        public UnderPageHelper(CMSDbContext context,IWebHostEnvironment host)
        {
            this.context = context;
            this.host = host;
        }

        public bool DoesAllTextsMatch(UnderPage Page, Users users)
        {
            var DbTexts = context.UnderPages_TextContents.Where(underpage => underpage.Id == Page.Id).FirstOrDefault();
            DbTexts.UnderPage = Page;
            if (DbTexts != null)
            {
                if (DbTexts.UnderPage.Id == Page.Id )
                {
                    if (!DbTexts.TextContent.Equals(Page.UnderPage_TextContents[0].TextContent))//if they dont match, save new content
                    {
                        DbTexts.TextContent = Page.UnderPage_TextContents[0].TextContent.ToString();
                        DbTexts.Edited = DateTime.Now;
                        DbTexts.User = users;
                        DbTexts.UnderPage = Page;
                        context.Update(DbTexts);
                        return true;
                    }
                }
                
            }
            return false;
        }

        public bool DoesAllUnderPageLinkTitleMatch(UnderPage Page, Users users)
        {
            var DbLinkTile = context.UnderPages.Where(underpage => underpage.Id == Page.Id).FirstOrDefault();
                if (DbLinkTile != null)//if they dont match, save new content
                {
                    if (DbLinkTile.LinkTitle != Page.LinkTitle)
                    {
                        DbLinkTile.LinkTitle = Page.LinkTitle.ToString();
                        DbLinkTile.User = users;
                        DbLinkTile.Edited = DateTime.Now;
                        context.Update(DbLinkTile);
                        return true;
                    }
                }
            return false;
        }

        public bool DoesAllTitlesMatch(UnderPage Page, Users user)
        {
            var DbTitle = context.UnderPages_titlecontents.Where(underpage => underpage.Id == Page.Id).FirstOrDefault();
            DbTitle.UnderPage = Page;
            if(DbTitle != null)//if they dont match, save new content
            {
                if (!DbTitle.TextContent.Equals(Page.UnderPage_TitleContents[0].TextContent))//if they dont match, save new content
                {
                    DbTitle.TextContent = Page.UnderPage_TitleContents[0].TextContent.ToString();
                    DbTitle.Edited = DateTime.Now;
                    DbTitle.User = user;
                    DbTitle.UnderPage = Page;
                    context.Update(DbTitle);
                    return true;
                }
            }

            return false;
        }

        public bool DoesAllImagesMatch(UnderPage Page, Users user)
        {
            var DbImages = context.UnderPages_imgcontents.Where(underpage => underpage.Id == Page.Id).FirstOrDefault();
            DbImages.UnderPage = Page;


            if (DbImages != null)
            {
                if (Page.UnderPage_ImgContent[0].File != null)
                {
                    Page.UnderPage_ImgContent[0] = CopyToRootFolder(Page.UnderPage_ImgContent[0]);

                    if (!Page.UnderPage_ImgContent[0].ImgSrc.Equals(DbImages.ImgSrc))//if they dont match, save new content

                    DbImages.ImgSrc = Page.UnderPage_ImgContent[0].ImgSrc;
                    DbImages.User = user;
                    DbImages.Uploaded = DateTime.Now;
                    context.Update(DbImages);
                    return true;
                }
            }
            return false;
        }
        private UnderPage_ImgContents CopyToRootFolder(UnderPage_ImgContents imgContents)
        {
            if (imgContents.File != null)
            {

                string rootPath = host.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(imgContents.File.FileName);
                string extension = Path.GetExtension(imgContents.File.FileName);
                string path = Path.Combine(rootPath + "/Upload/UnderPages/Images/" + fileName + extension);
                string imgUrl = "/Upload/UnderPages/Images/" + fileName + extension;

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


        public UnderPage FetchUnderFromDB(UnderPage page,int id)
        {
            return page = context
                .UnderPages
                .Where(page => page.Id == id)
                .FirstOrDefault();
        }

        public List<UnderPage_TitleContents> FetchAllTitleContentFromDB(UnderPage page,int id)
        {
            return context
                .UnderPages_titlecontents
                .Where(underpage => underpage.UnderPage.Id == page.Id)
                .ToList();
        }

        public List<UnderPage_TextContents> FetchAllTextContentFromDB(UnderPage page,int id)
        {
            return context
                .UnderPages_TextContents
                .Where(underpage => underpage.UnderPage.Id == page.Id)
                .ToList();
        }

        public List<UnderPage_ImgContents> FetchAllImgeContentFromDB(UnderPage page,int id)
        {
            return context
                .UnderPages_imgcontents
                .Where(underpage => underpage.UnderPage.Id == page.Id)
                .ToList();
        }
        public void SaveToDb()
        {
            context.SaveChanges();
        }

    }
}
