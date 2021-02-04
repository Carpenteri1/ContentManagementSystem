using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class Initilize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "UnderPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LinkTitle = table.Column<string>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    HeaderContentId = table.Column<int>(nullable: true)
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
                        name: "FK_UnderPages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnderPages_imgcontents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Uploaded = table.Column<DateTime>(nullable: false),
                    ImgSrc = table.Column<string>(nullable: true),
                    UnderPageId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderPages_imgcontents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderPages_imgcontents_UnderPages_UnderPageId",
                        column: x => x.UnderPageId,
                        principalTable: "UnderPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnderPages_imgcontents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnderPages_TextContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    TextContent = table.Column<string>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    UnderPageId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderPages_TextContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderPages_TextContents_UnderPages_UnderPageId",
                        column: x => x.UnderPageId,
                        principalTable: "UnderPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnderPages_TextContents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnderPages_titlecontents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    TextContent = table.Column<string>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    UnderPageId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderPages_titlecontents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderPages_titlecontents_UnderPages_UnderPageId",
                        column: x => x.UnderPageId,
                        principalTable: "UnderPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnderPages_titlecontents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_UnderPages_UserId",
                table: "UnderPages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_imgcontents_UnderPageId",
                table: "UnderPages_imgcontents",
                column: "UnderPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_imgcontents_UserId",
                table: "UnderPages_imgcontents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_TextContents_UnderPageId",
                table: "UnderPages_TextContents",
                column: "UnderPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_TextContents_UserId",
                table: "UnderPages_TextContents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_titlecontents_UnderPageId",
                table: "UnderPages_titlecontents",
                column: "UnderPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_titlecontents_UserId",
                table: "UnderPages_titlecontents",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StartPage_ImgContents");

            migrationBuilder.DropTable(
                name: "StartPage_Links");

            migrationBuilder.DropTable(
                name: "StartPage_TextContents");

            migrationBuilder.DropTable(
                name: "StartPage_TitleContents");

            migrationBuilder.DropTable(
                name: "UnderPages_imgcontents");

            migrationBuilder.DropTable(
                name: "UnderPages_TextContents");

            migrationBuilder.DropTable(
                name: "UnderPages_titlecontents");

            migrationBuilder.DropTable(
                name: "StartPages");

            migrationBuilder.DropTable(
                name: "UnderPages");

            migrationBuilder.DropTable(
                name: "HeaderContent");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
