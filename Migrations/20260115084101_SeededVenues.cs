using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class SeededVenues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    SportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.SportId);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                columns: table => new
                {
                    VenueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.VenueId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    VenueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.FacilityId);
                    table.ForeignKey(
                        name: "FK_Facility_Venue_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venue",
                        principalColumn: "VenueId",
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
                name: "FacilitySport",
                columns: table => new
                {
                    FacilitySportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportId = table.Column<int>(type: "int", nullable: false),
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilitySport", x => x.FacilitySportId);
                    table.ForeignKey(
                        name: "FK_FacilitySport_Facility_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facility",
                        principalColumn: "FacilityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacilitySport_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Timeslot",
                columns: table => new
                {
                    TimeslotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timeslot", x => x.TimeslotId);
                    table.ForeignKey(
                        name: "FK_Timeslot_Facility_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facility",
                        principalColumn: "FacilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TimeslotId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Booking_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Booking_Timeslot_TimeslotId",
                        column: x => x.TimeslotId,
                        principalTable: "Timeslot",
                        principalColumn: "TimeslotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Review_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2dc34989-ddd0-4798-b567-63c77cb0dfb3", "test1@gmail.com", true, "test", "1", false, null, "TEST1@GMAIL.COM", "TEST1@GMAIL.COM", "AQAAAAIAAYagAAAAECjguqX6UdZrsFVXM71lpQWw1HYQW5PQPMXYm01nkHKTDjMgPfd26Vr6bIBGYo3JRg==", null, false, "18b01ae5-5243-42cb-a20b-a8c2ba08986f", false, "test1@gmail.com" },
                    { "6d3d2829-89fa-4095-b0f9-0ef8e802fd69", 0, "77d40f9f-60cf-4e63-aceb-f24a8d23aebb", "test2@gmail.com", true, "test", "2", false, null, "TEST2@GMAIL.COM", "TEST2@GMAIL.COM", "AQAAAAIAAYagAAAAEO0heYyj53y6Skv8gexmoa1gLi7ulij52vFPyp73ZHA7ZLU5rz9S2FUgcaAGUPF+4Q==", null, false, "aa363195-16b1-43f3-96e3-fc79ee116309", false, "test2@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "SportId", "Description", "Name", "ThumbnailImageUrl" },
                values: new object[,]
                {
                    { 1, "A fun sport, enjoyable by many and with many formats. For your next game, book a court today.", "Basketball", "images/sports/basketball.jpg" },
                    { 2, "An exciting racquet sport, enjoyable by all. Get your game on and book a court today.", "Badminton", "images/sports/badminton.jpg" },
                    { 3, "An enjoyable racquet sport with strategy and skill. Play with a friend and book a court today.", "Tennis", "images/sports/tennis.jpg" },
                    { 4, "A great sport for both fun and exercise. Cool down in the warm weather and book a pool today.", "Swimming", "images/sports/swimming.jpg" },
                    { 5, "A gym is a good place to concentrate and workout. Find a space to train with us today.", "Gym", "images/sports/gym.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueId", "Address", "Name", "PostalCode", "ThumbnailImageUrl", "UnitNumber" },
                values: new object[,]
                {
                    { 1, "211 Jurong East Street 21, Block 211, Singapore", "One Gym", "600021", "images/venues/one_gym_0.jpg", "#21-234" },
                    { 2, "57 Lor. 5 Toa Payoh, Block 57", "Court Complex", "310057", "images/venues/court_complex_0.jpg", "#57-575" },
                    { 3, "200 Commonwealth Ave W", "Pool Space", "138677", "images/venues/pool_space_0.jpg", "32" },
                    { 4, "33 Yio Chu Kang Rd", "Universe Sports", "545677", "images/venues/universe_sports_0.jpg", "" },
                    { 5, "1 Choa Chu Kang Street 53", "Diamond Hub", "689236", "images/venues/diamond_hub_0.jpg", "" }
                });

            migrationBuilder.InsertData(
                table: "Facility",
                columns: new[] { "FacilityId", "Location", "Name", "Price", "ThumbnailImageUrl", "VenueId" },
                values: new object[,]
                {
                    { 1, "01-01", "The Gym 1", 5f, "images/facilities/one_gym_0.jpg", 1 },
                    { 2, "01-02", "The Gym 2", 5f, "images/facilities/one_gym_0.jpg", 1 },
                    { 3, "02-01", "The Gym Premium", 10f, "images/facilities/one_gym_0.jpg", 1 },
                    { 4, "Level 2 MPH", "Court 1", 4f, "images/facilities/court_complex_0.jpg", 2 },
                    { 5, "Level 2 MPH", "Court 2", 4f, "images/facilities/court_complex_0.jpg", 2 },
                    { 6, "Level 2 MPH", "Basketball Court", 6f, "images/facilities/court_complex_bb_court.jpg", 2 },
                    { 7, "", "Private Pool", 8f, "images/facilities/pool_space_0.jpg", 3 },
                    { 8, "Level 3 MPH", "Court 1", 5f, "images/facilities/universe_sports_court.jpg", 4 },
                    { 9, "Level 3 MPH", "Court 2", 5f, "images/facilities/universe_sports_court.jpg", 4 },
                    { 10, "Level 3 MPH", "Court 3", 5f, "images/facilities/universe_sports_court.jpg", 4 },
                    { 11, "Level 2 MPH", "Basketball Court 1", 8f, "images/facilities/universe_sports_bb_court.jpg", 4 },
                    { 12, "Level 2 MPH", "Basketball Court 2", 8f, "images/facilities/universe_sports_bb_court.jpg", 4 },
                    { 13, "Ruby Wing 01-01", "Basketball Court 1", 8f, "images/facilities/diamond_hub_bb_court.jpg", 5 },
                    { 14, "Ruby Wing 01-02", "Basketball Court 2", 8f, "images/facilities/diamond_hub_bb_court.jpg", 5 },
                    { 15, "Sapphire Wing 01-01", "Luxury Pool 1", 32f, "images/facilities/diamond_hub_pool.jpg", 5 },
                    { 16, "Sapphire Wing 01-01", "Luxury Pool 2", 32f, "images/facilities/diamond_hub_pool.jpg", 5 },
                    { 17, "Emerald Wing 01-01", "Badminton Court 1", 10f, "images/facilities/diamond_hub_court.jpg", 5 },
                    { 18, "Emerald Wing 01-01", "Badminton Court 2", 10f, "images/facilities/diamond_hub_court.jpg", 5 },
                    { 19, "Gold Wing 01-01", "Luxury Private Gym", 20f, "images/facilities/diamond_hub_gym.jpg", 5 }
                });

            migrationBuilder.InsertData(
                table: "FacilitySport",
                columns: new[] { "FacilitySportId", "FacilityId", "SportId" },
                values: new object[,]
                {
                    { 1, 6, 1 },
                    { 2, 11, 1 },
                    { 3, 12, 1 },
                    { 4, 13, 1 },
                    { 5, 14, 1 },
                    { 6, 4, 2 },
                    { 7, 5, 2 },
                    { 8, 8, 2 },
                    { 9, 9, 2 },
                    { 10, 10, 2 },
                    { 11, 17, 2 },
                    { 12, 18, 2 },
                    { 13, 4, 3 },
                    { 14, 5, 3 },
                    { 15, 8, 3 },
                    { 16, 9, 3 },
                    { 17, 10, 3 },
                    { 18, 7, 4 },
                    { 19, 15, 4 },
                    { 20, 16, 4 },
                    { 21, 1, 5 },
                    { 22, 2, 5 },
                    { 23, 3, 5 },
                    { 24, 19, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TimeslotId",
                table: "Booking",
                column: "TimeslotId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserId",
                table: "Booking",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_VenueId",
                table: "Facility",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityImage_FacilityId",
                table: "FacilityImage",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitySport_FacilityId",
                table: "FacilitySport",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitySport_SportId",
                table: "FacilitySport",
                column: "SportId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_BookingId",
                table: "Review",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Timeslot_FacilityId",
                table: "Timeslot",
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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FacilityImage");

            migrationBuilder.DropTable(
                name: "FacilitySport");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "VenueImage");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Sport");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Timeslot");

            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "Venue");
        }
    }
}
