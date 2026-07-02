using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentPlanner.Web.Migrations
{
    /// <inheritdoc />
    public partial class ImproveAssignmentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Assignments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Assignments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Assignments");
        }
    }
}
