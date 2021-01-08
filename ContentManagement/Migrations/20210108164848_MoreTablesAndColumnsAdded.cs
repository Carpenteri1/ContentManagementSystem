using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class MoreTablesAndColumnsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentName",
                table: "Content");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UserCreated",
                table: "Users",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Content",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Content",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Content",
                nullable: false,
                defaultValue: 0);

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
                name: "MergedContent",
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
                    table.PrimaryKey("PK_MergedContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MergedContent_ImgModel_ImgId",
                        column: x => x.ImgId,
                        principalTable: "ImgModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MergedContent_Content_TextContentId",
                        column: x => x.TextContentId,
                        principalTable: "Content",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MergedContent_TitleModel_TitleId",
                        column: x => x.TitleId,
                        principalTable: "TitleModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MergedContent_Users_UserId",
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
                    MergedContentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageModel_MergedContent_MergedContentId",
                        column: x => x.MergedContentId,
                        principalTable: "MergedContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Content_UserId",
                table: "Content",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImgModel_UserId",
                table: "ImgModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MergedContent_ImgId",
                table: "MergedContent",
                column: "ImgId");

            migrationBuilder.CreateIndex(
                name: "IX_MergedContent_TextContentId",
                table: "MergedContent",
                column: "TextContentId");

            migrationBuilder.CreateIndex(
                name: "IX_MergedContent_TitleId",
                table: "MergedContent",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_MergedContent_UserId",
                table: "MergedContent",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PageModel_MergedContentId",
                table: "PageModel",
                column: "MergedContentId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleModel_UserId",
                table: "TitleModel",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Content_Users_UserId",
                table: "Content",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Content_Users_UserId",
                table: "Content");

            migrationBuilder.DropTable(
                name: "PageModel");

            migrationBuilder.DropTable(
                name: "MergedContent");

            migrationBuilder.DropTable(
                name: "ImgModel");

            migrationBuilder.DropTable(
                name: "TitleModel");

            migrationBuilder.DropIndex(
                name: "IX_Content_UserId",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Content");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UserCreated",
                table: "Users",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Content",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentName",
                table: "Content",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
