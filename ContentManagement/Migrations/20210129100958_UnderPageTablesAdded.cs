using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class UnderPageTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeaderTitles");

            migrationBuilder.DropTable(
                name: "HeaderMenus");

            migrationBuilder.CreateTable(
                name: "StartPage_HeaderMenus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StartPageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartPage_HeaderMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartPage_HeaderMenus_StartPages_StartPageId",
                        column: x => x.StartPageId,
                        principalTable: "StartPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnderPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StartPage_HeaderTitels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    TextContent = table.Column<string>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    HeaderMenuId = table.Column<int>(nullable: true),
                    UsersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartPage_HeaderTitels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartPage_HeaderTitels_StartPage_HeaderMenus_HeaderMenuId",
                        column: x => x.HeaderMenuId,
                        principalTable: "StartPage_HeaderMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StartPage_HeaderTitels_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnderPage_HeaderMenus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UnderPageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderPage_HeaderMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderPage_HeaderMenus_UnderPages_UnderPageId",
                        column: x => x.UnderPageId,
                        principalTable: "UnderPages",
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
                    UnderPageId = table.Column<int>(nullable: true)
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
                    UnderPageId = table.Column<int>(nullable: true)
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
                    UnderPageId = table.Column<int>(nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "UnderPage_HeaderTitels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    TextContent = table.Column<string>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    HeaderMenuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderPage_HeaderTitels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderPage_HeaderTitels_UnderPage_HeaderMenus_HeaderMenuId",
                        column: x => x.HeaderMenuId,
                        principalTable: "UnderPage_HeaderMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_HeaderMenus_StartPageId",
                table: "StartPage_HeaderMenus",
                column: "StartPageId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_HeaderTitels_HeaderMenuId",
                table: "StartPage_HeaderTitels",
                column: "HeaderMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_HeaderTitels_UsersId",
                table: "StartPage_HeaderTitels",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPage_HeaderMenus_UnderPageId",
                table: "UnderPage_HeaderMenus",
                column: "UnderPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPage_HeaderTitels_HeaderMenuId",
                table: "UnderPage_HeaderTitels",
                column: "HeaderMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_imgcontents_UnderPageId",
                table: "UnderPages_imgcontents",
                column: "UnderPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_TextContents_UnderPageId",
                table: "UnderPages_TextContents",
                column: "UnderPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_titlecontents_UnderPageId",
                table: "UnderPages_titlecontents",
                column: "UnderPageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StartPage_HeaderTitels");

            migrationBuilder.DropTable(
                name: "UnderPage_HeaderTitels");

            migrationBuilder.DropTable(
                name: "UnderPages_imgcontents");

            migrationBuilder.DropTable(
                name: "UnderPages_TextContents");

            migrationBuilder.DropTable(
                name: "UnderPages_titlecontents");

            migrationBuilder.DropTable(
                name: "StartPage_HeaderMenus");

            migrationBuilder.DropTable(
                name: "UnderPage_HeaderMenus");

            migrationBuilder.DropTable(
                name: "UnderPages");

            migrationBuilder.CreateTable(
                name: "HeaderMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StartPageId = table.Column<int>(type: "int", nullable: true),
                    StartPage_FK = table.Column<int>(type: "int", nullable: false)
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
                name: "HeaderTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false),
                    Edited = table.Column<DateTime>(type: "datetime", nullable: true),
                    HeaderMenuId = table.Column<int>(type: "int", nullable: true),
                    TextContent = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
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
        }
    }
}
