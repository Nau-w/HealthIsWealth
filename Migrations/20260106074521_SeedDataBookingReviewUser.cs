using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataBookingReviewUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "a51e1dfe-cff3-443e-9955-41923b1106d8", "test1@localhost.com", true, "test", "1", false, null, "TEST1@LOCALHOST.COM", "TEST1@LOCALHOST.COM", "AQAAAAIAAYagAAAAEC0yxmTmnRKHBHztcIO61H1jY4yOR1q7QIhMmES61qJV53ugAvLWA7tX7l3Q9wPrxQ==", null, false, "86aa2e4d-18f7-42b9-832b-a8055e96516a", false, "test1@localhost.com" });

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
                    { 1, 1, "Good facility venue has a lot of ammenities", 4.5f, "6d3d2829-89fa-4095-b0f9-0ef8e802fd69" },
                    { 2, 2, "Dirty equipments but gym has alot of machines", 4f, "6d3d2829-89fa-4095-b0f9-0ef8e802fd69" },
                    { 3, 3, "Best volleyball court ever", 5f, "3781efa7-66dc-47f0-860f-e506d04102e4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

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

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Review");
        }
    }
}
