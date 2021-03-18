using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class RemovedTablesAddeedFIleTOPageImageGallery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateIndex(
                name: "IX_UnderPage_ImgContents_UnderPageId",
                table: "UnderPage_ImgContents",
                column: "UnderPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPage_ImgContents_UserId",
                table: "UnderPage_ImgContents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPage_TextContents_UnderPageId",
                table: "UnderPage_TextContents",
                column: "UnderPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPage_TextContents_UserId",
                table: "UnderPage_TextContents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPage_TitleContents_UnderPageId",
                table: "UnderPage_TitleContents",
                column: "UnderPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderPage_TitleContents_UserId",
                table: "UnderPage_TitleContents",
                column: "UserId");
        }
    }
}
