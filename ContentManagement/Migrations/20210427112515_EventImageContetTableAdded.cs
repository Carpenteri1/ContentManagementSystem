using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class EventImageContetTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adverts_ImageContents",
                table: "Adverts_ImageContents");

            migrationBuilder.AddColumn<string>(
                name: "ImgSrc",
                table: "Events",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adverts_ImageContent",
                table: "Adverts_ImageContent",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EventImageContentModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Uploaded = table.Column<DateTime>(nullable: false),
                    ImgSrc = table.Column<string>(nullable: true),
                    EventPageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventImageContentModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventImageContentModel_Events_EventPageId",
                        column: x => x.EventPageId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventImageContentModel_EventPageId",
                table: "EventImageContentModel",
                column: "EventPageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_ImageContent_Adverts_AdvertId",
                table: "Adverts_ImageContent",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_ImageContent_Users_UserId",
                table: "Adverts_ImageContent",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_ImageContent_Adverts_AdvertId",
                table: "Adverts_ImageContent");

            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_ImageContent_Users_UserId",
                table: "Adverts_ImageContent");

            migrationBuilder.DropTable(
                name: "EventImageContentModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adverts_ImageContent",
                table: "Adverts_ImageContent");

            migrationBuilder.DropColumn(
                name: "ImgSrc",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Adverts_ImageContent",
                newName: "Adverts_ImageContents");

            migrationBuilder.RenameIndex(
                name: "IX_Adverts_ImageContent_UserId",
                table: "Adverts_ImageContents",
                newName: "IX_Adverts_ImageContents_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Adverts_ImageContent_AdvertId",
                table: "Adverts_ImageContents",
                newName: "IX_Adverts_ImageContents_AdvertId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adverts_ImageContents",
                table: "Adverts_ImageContents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_ImageContents_Adverts_AdvertId",
                table: "Adverts_ImageContents",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_ImageContents_Users_UserId",
                table: "Adverts_ImageContents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
