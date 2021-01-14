using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class initlize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Surname = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImgModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ImgUrl = table.Column<string>(nullable: true),
                    ImgHeight = table.Column<int>(nullable: false),
                    ImgWidth = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImgModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImgModel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TextContent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TextContent_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TitleModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    TypeOfTitle = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TitleModel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PageModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TitleId = table.Column<int>(nullable: false),
                    TextContentId = table.Column<int>(nullable: false),
                    ImgId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageModel_ImgModel_ImgId",
                        column: x => x.ImgId,
                        principalTable: "ImgModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PageModel_TextContent_TextContentId",
                        column: x => x.TextContentId,
                        principalTable: "TextContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PageModel_TitleModel_TitleId",
                        column: x => x.TitleId,
                        principalTable: "TitleModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PageModel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImgModel_UserId",
                table: "ImgModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PageModel_ImgId",
                table: "PageModel",
                column: "ImgId");

            migrationBuilder.CreateIndex(
                name: "IX_PageModel_TextContentId",
                table: "PageModel",
                column: "TextContentId");

            migrationBuilder.CreateIndex(
                name: "IX_PageModel_TitleId",
                table: "PageModel",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_PageModel_UserId",
                table: "PageModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TextContent_UserId",
                table: "TextContent",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleModel_UserId",
                table: "TitleModel",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PageModel");

            migrationBuilder.DropTable(
                name: "ImgModel");

            migrationBuilder.DropTable(
                name: "TextContent");

            migrationBuilder.DropTable(
                name: "TitleModel");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
