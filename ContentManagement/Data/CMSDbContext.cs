using Microsoft.EntityFrameworkCore;
using ContentManagement.Models.Account;
using ContentManagement.Models.Content;


namespace ContentManagement.Data
{
    public class CMSDbContext : DbContext
    {
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
     : base(options)
        {
        }

        public DbSet<StartPage> StartPages { get; set; }
        public DbSet<StartPage_ImgContent> StartPage_ImgContents { get; set; }
        public DbSet<StartPage_TextContent> StartPage_TextContents {get;set;}
        public DbSet<StartPage_TitleContent> StartPage_TitleContents { get; set; }
        public DbSet<HeaderMenu> HeaderMenus { get; set; }
        public DbSet<HeaderTitle> HeaderTitles { get; set; }

        public DbSet<Users> Users { get; set; }
    }
}
