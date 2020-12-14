using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models;
using ContentManagement.Models.ContentManagement;
namespace ContentManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
     : base(options)
        {
        }

        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<TextContentModel> TextContentModels { get; set; }
        
    }
}
