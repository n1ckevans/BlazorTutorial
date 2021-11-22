using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace EmployeeManagement.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Ryhtmn Guitar" },
                    { 2, "Lead Guitar" },
                    { 3, "Bass Guitar" },
                    { 4, "Drums" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1969, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "John@beatles.com", "John", 0, "Lennon", "images/john.jpg" },
                    { 2, new DateTime(1969, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Geroge@beatles.com", "George", 0, "Harrison", "images/george.jpg" },
                    { 3, new DateTime(1969, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Paul@beatles.com", "Paul", 0, "McCartney", "images/paul.jpg" },
                    { 4, new DateTime(1969, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Ringo@beatles.com", "Ringo", 0, "Starr", "images/ringo.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
