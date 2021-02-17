using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class EventPageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventPageModelId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EventPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventPageModelId",
                table: "Events",
                column: "EventPageModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventPages_EventPageModelId",
                table: "Events",
                column: "EventPageModelId",
                principalTable: "EventPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventPages_EventPageModelId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "EventPages");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventPageModelId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventPageModelId",
                table: "Events");
        }
    }
}
