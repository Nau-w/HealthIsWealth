using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class FacilViewing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageSource",
                table: "Venue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSource",
                table: "Facility",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageSource",
                table: "Venue");

            migrationBuilder.DropColumn(
                name: "ImageSource",
                table: "Facility");
        }
    }
}
