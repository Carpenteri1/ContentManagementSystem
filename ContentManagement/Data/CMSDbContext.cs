using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.Account;
using ContentManagement.Models.ContentManagement;
using System.Security.Claims;

namespace ContentManagement.Data
{
    public class CMSDbContext : DbContext
    {
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
     : base(options)
        {
        }

        public DbSet<TextContentModel> TextContentModels { get; set; }
        public DbSet<LoginModel> LoginModel { get; set; }

    }
}
