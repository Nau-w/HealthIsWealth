using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class ProfilePictureSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "6eefe038-640c-46ef-8dc2-501dd2587bcc", "AQAAAAIAAYagAAAAEFpodF1cGvp6qR+sGHALs38lEOHTzRTwLrz5i9gx0wPvc7EyR3TziR12wpHzTLg7Ew==", "/images/ProfilePicture/backgroundImage.jpg", "5d3b3537-985e-4cdc-b631-057d8f8c3f71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "b61546de-7d78-4721-8167-34f33e4eb6f1", "AQAAAAIAAYagAAAAEHq8wcDjmBmErbkuwwM4g352QPe9Oy+GLH4jpC/BqysnDSLr1dbHdORf3qYB7yrVUg==", "/images/ProfilePicture/Dog Icon.jpeg", "a9d53481-342a-4d3a-aa91-165b38ba0a42" });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 1,
                columns: new[] { "EndDT", "StartDT" },
                values: new object[] { new DateTime(2026, 1, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 2,
                columns: new[] { "EndDT", "FacilityId", "StartDT" },
                values: new object[] { new DateTime(2024, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 3,
                columns: new[] { "EndDT", "FacilityId", "StartDT" },
                values: new object[] { new DateTime(2024, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "0e5a2347-8e41-4d0d-a199-96f1a5c5bbba", "AQAAAAIAAYagAAAAEMxbXB0jSVgc8zZACNUNDNSmKYUxtXyzZR8d4GwDKfySyO3HLsPI9EvfqznAkw/ATg==", null, "0f991472-fbb0-4220-a597-9e884fd1def7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "07dab716-d0c2-40e7-9b0b-f297d839d68e", "AQAAAAIAAYagAAAAEIBb4FXdK/P8Y24p+VW4rtrgFy6NTKCP8dus1sDEstUgPEe8S/bY5OPtjgCspMKjlw==", null, "61913ab8-8bd7-4ded-8b18-822b90ac35e9" });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 1,
                columns: new[] { "EndDT", "StartDT" },
                values: new object[] { new DateTime(2025, 1, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 2,
                columns: new[] { "EndDT", "FacilityId", "StartDT" },
                values: new object[] { new DateTime(2025, 1, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2025, 1, 19, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 3,
                columns: new[] { "EndDT", "FacilityId", "StartDT" },
                values: new object[] { new DateTime(2025, 1, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2025, 1, 12, 13, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
