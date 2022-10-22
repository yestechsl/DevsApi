using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevsApi.Migrations
{
    public partial class Devs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Place",
                table: "DevsHeroes",
                newName: "location");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "DevsHeroes",
                newName: "Project");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "DevsHeroes",
                newName: "ProgrammingLanguage");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DevsHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DevsHeroes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DevsHeroes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DevsHeroes");

            migrationBuilder.RenameColumn(
                name: "location",
                table: "DevsHeroes",
                newName: "Place");

            migrationBuilder.RenameColumn(
                name: "Project",
                table: "DevsHeroes",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "ProgrammingLanguage",
                table: "DevsHeroes",
                newName: "FirstName");
        }
    }
}
