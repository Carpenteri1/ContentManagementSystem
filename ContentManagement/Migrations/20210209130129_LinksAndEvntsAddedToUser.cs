using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagement.Migrations
{
    public partial class LinksAndEvntsAddedToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Events_Links",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LinkTitle",
                table: "Events_Links",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Events_Links",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EventTitle",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EventTextContent",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_Links_UserId",
                table: "Events_Links",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Links_Users_UserId",
                table: "Events_Links",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Links_Users_UserId",
                table: "Events_Links");

            migrationBuilder.DropIndex(
                name: "IX_Events_Links_UserId",
                table: "Events_Links");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Events_Links");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Events_Links",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LinkTitle",
                table: "Events_Links",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EventTitle",
                table: "Events",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EventTextContent",
                table: "Events",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
