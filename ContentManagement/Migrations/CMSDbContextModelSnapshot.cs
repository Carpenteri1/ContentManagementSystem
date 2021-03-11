﻿// <auto-generated />
using System;
using ContentManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContentManagement.Migrations
{
    [DbContext(typeof(CMSDbContext))]
    partial class CMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ContentManagement.HeaderModel.HeaderContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("HeaderTheme")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("HeaderContent");
                });

            modelBuilder.Entity("ContentManagement.Models.Account.Users", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("LastLoggedIn")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UserCreated")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("UserEdited")
                        .HasColumnType("datetime");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ContentManagement.Models.Adverts.AdvertType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TypeOfAd")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AdvertTypes");
                });

            modelBuilder.Entity("ContentManagement.Models.Adverts.AdvertsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("text");

                    b.Property<string>("LinkTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LinkTo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TypeOfAddId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Uploaded")
                        .HasColumnType("datetime");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("TypeOfAddId");

                    b.HasIndex("UserId");

                    b.ToTable("Adverts");
                });

            modelBuilder.Entity("ContentManagement.Models.EventsModel.EventLinkModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EventModelId")
                        .HasColumnType("int");

                    b.Property<string>("LinkTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventModelId");

                    b.HasIndex("UserId");

                    b.ToTable("Events_Links");
                });

            modelBuilder.Entity("ContentManagement.Models.EventsModel.EventModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BodyText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Edited")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EventEnds")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EventStart")
                        .HasColumnType("datetime");

                    b.Property<string>("EventTextContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EventTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ContentManagement.StartPageModels.PageModel.StartPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StartPages");
                });

            modelBuilder.Entity("ContentManagement.StartPageModels.PageModel.StartPage_ImgContents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("text");

                    b.Property<int?>("StartPageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Uploaded")
                        .HasColumnType("datetime");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StartPageId");

                    b.HasIndex("UserId");

                    b.ToTable("StartPage_ImgContents");
                });

            modelBuilder.Entity("ContentManagement.StartPageModels.PageModel.StartPage_Links", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Edited")
                        .HasColumnType("datetime");

                    b.Property<int?>("StartPageId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StartPageId");

                    b.HasIndex("UserId");

                    b.ToTable("StartPage_Links");
                });

            modelBuilder.Entity("ContentManagement.StartPageModels.PageModel.StartPage_TextContents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Edited")
                        .HasColumnType("datetime");

                    b.Property<int?>("StartPageId")
                        .HasColumnType("int");

                    b.Property<string>("TextContent")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StartPageId");

                    b.HasIndex("UserId");

                    b.ToTable("StartPage_TextContents");
                });

            modelBuilder.Entity("ContentManagement.StartPageModels.PageModel.StartPage_TitleContents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Edited")
                        .HasColumnType("datetime");

                    b.Property<int?>("StartPageId")
                        .HasColumnType("int");

                    b.Property<string>("TextContent")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StartPageId");

                    b.HasIndex("UserId");

                    b.ToTable("StartPage_TitleContents");
                });

            modelBuilder.Entity("ContentManagement.UnderPageModels.PageModel.UnderPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AmmountOfAdverts")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Edited")
                        .HasColumnType("datetime");

                    b.Property<int?>("HeaderContentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LinkTitle")
                        .HasColumnType("text");

                    b.Property<int>("OrderPosition")
                        .HasColumnType("int");

                    b.Property<bool>("ShowEmailFormModul")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ShowEventModul")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ShowFormModul")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("StartPageId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("pageRoute")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HeaderContentId");

                    b.HasIndex("StartPageId");

                    b.HasIndex("UserId");

                    b.ToTable("UnderPages");
                });

            modelBuilder.Entity("ContentManagement.UnderPageModels.PageModel.UnderPage_ImgContents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("text");

                    b.Property<int?>("UnderPageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Uploaded")
                        .HasColumnType("datetime");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnderPageId");

                    b.HasIndex("UserId");

                    b.ToTable("UnderPages_imgcontents");
                });

            modelBuilder.Entity("ContentManagement.UnderPageModels.PageModel.UnderPage_TextContents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Edited")
                        .HasColumnType("datetime");

                    b.Property<string>("TextContent")
                        .HasColumnType("text");

                    b.Property<int?>("UnderPageId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnderPageId");

                    b.HasIndex("UserId");

                    b.ToTable("UnderPages_TextContents");
                });

            modelBuilder.Entity("ContentManagement.UnderPageModels.PageModel.UnderPage_TitleContents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Edited")
                        .HasColumnType("datetime");

                    b.Property<string>("TextContent")
                        .HasColumnType("text");

                    b.Property<int?>("UnderPageId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnderPageId");

                    b.HasIndex("UserId");

                    b.ToTable("UnderPages_titlecontents");
                });

            modelBuilder.Entity("ContentManagement.Models.Adverts.AdvertsModel", b =>
                {
                    b.HasOne("ContentManagement.Models.Adverts.AdvertType", "TypeOfAdd")
                        .WithMany("AdvertsModel")
                        .HasForeignKey("TypeOfAddId");

                    b.HasOne("ContentManagement.Models.Account.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ContentManagement.Models.EventsModel.EventLinkModel", b =>
                {
                    b.HasOne("ContentManagement.Models.EventsModel.EventModel", "EventModel")
                        .WithMany("Links")
                        .HasForeignKey("EventModelId");

                    b.HasOne("ContentManagement.Models.Account.Users", "User")
                        .WithMany("EventLinks")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ContentManagement.Models.EventsModel.EventModel", b =>
                {
                    b.HasOne("ContentManagement.Models.Account.Users", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ContentManagement.StartPageModels.PageModel.StartPage_ImgContents", b =>
                {
                    b.HasOne("ContentManagement.StartPageModels.PageModel.StartPage", "StartPage")
                        .WithMany("StartPage_ImgContents")
                        .HasForeignKey("StartPageId");

                    b.HasOne("ContentManagement.Models.Account.Users", "User")
                        .WithMany("StartPage_ImgContents")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ContentManagement.StartPageModels.PageModel.StartPage_Links", b =>
                {
                    b.HasOne("ContentManagement.StartPageModels.PageModel.StartPage", "StartPage")
                        .WithMany("StartPage_Links")
                        .HasForeignKey("StartPageId");

                    b.HasOne("ContentManagement.Models.Account.Users", "User")
                        .WithMany("StartPage_Links")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ContentManagement.StartPageModels.PageModel.StartPage_TextContents", b =>
                {
                    b.HasOne("ContentManagement.StartPageModels.PageModel.StartPage", "StartPage")
                        .WithMany("StartPage_TextContents")
                        .HasForeignKey("StartPageId");

                    b.HasOne("ContentManagement.Models.Account.Users", "User")
                        .WithMany("StartPage_TextContents")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ContentManagement.StartPageModels.PageModel.StartPage_TitleContents", b =>
                {
                    b.HasOne("ContentManagement.StartPageModels.PageModel.StartPage", "StartPage")
                        .WithMany("StartPage_TitleContents")
                        .HasForeignKey("StartPageId");

                    b.HasOne("ContentManagement.Models.Account.Users", "User")
                        .WithMany("StartPage_Titles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ContentManagement.UnderPageModels.PageModel.UnderPage", b =>
                {
                    b.HasOne("ContentManagement.HeaderModel.HeaderContent", "HeaderContent")
                        .WithMany("UnderPages")
                        .HasForeignKey("HeaderContentId");

                    b.HasOne("ContentManagement.StartPageModels.PageModel.StartPage", "StartPage")
                        .WithMany("UnderPages")
                        .HasForeignKey("StartPageId");

                    b.HasOne("ContentManagement.Models.Account.Users", "User")
                        .WithMany("UnderPages")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ContentManagement.UnderPageModels.PageModel.UnderPage_ImgContents", b =>
                {
                    b.HasOne("ContentManagement.UnderPageModels.PageModel.UnderPage", "UnderPage")
                        .WithMany("UnderPage_ImgContent")
                        .HasForeignKey("UnderPageId");

                    b.HasOne("ContentManagement.Models.Account.Users", "User")
                        .WithMany("UnderPage_ImgContents")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ContentManagement.UnderPageModels.PageModel.UnderPage_TextContents", b =>
                {
                    b.HasOne("ContentManagement.UnderPageModels.PageModel.UnderPage", "UnderPage")
                        .WithMany("UnderPage_TextContents")
                        .HasForeignKey("UnderPageId");

                    b.HasOne("ContentManagement.Models.Account.Users", "User")
                        .WithMany("UnderPage_TextContents")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ContentManagement.UnderPageModels.PageModel.UnderPage_TitleContents", b =>
                {
                    b.HasOne("ContentManagement.UnderPageModels.PageModel.UnderPage", "UnderPage")
                        .WithMany("UnderPage_TitleContents")
                        .HasForeignKey("UnderPageId");

                    b.HasOne("ContentManagement.Models.Account.Users", "User")
                        .WithMany("UnderPage_Titles")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
