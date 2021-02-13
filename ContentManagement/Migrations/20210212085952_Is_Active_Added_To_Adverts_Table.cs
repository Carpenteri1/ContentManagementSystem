using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagement.Migrations
{
    public partial class Is_Active_Added_To_Adverts_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TypeOfAd",
                table: "AdvertTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LinkTo",
                table: "Adverts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LinkTitle",
                table: "Adverts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Adverts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Adverts");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfAd",
                table: "AdvertTypes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LinkTo",
                table: "Adverts",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LinkTitle",
                table: "Adverts",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
