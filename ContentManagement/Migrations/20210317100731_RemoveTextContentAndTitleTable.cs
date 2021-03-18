using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagement.Migrations
{
    public partial class RemoveTextContentAndTitleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnderPages_TextContents_UnderPages_UnderPageId",
                table: "UnderPages_TextContents");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderPages_TextContents_Users_UserId",
                table: "UnderPages_TextContents");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderPages_titlecontents_UnderPages_UnderPageId",
                table: "UnderPages_titlecontents");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderPages_titlecontents_Users_UserId",
                table: "UnderPages_titlecontents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnderPages_titlecontents",
                table: "UnderPages_titlecontents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnderPages_TextContents",
                table: "UnderPages_TextContents");

            migrationBuilder.RenameTable(
                name: "UnderPages_titlecontents",
                newName: "UnderPage_TitleContents");

            migrationBuilder.RenameTable(
                name: "UnderPages_TextContents",
                newName: "UnderPage_TextContents");

            migrationBuilder.RenameIndex(
                name: "IX_UnderPages_titlecontents_UserId",
                table: "UnderPage_TitleContents",
                newName: "IX_UnderPage_TitleContents_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UnderPages_titlecontents_UnderPageId",
                table: "UnderPage_TitleContents",
                newName: "IX_UnderPage_TitleContents_UnderPageId");

            migrationBuilder.RenameIndex(
                name: "IX_UnderPages_TextContents_UserId",
                table: "UnderPage_TextContents",
                newName: "IX_UnderPage_TextContents_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UnderPages_TextContents_UnderPageId",
                table: "UnderPage_TextContents",
                newName: "IX_UnderPage_TextContents_UnderPageId");

            migrationBuilder.AddColumn<string>(
                name: "PageTitle",
                table: "UnderPages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextContent",
                table: "UnderPages",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnderPage_TitleContents",
                table: "UnderPage_TitleContents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnderPage_TextContents",
                table: "UnderPage_TextContents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnderPage_TextContents_UnderPages_UnderPageId",
                table: "UnderPage_TextContents",
                column: "UnderPageId",
                principalTable: "UnderPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderPage_TextContents_Users_UserId",
                table: "UnderPage_TextContents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderPage_TitleContents_UnderPages_UnderPageId",
                table: "UnderPage_TitleContents",
                column: "UnderPageId",
                principalTable: "UnderPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderPage_TitleContents_Users_UserId",
                table: "UnderPage_TitleContents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnderPage_TextContents_UnderPages_UnderPageId",
                table: "UnderPage_TextContents");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderPage_TextContents_Users_UserId",
                table: "UnderPage_TextContents");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderPage_TitleContents_UnderPages_UnderPageId",
                table: "UnderPage_TitleContents");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderPage_TitleContents_Users_UserId",
                table: "UnderPage_TitleContents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnderPage_TitleContents",
                table: "UnderPage_TitleContents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnderPage_TextContents",
                table: "UnderPage_TextContents");

            migrationBuilder.DropColumn(
                name: "PageTitle",
                table: "UnderPages");

            migrationBuilder.DropColumn(
                name: "TextContent",
                table: "UnderPages");

            migrationBuilder.RenameTable(
                name: "UnderPage_TitleContents",
                newName: "UnderPages_titlecontents");

            migrationBuilder.RenameTable(
                name: "UnderPage_TextContents",
                newName: "UnderPages_TextContents");

            migrationBuilder.RenameIndex(
                name: "IX_UnderPage_TitleContents_UserId",
                table: "UnderPages_titlecontents",
                newName: "IX_UnderPages_titlecontents_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UnderPage_TitleContents_UnderPageId",
                table: "UnderPages_titlecontents",
                newName: "IX_UnderPages_titlecontents_UnderPageId");

            migrationBuilder.RenameIndex(
                name: "IX_UnderPage_TextContents_UserId",
                table: "UnderPages_TextContents",
                newName: "IX_UnderPages_TextContents_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UnderPage_TextContents_UnderPageId",
                table: "UnderPages_TextContents",
                newName: "IX_UnderPages_TextContents_UnderPageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnderPages_titlecontents",
                table: "UnderPages_titlecontents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnderPages_TextContents",
                table: "UnderPages_TextContents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnderPages_TextContents_UnderPages_UnderPageId",
                table: "UnderPages_TextContents",
                column: "UnderPageId",
                principalTable: "UnderPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderPages_TextContents_Users_UserId",
                table: "UnderPages_TextContents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderPages_titlecontents_UnderPages_UnderPageId",
                table: "UnderPages_titlecontents",
                column: "UnderPageId",
                principalTable: "UnderPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderPages_titlecontents_Users_UserId",
                table: "UnderPages_titlecontents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
