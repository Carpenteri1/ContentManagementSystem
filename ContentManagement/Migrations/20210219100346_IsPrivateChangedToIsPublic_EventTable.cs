using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagement.Migrations
{
    public partial class IsPrivateChangedToIsPublic_EventTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPrivate",
                table: "Events");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Events",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Events");

            migrationBuilder.AddColumn<bool>(
                name: "IsPrivate",
                table: "Events",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
