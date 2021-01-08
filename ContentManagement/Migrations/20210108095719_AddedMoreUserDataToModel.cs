﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentManagement.Migrations
{
    public partial class AddedMoreUserDataToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoggedIn",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UserCreated",
                table: "Users",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastLoggedIn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserCreated",
                table: "Users");
        }
    }
}