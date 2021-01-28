using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "HeaderMenus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StartPage_FK = table.Column<int>(nullable: false),
                    StartPageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeaderMenus_StartPages_StartPageId",
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
                    UserId = table.Column<int>(nullable: true),
                    StartPageId = table.Column<int>(nullable: true)
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
                name: "StartPage_TextContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    TextContent = table.Column<string>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    StartPageId = table.Column<int>(nullable: true)
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
                    UserId = table.Column<int>(nullable: true),
                    StartPageId = table.Column<int>(nullable: true)
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
                name: "HeaderTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    TextContent = table.Column<string>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    HeaderMenuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeaderTitles_HeaderMenus_HeaderMenuId",
                        column: x => x.HeaderMenuId,
                        principalTable: "HeaderMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HeaderTitles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeaderMenus_StartPageId",
                table: "HeaderMenus",
                column: "StartPageId");

            migrationBuilder.CreateIndex(
                name: "IX_HeaderTitles_HeaderMenuId",
                table: "HeaderTitles",
                column: "HeaderMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_HeaderTitles_UserId",
                table: "HeaderTitles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_ImgContents_StartPageId",
                table: "StartPage_ImgContents",
                column: "StartPageId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_ImgContents_UserId",
                table: "StartPage_ImgContents",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeaderTitles");

            migrationBuilder.DropTable(
                name: "StartPage_ImgContents");

            migrationBuilder.DropTable(
                name: "StartPage_TextContents");

            migrationBuilder.DropTable(
                name: "StartPage_TitleContents");

            migrationBuilder.DropTable(
                name: "HeaderMenus");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "StartPages");
        }
    }
}
