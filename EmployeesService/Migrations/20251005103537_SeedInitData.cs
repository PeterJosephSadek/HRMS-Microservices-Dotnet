using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeesService.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 5, 12, 35, 37, 104, DateTimeKind.Local).AddTicks(9341), "Handles employee management, payroll, and company culture.", true, "Human Resources" },
                    { 2, new DateTime(2025, 10, 5, 12, 35, 37, 104, DateTimeKind.Local).AddTicks(9361), "Manages infrastructure, applications, and software development.", true, "IT Department" },
                    { 3, new DateTime(2025, 10, 5, 12, 35, 37, 104, DateTimeKind.Local).AddTicks(9362), "Responsible for budgeting, financial planning, and reporting.", true, "Finance" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedAt", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "HireDate", "LastName", "ManagerId", "PhoneNumber", "PositionId", "Salary", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "123 Main St", "Cairo", "Egypt", new DateTime(2025, 10, 5, 12, 35, 37, 104, DateTimeKind.Local).AddTicks(9505), new DateOnly(1990, 5, 20), 2, "john.doe@company.com", "John", "Male", new DateOnly(2020, 1, 15), "Doe", null, "01000000000", 1, 8000m, null },
                    { 2, "456 Nile St", "Alexandria", "Egypt", new DateTime(2025, 10, 5, 12, 35, 37, 104, DateTimeKind.Local).AddTicks(9543), new DateOnly(1994, 7, 10), 1, "sara.ahmed@company.com", "Sara", "Female", new DateOnly(2021, 6, 1), "Ahmed", 1, "01011111111", 2, 7500m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
