﻿using ContentManagement.Data;
using ContentManagement.Data.Services;
using ContentManagement.Models.Account;
using ContentManagement.StartPageModels.PageModel;
using ContentManagement.UnderPageModels.PageModel;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.HelperClasses
{
    public class UnderPageControllerHelper
    {
        private readonly CMSDbContext context;
        private readonly IWebHostEnvironment host;
        private const int PlusOne = 1;
        private const string ToFolder = "/Upload/UnderPages/Images/";
        public UnderPageControllerHelper(CMSDbContext context,IWebHostEnvironment host)
        {
            this.context = context;
            this.host = host;
        }

        private UnderPage PopulateImageContent(UnderPage newPage,Users user)
        {
            FileManager manager = new FileManager(context,host);
            newPage.UnderPage_ImgContent[0].ImgSrc = manager.CopyToRootFolder(newPage.UnderPage_ImgContent[0].File, ToFolder);
            newPage.UnderPage_ImgContent[0].UnderPage = newPage;
            newPage.UnderPage_ImgContent[0].Uploaded = DateTime.Now;
            newPage.UnderPage_ImgContent[0].User = user;

            return newPage;
        }

        private UnderPage PopulateTextContent(UnderPage newPage, Users user)
        {
            if (newPage.UnderPage_TextContents[0].TextContent == null)
            {
                newPage.UnderPage_TextContents[0] = new UnderPage_TextContents
                {
                    TextContent = string.Empty,
                    UnderPage = newPage,
                    Created = DateTime.Now,
                    User = user   
                };

                return newPage;
            }
            else
            {
                newPage.UnderPage_TextContents[0] = new UnderPage_TextContents
                {
                    TextContent = newPage.UnderPage_TextContents[0].TextContent,
                    UnderPage = newPage,
                    Created = DateTime.Now,
                    User = user
                };


                return newPage;
            }
        }


        private UnderPage PopulateTitleContent(UnderPage newPage, Users user)
        {
            if (newPage.UnderPage_TitleContents[0].TextContent == null)
            {
                newPage.UnderPage_TitleContents[0] = new UnderPage_TitleContents
                {
                    TextContent = string.Empty,
                    UnderPage = newPage,
                    Created = DateTime.Now,
                    User = user
                };

                return newPage;
            }
            else
            {

                newPage.UnderPage_TitleContents[0] = new UnderPage_TitleContents
                {
                    TextContent = newPage.UnderPage_TitleContents[0].TextContent,
                    UnderPage = newPage,
                    Created = DateTime.Now,
                    User = user
                };

                return newPage;
            }
        }

        private UnderPage AddStartPageFk(UnderPage newPage)
        {
            newPage.StartPage = context.StartPages.FirstOrDefault();
            return newPage;
        }

        public UnderPage CreateNewPageData(UnderPage newPage, Users user, int dropdownValue)
        {
            var headercontent = context.HeaderContent.Where(header => header.Id == dropdownValue).First();
            var underpages = context.UnderPages.ToList();

            newPage = PopulateImageContent(newPage,user);
            newPage = PopulateTextContent(newPage,user);
            newPage = PopulateTitleContent(newPage,user);
            newPage = AddStartPageFk(newPage);


             if (headercontent != null &&
                 user != null)
             {
                 newPage.HeaderContent = headercontent;
                 newPage.Id = underpages.Last().Id + PlusOne;
                 newPage.User = user;

                 context.Add(newPage);

             }

             return newPage;  
        }


        public bool DoesAllTextsMatch(UnderPage Page, Users users)
        {
            var DbTexts = context.UnderPages_TextContents.Where(item  => item.UnderPage.Id  == Page.Id).FirstOrDefault();
            if (DbTexts != null)
            {
                if (Page.UnderPage_TextContents[0].TextContent != null)
                {
                    if (DbTexts.TextContent != Page.UnderPage_TextContents[0].TextContent)//if they dont match, save new content
                    {
                     
                            DbTexts.TextContent = Page.UnderPage_TextContents[0].TextContent;
                            DbTexts.Edited = DateTime.Now;
                            context.Update(DbTexts);
                            return false;
                        }
                    }
              
            }
            return true;
        }

        public bool DoesAllUnderPageLinkTitleMatch(UnderPage Page, Users users)
        {
            var DbLinkTile = context.UnderPages.Where(underpage => underpage.Id == Page.Id).FirstOrDefault();
            if (DbLinkTile != null)//if they dont match, save new content
            {
                if (DbLinkTile.LinkTitle != null)
                {
                    if (DbLinkTile.LinkTitle != Page.LinkTitle)
                    {
                   
                        DbLinkTile.LinkTitle = Page.LinkTitle.ToString();
                        DbLinkTile.Edited = DateTime.Now;
                        context.Update(DbLinkTile);
                        return false;
                    }

                }
            }
            return true;
        }

        public bool DoesAllTitlesMatch(UnderPage Page, Users user)
        {
            var DbTitle = context.UnderPages_titlecontents.Where(item => item.UnderPage.Id == Page.Id).FirstOrDefault();

            if (DbTitle != null)//if they dont match, save new content
            {
                if (DbTitle.TextContent != Page.UnderPage_TitleContents[0].TextContent)//if they dont match, save new content
                {
                    if (Page.UnderPage_TitleContents[0].TextContent != null)
                    {
                        DbTitle.TextContent = Page.UnderPage_TitleContents[0].TextContent.ToString();
                        DbTitle.Edited = DateTime.Now;
                        context.Update(DbTitle);
                        return false;
                    }


                }
            }

            return true;
        }

        public bool DoesAllImagesMatch(UnderPage Page, Users user)
        {

            var DbImages = context
                .UnderPages_imgcontents
                .Where(item => item.UnderPage.Id == Page.Id)
                .FirstOrDefault();
        
            if (DbImages != null)
            {
                if (Page.UnderPage_ImgContent[0].File != null)
                {
                    FileManager manages = new FileManager(context,host);
                    Page.UnderPage_ImgContent[0].ImgSrc = manages.CopyToRootFolder(Page.UnderPage_ImgContent[0].File,ToFolder);

                    if (!Page.UnderPage_ImgContent[0].ImgSrc.Equals(DbImages.ImgSrc))
                    {
                        DbImages.ImgSrc = Page.UnderPage_ImgContent[0].ImgSrc;
                        DbImages.User = user;
                        DbImages.Uploaded = DateTime.Now;
                        context.Update(DbImages);
                        return false;
                    }
                }
            }
            return true;
        }

 
        public UnderPage FetchUnderPageFromDB(UnderPage page,int id)
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


        public bool Remove(UnderPage item)
        {
            item.UnderPage_ImgContent[0] = context.UnderPages_imgcontents.Where(s => s.Id == item.UnderPage_ImgContent[0].Id).FirstOrDefault();
            item.UnderPage_TextContents[0] = context.UnderPages_TextContents.Where(s => s.Id == item.UnderPage_TextContents[0].Id).FirstOrDefault();
            item.UnderPage_TitleContents[0] = context.UnderPages_titlecontents.Where(s => s.Id == item.UnderPage_TitleContents[0].Id).FirstOrDefault();

            item.UnderPage_TitleContents[0].UnderPage = item;
            item.UnderPage_TextContents[0].UnderPage = item;
            item.UnderPage_ImgContent[0].UnderPage = item;


            try
            {
                context.Attach(item);
                context.Attach(item.UnderPage_ImgContent[0]);
                context.Attach(item.UnderPage_TextContents[0]);
                context.Attach(item.UnderPage_TitleContents[0]);


                context.Remove(item.UnderPage_ImgContent[0]);
                context.Remove(item.UnderPage_TextContents[0]);
                context.Remove(item.UnderPage_TitleContents[0]);
                context.Remove(item);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;;
            }
            return true;
         
        }

    }
}