using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleProjectManager.Module.Migrations
{
    public partial class Migracion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "ProjectTasks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Testimonials",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "ProjectTasks",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "ProjectTasks",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "ProjectTasks",
                type: "timestamp with time zone",
                nullable: true);
        }
    }
}
