using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class ImageTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailImageUrl",
                table: "Venue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailImageUrl",
                table: "Facility",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FacilityImage",
                columns: table => new
                {
                    FacilityImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityImage", x => x.FacilityImageId);
                    table.ForeignKey(
                        name: "FK_FacilityImage_Facility_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facility",
                        principalColumn: "FacilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VenueImage",
                columns: table => new
                {
                    VenueImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VenueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueImage", x => x.VenueImageId);
                    table.ForeignKey(
                        name: "FK_VenueImage_Venue_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venue",
                        principalColumn: "VenueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4ad4ba3-d407-49bf-9206-f9a44f97faf2", "AQAAAAIAAYagAAAAEOMrv752Bov0wHeIiNj9J+EJ3zlLlhf1e/9fMuJMudaCdiD61jvMu320wZMeq+9uhQ==", "052f437b-79ed-43c2-80e7-dce102dc29d5" });

            migrationBuilder.CreateIndex(
                name: "IX_FacilityImage_FacilityId",
                table: "FacilityImage",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueImage_VenueId",
                table: "VenueImage",
                column: "VenueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacilityImage");

            migrationBuilder.DropTable(
                name: "VenueImage");

            migrationBuilder.DropColumn(
                name: "ThumbnailImageUrl",
                table: "Venue");

            migrationBuilder.DropColumn(
                name: "ThumbnailImageUrl",
                table: "Facility");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7431560-2ab5-418a-a401-3c7ab63a2b67", "AQAAAAIAAYagAAAAEBvjQQLRoexESm131hreYf7/BJ7BKP3tBNPOAGA0XMJfL8Tua5c2KuGAzuE9YUeveA==", "343ed21b-9d0b-49ee-97c7-b4028ad599e7" });
        }
    }
}
