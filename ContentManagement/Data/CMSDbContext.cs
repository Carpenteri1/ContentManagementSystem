using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.Account;
using ContentManagement.Models.Content;
using System.Security.Claims;

namespace ContentManagement.Data
{
    public class CMSDbContext : DbContext
    {
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
     : base(options)
        {
        }

        public DbSet<TitleModel> TitleModel { get; set; }
        public DbSet<TextContentModel> TextContent { get; set; }
        public DbSet<ImgModel> ImgModel { get; set; }
        public DbSet<MergedContent>  MergedContent { get; set; }
        public DbSet<PageModel> PageModel { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
