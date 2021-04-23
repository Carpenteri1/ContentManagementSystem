using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagement.Migrations
{
    public partial class EventPageRouteAddedToEventTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "EventPageRoute",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventPageRoute",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "ApplicantId",
                table: "FileInfo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileInfo_ApplicantId",
                table: "FileInfo",
                column: "ApplicantId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileInfo_EventApplicants_ApplicantId",
                table: "FileInfo",
                column: "ApplicantId",
                principalTable: "EventApplicants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
