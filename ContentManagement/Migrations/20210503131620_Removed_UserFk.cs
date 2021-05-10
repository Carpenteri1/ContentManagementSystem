using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class Removed_UserFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvertImageGallery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ImgSrc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertImageGallery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvertTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TypeOfAd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fileType = table.Column<string>(nullable: true),
                    fileName = table.Column<string>(nullable: true),
                    filePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeaderContent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    HeaderTheme = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StartPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    UserCreated = table.Column<DateTime>(nullable: false),
                    LastLoggedIn = table.Column<DateTime>(nullable: false),
                    UserRole = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    UserEdited = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LinkTitle = table.Column<string>(nullable: false),
                    LinkTo = table.Column<string>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    TypeOfAddId = table.Column<int>(nullable: true),
                    AdvertImageGallery_FK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adverts_AdvertImageGallery_AdvertImageGallery_FK",
                        column: x => x.AdvertImageGallery_FK,
                        principalTable: "AdvertImageGallery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adverts_AdvertTypes_TypeOfAddId",
                        column: x => x.TypeOfAddId,
                        principalTable: "AdvertTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Page_ImgContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ImgSrc = table.Column<string>(nullable: true),
                    StartPageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page_ImgContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Page_ImgContents_StartPages_StartPageId",
                        column: x => x.StartPageId,
                        principalTable: "StartPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StartPage_ImgContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Uploaded = table.Column<DateTime>(nullable: false),
                    ImgSrc = table.Column<string>(nullable: true),
                    StartPageId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartPage_ImgContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartPage_ImgContents_StartPages_StartPageId",
                        column: x => x.StartPageId,
                        principalTable: "StartPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StartPage_ImgContents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StartPage_Links",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    StartPageId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartPage_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartPage_Links_StartPages_StartPageId",
                        column: x => x.StartPageId,
                        principalTable: "StartPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StartPage_Links_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StartPage_TextContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    TextContent = table.Column<string>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    StartPageId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartPage_TextContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartPage_TextContents_StartPages_StartPageId",
                        column: x => x.StartPageId,
                        principalTable: "StartPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StartPage_TextContents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StartPage_TitleContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    TextContent = table.Column<string>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    StartPageId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartPage_TitleContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartPage_TitleContents_StartPages_StartPageId",
                        column: x => x.StartPageId,
                        principalTable: "StartPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StartPage_TitleContents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EventTitle = table.Column<string>(nullable: false),
                    EventTextContent = table.Column<string>(nullable: false),
                    TextContent = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LinkTitle = table.Column<string>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: true),
                    EventStart = table.Column<DateTime>(nullable: false),
                    EventEnds = table.Column<DateTime>(nullable: false),
                    IsPublic = table.Column<bool>(nullable: false),
                    applicationForm = table.Column<bool>(nullable: false),
                    EventPageRoute = table.Column<string>(nullable: true),
                    ImageGallery_FK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Page_ImgContents_ImageGallery_FK",
                        column: x => x.ImageGallery_FK,
                        principalTable: "Page_ImgContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnderPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LinkTitle = table.Column<string>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    IsPublic = table.Column<bool>(nullable: false),
                    ShowEventModul = table.Column<bool>(nullable: false),
                    ShowFormModul = table.Column<bool>(nullable: false),
                    OrderPosition = table.Column<int>(nullable: false),
                    ShowEmailFormModul = table.Column<bool>(nullable: false),
                    pageRoute = table.Column<string>(nullable: true),
                    AmmountOfAdverts = table.Column<int>(nullable: false),
                    TextContent = table.Column<string>(nullable: true),
                    PageTitle = table.Column<string>(nullable: true),
                    HeaderContentId = table.Column<int>(nullable: true),
                    StartPageId = table.Column<int>(nullable: true),
                    TopImage_FK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderPages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderPages_HeaderContent_HeaderContentId",
                        column: x => x.HeaderContentId,
                        principalTable: "HeaderContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnderPages_StartPages_StartPageId",
                        column: x => x.StartPageId,
                        principalTable: "StartPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnderPages_Page_ImgContents_TopImage_FK",
                        column: x => x.TopImage_FK,
                        principalTable: "Page_ImgContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventApplicants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    GolfId = table.Column<string>(nullable: true),
                    HomeClubName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    GoodToknowInfo = table.Column<string>(nullable: true),
                    EventName = table.Column<string>(nullable: true),
                    applyedToEventId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventApplicants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventApplicants_Events_applyedToEventId",
                        column: x => x.applyedToEventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_AdvertImageGallery_FK",
                table: "Adverts",
                column: "AdvertImageGallery_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_TypeOfAddId",
                table: "Adverts",
                column: "TypeOfAddId");

            migrationBuilder.CreateIndex(
                name: "IX_EventApplicants_applyedToEventId",
                table: "EventApplicants",
                column: "applyedToEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ImageGallery_FK",
                table: "Events",
                column: "ImageGallery_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Page_ImgContents_StartPageId",
                table: "Page_ImgContents",
                column: "StartPageId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_ImgContents_StartPageId",
                table: "StartPage_ImgContents",
                column: "StartPageId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_ImgContents_UserId",
                table: "StartPage_ImgContents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_Links_StartPageId",
                table: "StartPage_Links",
                column: "StartPageId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_Links_UserId",
                table: "StartPage_Links",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_TextContents_StartPageId",
                table: "StartPage_TextContents",
                column: "StartPageId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_TextContents_UserId",
                table: "StartPage_TextContents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_TitleContents_StartPageId",
                table: "StartPage_TitleContents",
                column: "StartPageId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_TitleContents_UserId",
                table: "StartPage_TitleContents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_HeaderContentId",
                table: "UnderPages",
                column: "HeaderContentId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_StartPageId",
                table: "UnderPages",
                column: "StartPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_TopImage_FK",
                table: "UnderPages",
                column: "TopImage_FK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");

            migrationBuilder.DropTable(
                name: "EventApplicants");

            migrationBuilder.DropTable(
                name: "FileInfo");

            migrationBuilder.DropTable(
                name: "StartPage_ImgContents");

            migrationBuilder.DropTable(
                name: "StartPage_Links");

            migrationBuilder.DropTable(
                name: "StartPage_TextContents");

            migrationBuilder.DropTable(
                name: "StartPage_TitleContents");

            migrationBuilder.DropTable(
                name: "UnderPages");

            migrationBuilder.DropTable(
                name: "AdvertImageGallery");

            migrationBuilder.DropTable(
                name: "AdvertTypes");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "HeaderContent");

            migrationBuilder.DropTable(
                name: "Page_ImgContents");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "StartPages");
        }
    }
}
