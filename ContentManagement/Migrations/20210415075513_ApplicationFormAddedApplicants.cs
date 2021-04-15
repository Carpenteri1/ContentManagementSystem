using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagement.Migrations
{
    public partial class ApplicationFormAddedApplicants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<int>(
                name: "applyedToEventId",
                table: "EventApplicants",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventApplicants_applyedToEventId",
                table: "EventApplicants",
                column: "applyedToEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventApplicants_Events_applyedToEventId",
                table: "EventApplicants",
                column: "applyedToEventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventApplicants_Events_applyedToEventId",
                table: "EventApplicants");

            migrationBuilder.DropIndex(
                name: "IX_EventApplicants_applyedToEventId",
                table: "EventApplicants");

            migrationBuilder.DropColumn(
                name: "applyedToEventId",
                table: "EventApplicants");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationFormModelId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_ApplicationFormModelId",
                table: "Events",
                column: "ApplicationFormModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventApplicants_ApplicationFormModelId",
                table: "Events",
                column: "ApplicationFormModelId",
                principalTable: "EventApplicants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
