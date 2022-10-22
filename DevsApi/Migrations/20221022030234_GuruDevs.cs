using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevsApi.Migrations
{
    public partial class GuruDevs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DevsHeroes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "ProgrammingLanguage", "Project", "location" },
                values: new object[] { 1, "AbuBakarr Kamara", new DateTime(2022, 10, 21, 20, 2, 33, 967, DateTimeKind.Local).AddTicks(4592), "Emmanuel Foday Kamara", "Python", "AI EXPLORATION", "Locust Junction, Quarry." });

            migrationBuilder.InsertData(
                table: "DevsHeroes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "ProgrammingLanguage", "Project", "location" },
                values: new object[] { 2, "AbuBakarr Kamara", new DateTime(2022, 10, 21, 20, 2, 33, 967, DateTimeKind.Local).AddTicks(4642), "AbuBakarr Kamara", ".net", "AI EXPLORATION", " Junction, Quarry." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DevsHeroes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DevsHeroes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
