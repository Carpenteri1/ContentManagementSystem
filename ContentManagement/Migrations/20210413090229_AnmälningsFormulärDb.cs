using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ContentManagement.Migrations
{
    public partial class AnmälningsFormulärDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicationFormModelId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EventApplicants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    GolfId = table.Column<int>(nullable: false),
                    HomeClubName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    GoodToknowInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventApplicants", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventApplicants_ApplicationFormModelId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "EventApplicants");

            migrationBuilder.DropIndex(
                name: "IX_Events_ApplicationFormModelId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ApplicationFormModelId",
                table: "Events");
        }
    }
}
