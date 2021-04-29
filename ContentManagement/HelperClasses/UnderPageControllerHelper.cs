using ContentManagement.Data;
using ContentManagement.Data.Services;
using ContentManagement.HeaderModel;
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
        private const string DefaultDropDownValue = "1";
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

        /*private UnderPage PopulateTextContent(UnderPage newPage, Users user)
        {
            if (newPage.UnderPage_TextContents.TextContent == null)
            {
                newPage.UnderPage_TextContents = new UnderPage_TextContents
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
                newPage.UnderPage_TextContents = new UnderPage_TextContents
                {
                    TextContent = newPage.UnderPage_TextContents.TextContent,
                    UnderPage = newPage,
                    Created = DateTime.Now,
                    User = user
                };


                return newPage;
            }
        }


        private UnderPage PopulateTitleContent(UnderPage newPage, Users user)
        {
            if (newPage.TextContent == null)
            {
                newPage.UnderPage_TitleContents = new UnderPage_TitleContents
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

                newPage.UnderPage_TitleContents = new UnderPage_TitleContents
                {
                    TextContent = newPage.UnderPage_TitleContents.TextContent,
                    UnderPage = newPage,
                    Created = DateTime.Now,
                    User = user
                };

                return newPage;
            }
        }*/

        private UnderPage AddStartPageFk(UnderPage newPage)
        {
            newPage.StartPage = context.StartPages.FirstOrDefault();
            return newPage;
        }

        public UnderPage CreateNewPageData(UnderPage newPage, Users user, int dropdownValue)
        {
            var headercontent = context.HeaderContent.Where(header => header.Id == dropdownValue).First();
            var underpages = context.UnderPages.Where(item => item.HeaderContent.Id == headercontent.Id).ToList();


            newPage = PopulateImageContent(newPage,user);
            //newPage = PopulateTextContent(newPage,user);
            //newPage = PopulateTitleContent(newPage,user);
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
                        if (DbTexts.TextContent != Page.TextContent)//if they dont match, save new content
                        {
                     
                            DbTexts.TextContent = Page.TextContent;
                            DbTexts.Edited = DateTime.Now;
                            context.Update(DbTexts);
                            return false;
                        }
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
                        DbLinkTile.Edited = DateTime.Now;
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
                .Replace("-","");    

            
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
                        DbTitle.PageTitle = Page.PageTitle.ToString();
                        DbTitle.Edited = DateTime.Now;
                        context.Update(DbTitle);
                        return false;
                    }


                }
            }

            return true;
        }

        private bool DoesAllImagesMatch(UnderPage Page, Users user)
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
                        if(DbImages.User.UserName != user.UserName)
                        {
                            DbImages.User = user;
                        }
                        DbImages.Uploaded = DateTime.Now;
                        context.Update(DbImages);
                        return false;
                    }
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

        public List<UnderPage_TitleContents> GetTitleContentById(int Id)
        {
            return context
                .UnderPages_titlecontents
                .Where(underpage => underpage.UnderPage.Id == Id)
                .ToList();
        }

        public List<UnderPage_TextContents> GetTextContentById(int Id)
        {
            return context
                .UnderPages_TextContents
                .Where(underpage => underpage.UnderPage.Id == Id)
                .ToList();
        }

        public List<UnderPage_ImgContents> GetImgeContentById(int Id)
        {
            return context
                .UnderPages_imgcontents
                .Where(underpage => underpage.UnderPage.Id == Id)
                .ToList();
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
            var underpages = context.UnderPages.Where(page => page.HeaderContent.Id == item.HeaderContent.Id).ToList();
            try
            {
                context.Attach(item);
                context.Attach(item.UnderPage_ImgContent[0]);
                //context.Attach(item.UnderPage_TextContents[0]);
                //context.Attach(item.UnderPage_TitleContents[0]);


                context.Remove(item.UnderPage_ImgContent[0]);
                //context.Remove(item.UnderPage_TextContents[0]);
                //context.Remove(item.UnderPage_TitleContents[0]);
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
