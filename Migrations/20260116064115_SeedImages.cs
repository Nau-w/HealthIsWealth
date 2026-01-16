using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class SeedImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac14bef9-be6e-44cc-b190-d4662c898dde", "AQAAAAIAAYagAAAAEMG/LeTZ7goUUzkrdw/p4V78BTK0AtuwQcEc7xGzfLhVX75hvCoh7hXuiXFi0DZNOw==", "dfdd54b5-9803-447f-9853-65f2fab79ec0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00238a1b-1c0f-4607-b2f0-3f0a202267a5", "AQAAAAIAAYagAAAAEEli2myVF7YkfD4JwGEiFs4A/nQi3cG3XGhBFwV0jMOwgVVjF7NkgrODV7amPwFV8A==", "7421ade1-442e-4903-b7de-fa3f20c04d85" });

            migrationBuilder.InsertData(
                table: "FacilityImage",
                columns: new[] { "FacilityImageId", "FacilityId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 19, "images/facilities/diamond_hub_gym_1.jpg" },
                    { 2, 19, "images/facilities/diamond_hub_gym_2.jpg" },
                    { 3, 3, "images/facilities/one_gym_1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "VenueImage",
                columns: new[] { "VenueImageId", "ImageUrl", "VenueId" },
                values: new object[,]
                {
                    { 1, "images/venues/pool_space_1.jpg", 3 },
                    { 2, "images/venues/pool_space_2.jpg", 3 },
                    { 3, "images/venues/universe_sports_1.jpg", 4 },
                    { 4, "images/venues/diamond_hub_1.jpg", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FacilityImage",
                keyColumn: "FacilityImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FacilityImage",
                keyColumn: "FacilityImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FacilityImage",
                keyColumn: "FacilityImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VenueImage",
                keyColumn: "VenueImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VenueImage",
                keyColumn: "VenueImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VenueImage",
                keyColumn: "VenueImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VenueImage",
                keyColumn: "VenueImageId",
                keyValue: 4);

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
        }
    }
}
