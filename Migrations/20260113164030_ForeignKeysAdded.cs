using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
    public partial class ForeignKeysAdded : Migration
========
    public partial class Initial2 : Migration
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs
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
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
                name: "Booking",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeslotId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingId);
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
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                });

            migrationBuilder.CreateTable(
========
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs
                name: "Sport",
                columns: table => new
                {
                    SportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
========
                name: "FacilitySport",
                columns: table => new
                {
                    FacilitySportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportId = table.Column<int>(type: "int", nullable: false),
                    VenueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilitySport", x => x.FacilitySportId);
                    table.ForeignKey(
                        name: "FK_FacilitySport_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacilitySport_Venue_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venue",
                        principalColumn: "VenueId");
                });

            migrationBuilder.CreateTable(
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs
                name: "Facility",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
                    VenueId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
========
                    Price = table.Column<float>(type: "real", nullable: false),
                    VenueId = table.Column<int>(type: "int", nullable: false),
                    FacilitySportId = table.Column<int>(type: "int", nullable: false)
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.FacilityId);
                    table.ForeignKey(
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
========
                        name: "FK_Facility_FacilitySport_FacilitySportId",
                        column: x => x.FacilitySportId,
                        principalTable: "FacilitySport",
                        principalColumn: "FacilitySportId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs
                        name: "FK_Facility_Venue_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venue",
                        principalColumn: "VenueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
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
========
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs
                name: "Timeslot",
                columns: table => new
                {
                    TimeslotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDT = table.Column<DateTime>(type: "datetime2", nullable: false),
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
                    FacilityId = table.Column<int>(type: "int", nullable: false)
========
                    FacilityId = table.Column<int>(type: "int", nullable: false),
                    VenueId = table.Column<int>(type: "int", nullable: false)
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs
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
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
========
                    table.ForeignKey(
                        name: "FK_Timeslot_Venue_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venue",
                        principalColumn: "VenueId");
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
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d7431560-2ab5-418a-a401-3c7ab63a2b67", "test1@localhost.com", true, "test", "1", false, null, "TEST1@LOCALHOST.COM", "TEST1@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBvjQQLRoexESm131hreYf7/BJ7BKP3tBNPOAGA0XMJfL8Tua5c2KuGAzuE9YUeveA==", null, false, "343ed21b-9d0b-49ee-97c7-b4028ad599e7", false, "test1@localhost.com" });
========
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "bf953795-bd5d-4b22-9134-0baee0686f76", "test1@gmail.com", true, "test", "1", false, null, "TEST1@GMAIL.COM", "TEST1@GMAIL.COM", "AQAAAAIAAYagAAAAEMxbXB0jSVgc8zZACNUNDNSmKYUxtXyzZR8d4GwDKfySyO3HLsPI9EvfqznAkw/ATg==", null, false, "0f991472-fbb0-4220-a597-9e884fd1def7", false, "test1@gmail.com" },
                    { "6d3d2829-89fa-4095-b0f9-0ef8e802fd69", 0, "07dab716-d0c2-40e7-9b0b-f297d839d68e", "test2@gmail.com", true, "test", "2", false, null, "TEST2@GMAIL.COM", "TEST2@GMAIL.COM", "AQAAAAIAAYagAAAAEIBb4FXdK/P8Y24p+VW4rtrgFy6NTKCP8dus1sDEstUgPEe8S/bY5OPtjgCspMKjlw==", null, false, "61913ab8-8bd7-4ded-8b18-822b90ac35e9", false, "test2@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "SportId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Badminton is a fast-paced racket sport where players hit a shuttlecock (or birdie) over a net, aiming to land it in the opponent's court, playable in singles (one-on-one) or doubles (two-on-two).", "Badminton" },
                    { 2, "Basketball is a fast-paced, popular team sport where two teams of five players score by shooting a ball through an elevated hoop, using dribbling, passing, and shooting on a rectangular court, aiming to outscore opponents within timed periods.", "Basketball" }
                });

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueId", "Address", "PostalCode", "UnitNumber" },
                values: new object[] { 1, "Sambawang", "123456", "01-1234" });

            migrationBuilder.InsertData(
                table: "FacilitySport",
                columns: new[] { "FacilitySportId", "SportId", "VenueId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Facility",
                columns: new[] { "FacilityId", "FacilitySportId", "Location", "Name", "Price", "VenueId" },
                values: new object[,]
                {
                    { 1, 1, "Hall A", "Multipurpose Hall", 0f, 1 },
                    { 2, 2, "Hall A", "Multipurpose Hall", 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Timeslot",
                columns: new[] { "TimeslotId", "EndDT", "FacilityId", "StartDT", "VenueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2024, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2024, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs

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
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
========
                name: "IX_Booking_TimeslotId",
                table: "Booking",
                column: "TimeslotId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserId",
                table: "Booking",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_FacilitySportId",
                table: "Facility",
                column: "FacilitySportId");

            migrationBuilder.CreateIndex(
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs
                name: "IX_Facility_VenueId",
                table: "Facility",
                column: "VenueId");

            migrationBuilder.CreateIndex(
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
                name: "IX_FacilitySport_FacilityId",
                table: "FacilitySport",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
========
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs
                name: "IX_FacilitySport_SportId",
                table: "FacilitySport",
                column: "SportId");

            migrationBuilder.CreateIndex(
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
                name: "IX_Timeslot_FacilityId",
                table: "Timeslot",
                column: "FacilityId");
========
                name: "IX_FacilitySport_VenueId",
                table: "FacilitySport",
                column: "VenueId");

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
                name: "IX_Timeslot_VenueId",
                table: "Timeslot",
                column: "VenueId");
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs
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
                name: "Review");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
<<<<<<<< HEAD:Migrations/20260113164030_ForeignKeysAdded.cs
                name: "FacilitySport");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Timeslot");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Sport");

            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
========
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Timeslot");

            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "FacilitySport");

            migrationBuilder.DropTable(
                name: "Sport");

            migrationBuilder.DropTable(
>>>>>>>> fdb8d118d97a38006f96233f2ea5a2f8540a77c2:Migrations/20260112084823_Initial2.cs
                name: "Venue");
        }
    }
}
