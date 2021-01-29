using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class LinksTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "UnderPage_Links",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    underPageId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderPage_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderPage_Links_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnderPage_Links_UnderPages_underPageId",
                        column: x => x.underPageId,
                        principalTable: "UnderPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_Links_StartPageId",
                table: "StartPage_Links",
                column: "StartPageId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPage_Links_UserId",
                table: "StartPage_Links",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPage_Links_UserId",
                table: "UnderPage_Links",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPage_Links_underPageId",
                table: "UnderPage_Links",
                column: "underPageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StartPage_Links");

            migrationBuilder.DropTable(
                name: "UnderPage_Links");
        }
    }
}
