﻿using Microsoft.EntityFrameworkCore;
using ContentManagement.StartPageModels.PageModel;
using ContentManagement.Models.Account;
using ContentManagement.UnderPageModels.PageModel;
using ContentManagement.HeaderModel;
using ContentManagement.Models.EventsModel;
using ContentManagement.Models.Adverts;
using ContentManagement.Data.Services;
using ContentManagement.Models.FileModel;
using ContentManagement.Models.FilesModel;
namespace ContentManagement.Data
{
    public class CMSDbContext : DbContext
    {
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*
            modelBuilder.Entity<AdvertsModel>()
                .HasOne(adds => adds.UnderPage)
                .WithMany(page => page.Adverts)
                .IsRequired();

            modelBuilder.Entity<AdvertsModel>()
                .HasOne(adds => adds.EventPage)
                .WithMany(page => page.Adverts)
                .IsRequired();
            */
            /*
            modelBuilder.Entity<EventModel>()
                .HasOne(img => img.TopImage);

            modelBuilder.Entity<UnderPage>()
              .HasOne(page => page.TopImage);*/

        }


        public DbSet<HeaderContent> HeaderContent { get; set; }
        public DbSet<Users> Users { get; set; }

        #region underPage
        public DbSet<UnderPage> UnderPages { get; set; }
        //public DbSet<UnderPage_TitleContents> UnderPages_titlecontents { get; set; }
        // public DbSet<UnderPage_ImgContents> UnderPages_imgcontents { get; set; }
        // public DbSet<UnderPage_TextContents> UnderPages_TextContents { get; set; }
        #endregion

        #region StartPage region
        public DbSet<StartPage> StartPages { get; set; }
        public DbSet<StartPage_TitleContents> StartPage_TitleContents { get; set; }
        public DbSet<StartPage_ImgContents> StartPage_ImgContents { get; set; }
        public DbSet<StartPage_TextContents> StartPage_TextContents { get; set; }
        public DbSet<StartPage_Links> StartPage_Links { get; set; }
        #endregion

        #region Event region
        public DbSet<EventModel> Events { get; set; }
        // public DbSet<EventImageContentModel> EventImageContentModel { get; set; }
        public DbSet<ApplicationFormModel> EventApplicants { get; set; }
        #endregion

        #region Adverts
        public DbSet<AdvertsModel> Adverts { get; set; }
        public DbSet<AdvertType> AdvertTypes { get; set; }
        //   public DbSet<Adverts_ImageContent> adverts_imagecontent { get; set; }
        #endregion

        #region Files
        public DbSet<FileModel> FileInfo { get; set; }
        public DbSet<AdvertImageGallery> AdvertImageGallery { get; set; }
        public DbSet<PageImageGallery> Page_ImgContents { get; set; }
        #endregion


    }
}