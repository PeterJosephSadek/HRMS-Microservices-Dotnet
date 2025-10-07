using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveRequestService.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4080), "Paid time off for vacation or rest", "Annual Leave" },
                    { 2, new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4092), "Leave for illness or medical appointments", "Sick Leave" },
                    { 3, new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4093), "Short-term leave for personal reasons", "Casual Leave" },
                    { 4, new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4094), "Leave for maternity-related reasons", "Maternity Leave" },
                    { 5, new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4095), "Leave without pay", "Unpaid Leave" }
                });

            migrationBuilder.InsertData(
                table: "RequestStatuses",
                columns: new[] { "Id", "CreatedAt", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4177), "Awaiting review or approval", "Pending" },
                    { 2, new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4179), "Request has been approved", "Approved" },
                    { 3, new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4180), "Request has been rejected", "Rejected" },
                    { 4, new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4181), "Request was cancelled by employee", "Cancelled" }
                });

            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "ApprovedAt", "CreatedAt", "DateEnd", "DateStart", "EmployeeId", "LeaveTypeId", "Reason", "RequestStatusId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4202), new DateOnly(2025, 10, 15), new DateOnly(2025, 10, 10), 1, 1, "Family vacation", 1, null },
                    { 2, new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4205), new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4204), new DateOnly(2025, 9, 28), new DateOnly(2025, 9, 25), 2, 2, "Flu recovery", 2, null },
                    { 3, null, new DateTime(2025, 10, 7, 12, 19, 32, 787, DateTimeKind.Local).AddTicks(4207), new DateOnly(2025, 10, 21), new DateOnly(2025, 10, 20), 3, 5, "Personal reason", 3, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RequestStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RequestStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RequestStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RequestStatuses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
