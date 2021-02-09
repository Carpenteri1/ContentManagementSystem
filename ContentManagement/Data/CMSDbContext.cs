using Microsoft.EntityFrameworkCore;
using ContentManagement.StartPageModels.PageModel;
using ContentManagement.Models.Account;
using ContentManagement.UnderPageModels.PageModel;
using ContentManagement.HeaderModel;
using ContentManagement.Models.EventsModel;
namespace ContentManagement.Data
{
    public class CMSDbContext : DbContext
    {
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
      : base(options)
        {
        }

        public DbSet<UnderPage> UnderPages { get; set; }
        public DbSet<UnderPage_TitleContents> UnderPages_titlecontents { get; set; }
        public DbSet<UnderPage_ImgContents> UnderPages_imgcontents { get; set; }
        public DbSet<UnderPage_TextContents> UnderPages_TextContents { get; set; }
        public DbSet<StartPage> StartPages { get; set; }
        public DbSet<StartPage_TitleContents> StartPage_TitleContents { get; set; }
        public DbSet<StartPage_ImgContents> StartPage_ImgContents { get; set; }
        public DbSet<StartPage_TextContents> StartPage_TextContents { get; set; }
        public DbSet<StartPage_Links> StartPage_Links { get; set; }
        public DbSet<HeaderContent> HeaderContent { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<EventModel> Events { get; set; }
        public DbSet<EventLinkModel> Events_Links { get; set; }
    }
}