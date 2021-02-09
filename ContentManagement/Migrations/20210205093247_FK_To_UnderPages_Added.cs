using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagement.Migrations
{
    public partial class FK_To_UnderPages_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StartPageId",
                table: "UnderPages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnderPages_StartPageId",
                table: "UnderPages",
                column: "StartPageId");

            migrationBuilder.AddForeignKey(
                name: "FK_UnderPages_StartPages_StartPageId",
                table: "UnderPages",
                column: "StartPageId",
                principalTable: "StartPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnderPages_StartPages_StartPageId",
                table: "UnderPages");

            migrationBuilder.DropIndex(
                name: "IX_UnderPages_StartPageId",
                table: "UnderPages");

            migrationBuilder.DropColumn(
                name: "StartPageId",
                table: "UnderPages");
        }
    }
}
