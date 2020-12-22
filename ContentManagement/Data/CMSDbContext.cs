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

        public DbSet<TextContentModel> Content { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
