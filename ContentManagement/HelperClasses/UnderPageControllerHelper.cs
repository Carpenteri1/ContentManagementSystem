using ContentManagement.Data;
using ContentManagement.Data.Services;
using ContentManagement.HeaderModel;
using ContentManagement.Models.Account;
using ContentManagement.Models.ImageModels;
using ContentManagement.StartPageModels.PageModel;
using ContentManagement.UnderPageModels.PageModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        private const string ToFolder = "/Upload/PageImages/";
        private const string DefaultDropDownValue = "1";
        public UnderPageControllerHelper(CMSDbContext context,IWebHostEnvironment host)
        {
            this.context = context;
            this.host = host;
        }

        public bool DeleteImage(string imgsrc)
        {

            if (DeleteImageFromDb(imgsrc) &&
                DeleteImageFromRoot(imgsrc))
                return true;


            return false;
        }

        private bool DeleteImageFromRoot(string imgsrc)
        {
            FileManager fileManager = new FileManager(context,host);
            if (fileManager.RemoveFromRootFolder(imgsrc))
                return true;
 
            return false;
        }

        private bool DeleteImageFromDb(string imgsrc)
        {
            try
            {
                var gallery = context.PagesImageGallery.ToList();
                foreach (var s in gallery)
                    if (s.ImgUrl.Contains(imgsrc))
                    {
                        context.Attach(s);
                        context.Remove(s);
                        return true;
                    }
            }
            catch
            {

            }
            return false;
        }

        private UnderPage AddStartPageFk(UnderPage newPage)
        {
            newPage.StartPage = context.StartPages.FirstOrDefault();
            return newPage;
        }

        public UnderPage CreateNewPageData(UnderPage newPage, Users user, int dropdownValue)
        {
            var headercontent = context.HeaderContent.Where(header => header.Id == dropdownValue).First();
            var underpages = context.UnderPages.Where(item => item.HeaderContent.Id == headercontent.Id).ToList();
            newPage = AddStartPageFk(newPage);

             if (headercontent != null &&
                 user != null)
             {
                 newPage.HeaderContent = headercontent;
                 newPage.OrderPosition = underpages.Count() + PlusOne;
                 newPage.User = user;
                 newPage.pageRoute = CreateRouteData(newPage.LinkTitle);
                 context.Add(newPage);

             }

             return newPage;  
        }
        private bool MoveUp (UnderPage currentPage)
        {
            List<HeaderContent> header = context.HeaderContent.ToList();
            if (currentPage.OrderPosition - 1 > 0)
            {
                List<UnderPage> DbUnderPage = context.UnderPages.Where(item => item.HeaderContent.HeaderTheme == currentPage.HeaderContent.HeaderTheme).ToList();
                if (DbUnderPage != null)
                {
                    foreach (var s in DbUnderPage.OrderBy(item => item.OrderPosition))
                    {
                        if (currentPage.OrderPosition-1 == s.OrderPosition)
                        {
                            var oldSOrderPosition = s.OrderPosition;
                            s.OrderPosition = currentPage.OrderPosition;
                            currentPage.OrderPosition = oldSOrderPosition;
                            context.Update(currentPage);
                            context.SaveChanges();
                            context.Update(s);
                            context.SaveChanges();
                            return true;
                        }
                     
                    }
                }
            }
            return false;
        }



        private bool MoveDown(UnderPage currentPage)
        {
            List<HeaderContent> header = context.HeaderContent.ToList();
            if (currentPage.OrderPosition + 1 > 0)
            {
                List<UnderPage> DbUnderPage = context.UnderPages.Where(item => item.HeaderContent.HeaderTheme == currentPage.HeaderContent.HeaderTheme).ToList();
                if (DbUnderPage != null)
                {
                    foreach (var s in DbUnderPage.OrderBy(item => item.OrderPosition))
                    {
                        if (currentPage.OrderPosition + 1 == s.OrderPosition)
                        {
                            var oldSOrderPosition = s.OrderPosition;
                            s.OrderPosition = currentPage.OrderPosition;
                            currentPage.OrderPosition = oldSOrderPosition;
                            context.Update(currentPage);
                            context.SaveChanges();
                            context.Update(s);
                            context.SaveChanges();
                            return true;
                        }

                    }
                }
            }
            return false;
        }
        public bool ChangeOrderPosition(UnderPage currentPage,bool moveUp)
        {

            if (moveUp)
            {
                return MoveUp(currentPage);
            }
            else
            {
                return MoveDown(currentPage);
            }
           
        }


        private bool DoesAllTextsMatch(UnderPage Page)
        {
            var DbTexts = context.UnderPages.Where(item  => item.Id  == Page.Id).FirstOrDefault();
            if (DbTexts != null)
            {
                if (Page.TextContent != null)
                    {
                    if(Page.TextContent != string.Empty)
                    {
                        if (DbTexts.TextContent != Page.TextContent)//if they dont match, save new content
                        {

                            DbTexts.TextContent = Page.TextContent;
                            context.Update(DbTexts);
                            return false;
                        }
                    }
                    return true;
                }
            }
            return true;
        }

        private bool DoesAllUnderPageLinkTitleMatch(UnderPage Page)
        {
            var DbLinkTile = context.UnderPages.Where(underpage => underpage.Id == Page.Id).FirstOrDefault();
            if (DbLinkTile != null)//if they dont match, save new content
            {
                if (DbLinkTile.LinkTitle != null)
                {
                    if (DbLinkTile.LinkTitle != Page.LinkTitle)
                    {
                   
                        DbLinkTile.LinkTitle = Page.LinkTitle.ToString();
                        DbLinkTile.pageRoute = CreateRouteData(DbLinkTile.LinkTitle);
                        context.Update(DbLinkTile);
                        return false;
                    }

                }
            }
            return true;
        }

        private string CreateRouteData(string LinkTitle)
        {
                return LinkTitle.Replace(" ", "_")
                .Replace("ö", "o")
                .Replace("å", "a")
                .Replace("ä", "a")
                .Replace(";","")
                .Replace(":","")
                .Replace("!","")
                .Replace("?","")
                .Replace("-","")
                .Replace("–","");    

            
        }
        private bool DoesAllTitlesMatch(UnderPage Page)
        {
            var DbTitle = context.UnderPages.Where(item => item.Id == Page.Id).FirstOrDefault();

            if (DbTitle != null)//if they dont match, save new content
            {
                if (DbTitle.PageTitle != Page.PageTitle)//if they dont match, save new content
                {
                    if (Page.PageTitle != null)
                    {
                        DbTitle.PageTitle = Page.PageTitle;
                        context.Update(DbTitle);
                        return false;
                    }


                }
            }

            return true;
        }
      
        public bool FileManager(IFormFile file)
        {
            try
            {
                var gallery = context.PagesImageGallery.ToList();
                FileManager manages = new FileManager(context, host);
                PagesImageGalleryModel galleryModel = new PagesImageGalleryModel();
                galleryModel.ImgUrl = manages.CopyToRootFolder(file, ToFolder);
                foreach(var s in gallery)
                {
                    if (s.ImgUrl.Contains(galleryModel.ImgUrl))//if image already excist
                    {
                        return false;
                    }
                }
                context.Add(galleryModel);
            }
            catch
            {
                return false;
            }
     
            return true;
        }


        private bool DoesAllImagesMatch(UnderPage Page, Users user)
        {

            var DbImages = context
                .UnderPages
                .Where(item => item.Id == Page.Id)
                .FirstOrDefault();
    
            if (DbImages != null)
            {
                  
                    if (!Page.underPageImgSource.Equals(DbImages.underPageImgSource))
                    {
                        DbImages.underPageImgSource = Page.underPageImgSource;
                        if(DbImages.User.UserName != user.UserName)
                        {
                            DbImages.User = user;
                        }
                        context.Update(DbImages);
                        return false;
                    }
            }    
            return true;
        }
        public bool DoesAllHeaderMatch(UnderPage Page)
        {
            var underPageDb = GetUnderPageById(Page.Id);

            if(underPageDb.HeaderContent != null)
            {
                    if (Page.HeaderContent.HeaderTheme != underPageDb.HeaderContent.HeaderTheme)
                    {
                        underPageDb.HeaderContent = Page.HeaderContent;
                        context.Update(underPageDb);
                        Edited(underPageDb);
                        return false;
                    }
            }
            return true;
        }

        private bool ShowEventModul(UnderPage Page)
        {
            var underPageDb = GetUnderPageById(Page.Id);
                if (Page.ShowEventModul != underPageDb.ShowEventModul)
                {
                    underPageDb.ShowEventModul = Page.ShowEventModul;
                    context.Update(underPageDb);
                    return false;
                }
            
            return true;
        }
        private bool ShowContactFormModul(UnderPage Page)
        {
            var underPageDb = GetUnderPageById(Page.Id);
            if (Page.ShowFormModul != underPageDb.ShowFormModul)
            {
                underPageDb.ShowFormModul = Page.ShowFormModul;
                context.Update(underPageDb);
                return false;
            }

            return true;
        }
        private bool ShowEmailFormModul(UnderPage Page)
        {
            var underPageDb = GetUnderPageById(Page.Id);
            if (Page.ShowEmailFormModul != underPageDb.ShowEmailFormModul)
            {
                underPageDb.ShowEmailFormModul = Page.ShowEmailFormModul;
                context.Update(underPageDb);
                return false;
            }

            return true;
        }


        private bool ArePagePublic(UnderPage Page)
        {
            var underPageDb = GetUnderPageById(Page.Id);
                if (Page.IsPublic != underPageDb.IsPublic)
                {
                    underPageDb.IsPublic = Page.IsPublic;
                    context.Update(underPageDb);
                    return false;
                }
            return true;
        }





        public HeaderContent GetHeaderContentById(int Id)
        {
            return context.HeaderContent.Where(item => item.Id == Id).FirstOrDefault();
        }

        public bool DoesAllContentMatch(UnderPage underPage,Users user)
        {
            bool match = true;

            if (!DoesAllImagesMatch(underPage, user))
                match = false;
            if (!DoesAllTextsMatch(underPage))
                match = false;
            if (!DoesAllTitlesMatch(underPage))
                match = false;
            if (!DoesAllUnderPageLinkTitleMatch(underPage))
                match = false;
            if (!DoesAllHeaderMatch(underPage))
                match = false;
            if (!ShowEventModul(underPage))
                match = false;
            if (!ArePagePublic(underPage))
                match = false;
            if (!ShowContactFormModul(underPage))
                match = false;
            if (!ShowEmailFormModul(underPage))
                match = false;

            if (!match)
                underPage.Edited = DateTime.Now;

            return match;
        }


        public string CheckDropDownValue(string selecterDropDownValue)
        {
            if (selecterDropDownValue == null)
            {
                selecterDropDownValue = DefaultDropDownValue;
            }
            return selecterDropDownValue;
        }
        public HeaderContent GetHeaderContentByDropDownValue(int selecterDropDownValue)
        {
           return context.HeaderContent.Where(s => s.Id == selecterDropDownValue).FirstOrDefault();
        }
 
        public UnderPage GetUnderPageById(int id)
        {
            return context
                .UnderPages
                .Where(page => page.Id == id)
                .FirstOrDefault();
        }

        public List<HeaderContent> GetAllHeadContent()
        {
            return context.HeaderContent.ToList();
        }

        public Users GetUserByName(string nameof)
        {
           return context.Users.Where(item => item.UserName == nameof).FirstOrDefault();
        }

        public List<UnderPage> GetUnderPageByDropDownValue(int selectedDropDownValue)
        {
            return context.UnderPages.Where(s => s.HeaderContent.Id == selectedDropDownValue).ToList();
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

        public bool Edited(UnderPage underPage)
        {
            try
            {
                underPage.OrderPosition = context.UnderPages.Where(item => item.HeaderContent.Id == underPage.HeaderContent.Id).Count() + PlusOne;
                context.Attach(underPage);
                context.Update(underPage);
            }
            catch
            {
                return false;
            }
            SaveToDb();
            return true;
        }


        public bool ReMatchOrder(UnderPage underPage)
        {
            try
            {
                var underpages = context.UnderPages.Where(item => item.HeaderContent.Id == underPage.HeaderContent.Id).ToList();
                int i = 1;
                foreach (var s in underpages.OrderBy(item => item.OrderPosition))
                {
                    context.Attach(s);
                    s.OrderPosition = i;
                    context.Update(s);

                    i++;
                }

            }catch(Exception e)
            {
                string messege = e.Message;
                return false;
            }
       
            return true;
        }


        public bool Remove(UnderPage item)
        {
            var headercontent = context.HeaderContent.ToList();
            try
            {
                context.Attach(item);
                context.Remove(item);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false; ;
            }
      

            return true;
         
        }

    }
}
