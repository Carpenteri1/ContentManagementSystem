using ContentManagement.Data;
using ContentManagement.Models.StartPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.ControllerHelperClasses
{
    public class StartPageControllerHelper
    {
        private CMSDbContext context;

        public StartPageControllerHelper(CMSDbContext context)
        {
            this.context = context;
        }

        public bool DoesAllTextContentMatch(StartPage Page, List<StartPage_TextContent> text)
        {
            for (int i = 0; i < text.Count(); i++)
            {
                if (!text[i].TextContent.Equals(Page.StartPage_TextContents[i].TextContent))
                {
                    text[i].TextContent = Page.StartPage_TextContents[i].TextContent.ToString();
                    text[i].Edited = DateTime.Now;
                    return false;
                }
            }
            return true;
        }

        public bool DoesAllTitleContentMatch(StartPage Page,List<StartPage_TitleContent> titles)
        {
            for (int i = 0; i < titles.Count(); i++)
            {
                if (!titles[i].TextContent.Equals(Page.StartPage_TitleContents[i].TextContent))
                {
                    titles[i].TextContent = Page.StartPage_TitleContents[i].TextContent.ToString();
                    titles[i].Edited = DateTime.Now;
                    context.Update(titles[i]);
                    return false;
                }
            }
            return true;
        }

        public StartPage FetchStartPageFromDB()
        {
            var startpage = context.StartPages.First();
            return startpage;
        }

        public List<StartPage_TitleContent> FetchAllTitleContentFromDB(StartPage startPage)
        {
            return startPage.StartPage_TitleContents = context
                .StartPage_TitleContents
                .ToList();
        }

        public List<StartPage_TextContent> FetchAllTextContentFromDB(StartPage startPage)
        {
            return startPage.StartPage_TextContents = context
                    .StartPage_TextContents
                    .ToList();
        }

        public bool SaveToDb()
        {
            try
            {
               context.SaveChanges();
            }
            catch(Exception)
            {
                return false;
            }

            return true;
        }
    }
}
