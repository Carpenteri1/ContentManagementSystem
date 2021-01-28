using Microsoft.EntityFrameworkCore;
using ContentManagement.Models.StartPageModels;
using ContentManagement.Models.HeaderModels;
using ContentManagement.Models.Account;

namespace ContentManagement.Data
{
    public class CMSDbContext : DbContext
    {
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
      : base(options)
        {
        }


        public DbSet<StartPage> StartPages { get; set; }
        public DbSet<StartPage_ImgContents> StartPage_ImgContents { get; set; }
        public DbSet<StartPage_TextContents> StartPage_TextContents { get; set; }
        public DbSet<StartPage_TitleContents> StartPage_TitleContents { get; set; }
        public DbSet<HeaderMenus> HeaderMenus { get; set; }
        public DbSet<HeaderTitels> HeaderTitles { get; set; }

        public DbSet<Users> Users { get; set; }
    }
}
