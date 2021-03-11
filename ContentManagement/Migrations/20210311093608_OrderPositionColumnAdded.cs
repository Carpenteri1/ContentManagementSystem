using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagement.Migrations
{
    public partial class OrderPositionColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderPosition",
                table: "UnderPages",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderPosition",
                table: "UnderPages");
        }
    }
}
