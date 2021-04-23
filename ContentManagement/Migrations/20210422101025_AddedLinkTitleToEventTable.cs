using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagement.Migrations
{
    public partial class AddedLinkTitleToEventTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "LinkTitle",
                table: "Events",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventLinkModel",
                table: "EventLinkModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventLinkModel_Events_EventModelId",
                table: "EventLinkModel",
                column: "EventModelId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventLinkModel_Users_UserId",
                table: "EventLinkModel",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventLinkModel_Events_EventModelId",
                table: "EventLinkModel");

            migrationBuilder.DropForeignKey(
                name: "FK_EventLinkModel_Users_UserId",
                table: "EventLinkModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventLinkModel",
                table: "EventLinkModel");

            migrationBuilder.DropColumn(
                name: "LinkTitle",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "EventLinkModel",
                newName: "Events_Links");

            migrationBuilder.RenameIndex(
                name: "IX_EventLinkModel_UserId",
                table: "Events_Links",
                newName: "IX_Events_Links_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EventLinkModel_EventModelId",
                table: "Events_Links",
                newName: "IX_Events_Links_EventModelId");

            migrationBuilder.AddColumn<string>(
                name: "LinkTitle",
                table: "Events_Links",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Events_Links",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events_Links",
                table: "Events_Links",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Links_Events_EventModelId",
                table: "Events_Links",
                column: "EventModelId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Links_Users_UserId",
                table: "Events_Links",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
