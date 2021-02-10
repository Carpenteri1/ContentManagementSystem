using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class Remove_Adverts_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AdvertsTitle = table.Column<string>(type: "text", nullable: true),
                    Edited = table.Column<DateTime>(type: "datetime", nullable: true),
                    ImgSrc = table.Column<string>(type: "text", nullable: true),
                    StartPageId = table.Column<int>(type: "int", nullable: true),
                    UnderPageId = table.Column<int>(type: "int", nullable: true),
                    Uploaded = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
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
    }
}
