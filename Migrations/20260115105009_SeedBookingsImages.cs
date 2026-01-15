using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class SeedBookingsImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "062fb1e9-f4d8-49d0-85b4-b975524b3ec6", "AQAAAAIAAYagAAAAEGldk6SM3FD48xVMwBIwvaFEbkKa68uXyJNz336mDmaNN4tvihdqlTXAEDoacFTmJw==", "af814fb1-845e-4b8d-9114-6a8c98484963" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e11d2cfb-e145-461c-a413-0d4503f21d05", "AQAAAAIAAYagAAAAEGqRxj1jSMbCJ1rH1WhLLTy5PWZao2JTJCHg1CH4oND+VhUK54oG7pwVvUhjpvP2Yg==", "d45dc100-7d8d-45d5-961f-a9d1e536b80a" });

            migrationBuilder.InsertData(
                table: "Timeslot",
                columns: new[] { "TimeslotId", "EndDT", "FacilityId", "StartDT" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 1, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 1, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2025, 1, 19, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2025, 1, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2025, 1, 12, 13, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "TimeslotId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "6d3d2829-89fa-4095-b0f9-0ef8e802fd69" },
                    { 2, 2, "6d3d2829-89fa-4095-b0f9-0ef8e802fd69" },
                    { 3, 3, "3781efa7-66dc-47f0-860f-e506d04102e4" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "BookingId", "Feedback", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Dirty equipments but gym has alot of machines", 3.5f, "6d3d2829-89fa-4095-b0f9-0ef8e802fd69" },
                    { 2, 2, "Good location", 4f, "6d3d2829-89fa-4095-b0f9-0ef8e802fd69" },
                    { 3, 3, "Amazing pool", 5f, "3781efa7-66dc-47f0-860f-e506d04102e4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dc34989-ddd0-4798-b567-63c77cb0dfb3", "AQAAAAIAAYagAAAAECjguqX6UdZrsFVXM71lpQWw1HYQW5PQPMXYm01nkHKTDjMgPfd26Vr6bIBGYo3JRg==", "18b01ae5-5243-42cb-a20b-a8c2ba08986f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77d40f9f-60cf-4e63-aceb-f24a8d23aebb", "AQAAAAIAAYagAAAAEO0heYyj53y6Skv8gexmoa1gLi7ulij52vFPyp73ZHA7ZLU5rz9S2FUgcaAGUPF+4Q==", "aa363195-16b1-43f3-96e3-fc79ee116309" });
        }
    }
}
