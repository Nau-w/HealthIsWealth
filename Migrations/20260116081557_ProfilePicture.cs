using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class ProfilePicture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "0e5a2347-8e41-4d0d-a199-96f1a5c5bbba", "AQAAAAIAAYagAAAAEOYrJpANUEq4lskE4p7jZhsuITdWb9SK/wbUNCsFTA77aarZkTAIJQptRubQiXxy8w==", null, "1781acf5-f66f-40e2-a841-cd40995334d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "d6d49f62-0bf1-413b-9887-ac220eac17a7", "AQAAAAIAAYagAAAAEBQwLO27Ftp/fDRs3FcrG1a0zALO/TIso6i02BiVsYNZmYxLhyWBda0anr9kmDnpEA==", null, "a6eafda6-c189-4d74-af14-ab4ba595fb6e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePictureUrl",
                table: "AspNetUsers");

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
        }
    }
}
