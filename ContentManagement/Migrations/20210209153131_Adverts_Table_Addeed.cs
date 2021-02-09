using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class Adverts_Table_Addeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AdvertsTitle = table.Column<string>(nullable: true),
                    Uploaded = table.Column<DateTime>(nullable: false),
                    ImgSrc = table.Column<string>(nullable: true),
                    StartPageId = table.Column<int>(nullable: true),
                    UnderPageId = table.Column<int>(nullable: true),
                    Edited = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adverts_StartPages_StartPageId",
                        column: x => x.StartPageId,
                        principalTable: "StartPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adverts_UnderPages_UnderPageId",
                        column: x => x.UnderPageId,
                        principalTable: "UnderPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adverts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_StartPageId",
                table: "Adverts",
                column: "StartPageId");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_UnderPageId",
                table: "Adverts",
                column: "UnderPageId");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_UserId",
                table: "Adverts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");
        }
    }
}
