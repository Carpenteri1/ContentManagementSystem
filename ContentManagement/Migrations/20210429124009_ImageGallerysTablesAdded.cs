using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class ImageGallerysTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextContent",
                table: "UnderPages_TextContents");

            migrationBuilder.AddColumn<int>(
                name: "ImageGalleryId",
                table: "UnderPages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PageTitle",
                table: "UnderPages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextContent",
                table: "UnderPages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageImageGalleryId",
                table: "StartPages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageGalleryId",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "advertImageGalleryId",
                table: "Adverts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdvertImageGallery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Uploaded = table.Column<DateTime>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    EventModelId = table.Column<int>(nullable: true),
                    UnderPageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertImageGallery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertImageGallery_Events_EventModelId",
                        column: x => x.EventModelId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdvertImageGallery_UnderPages_UnderPageId",
                        column: x => x.UnderPageId,
                        principalTable: "UnderPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PageImageGallery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Uploaded = table.Column<DateTime>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageImageGallery", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_ImageGalleryId",
                table: "UnderPages",
                column: "ImageGalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPages_PageImageGalleryId",
                table: "StartPages",
                column: "PageImageGalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ImageGalleryId",
                table: "Events",
                column: "ImageGalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_advertImageGalleryId",
                table: "Adverts",
                column: "advertImageGalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertImageGallery_EventModelId",
                table: "AdvertImageGallery",
                column: "EventModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertImageGallery_UnderPageId",
                table: "AdvertImageGallery",
                column: "UnderPageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_AdvertImageGallery_advertImageGalleryId",
                table: "Adverts",
                column: "advertImageGalleryId",
                principalTable: "AdvertImageGallery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_PageImageGallery_ImageGalleryId",
                table: "Events",
                column: "ImageGalleryId",
                principalTable: "PageImageGallery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StartPages_PageImageGallery_PageImageGalleryId",
                table: "StartPages",
                column: "PageImageGalleryId",
                principalTable: "PageImageGallery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderPages_PageImageGallery_ImageGalleryId",
                table: "UnderPages",
                column: "ImageGalleryId",
                principalTable: "PageImageGallery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_AdvertImageGallery_advertImageGalleryId",
                table: "Adverts");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_PageImageGallery_ImageGalleryId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_StartPages_PageImageGallery_PageImageGalleryId",
                table: "StartPages");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderPages_PageImageGallery_ImageGalleryId",
                table: "UnderPages");

            migrationBuilder.DropTable(
                name: "AdvertImageGallery");

            migrationBuilder.DropTable(
                name: "PageImageGallery");

            migrationBuilder.DropIndex(
                name: "IX_UnderPages_ImageGalleryId",
                table: "UnderPages");

            migrationBuilder.DropIndex(
                name: "IX_StartPages_PageImageGalleryId",
                table: "StartPages");

            migrationBuilder.DropIndex(
                name: "IX_Events_ImageGalleryId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Adverts_advertImageGalleryId",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "ImageGalleryId",
                table: "UnderPages");

            migrationBuilder.DropColumn(
                name: "PageTitle",
                table: "UnderPages");

            migrationBuilder.DropColumn(
                name: "TextContent",
                table: "UnderPages");

            migrationBuilder.DropColumn(
                name: "PageImageGalleryId",
                table: "StartPages");

            migrationBuilder.DropColumn(
                name: "ImageGalleryId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "advertImageGalleryId",
                table: "Adverts");

            migrationBuilder.AddColumn<string>(
                name: "TextContent",
                table: "UnderPages_TextContents",
                type: "text",
                nullable: true);
        }
    }
}
