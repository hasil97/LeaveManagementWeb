using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedUsersAndRolesDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a6ac1256-96ee-4efa-8c92-f138480610af", "43f5eb78-9150-4b5c-9e69-c629dc3ec65e", "Administrator", "ADMINISTRATOR" },
                    { "f6ac0515-96ee-4efa-8c72-a290380610ea", "8877ee47-32c7-418e-be89-3bba14075b9c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d162da66-b0e3-49bb-9a4a-0863b3b19f8b", 0, "fcd0a837-fb04-4158-9f81-98dbd1b4ae39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", false, "System", "User", false, null, "USER@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJGChGdBO+rQ0b9f2R/C+bA1Avx5iYjLuSfgWlI6ns7xvNM+kz4pF8rsMyNFQEjqMg==", null, false, "b00566ab-d1c4-49ad-97a1-7298a4e998c5", null, false, null },
                    { "f6ac0515-96ee-4efa-8c72-f138480610cb", 0, "c52c2e18-ae19-4350-a4d9-a2b02f5056b9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1@gmail.com", false, "Admin1", "kevin", false, null, "ADMIN1@GMAIL.COM", null, "AQAAAAEAACcQAAAAEHbAcuMwQlAaaJgtj2UpkJ0M5y5O5EVzlp2jnqPURnTo62/z/OLKWCUH2kPwR7yEew==", null, false, "25484b7b-6ada-411a-ba66-5a53f8e21e45", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f6ac0515-96ee-4efa-8c72-a290380610ea", "d162da66-b0e3-49bb-9a4a-0863b3b19f8b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a6ac1256-96ee-4efa-8c92-f138480610af", "f6ac0515-96ee-4efa-8c72-f138480610cb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6ac0515-96ee-4efa-8c72-a290380610ea", "d162da66-b0e3-49bb-9a4a-0863b3b19f8b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a6ac1256-96ee-4efa-8c92-f138480610af", "f6ac0515-96ee-4efa-8c72-f138480610cb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6ac1256-96ee-4efa-8c92-f138480610af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-a290380610ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d162da66-b0e3-49bb-9a4a-0863b3b19f8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-f138480610cb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "", "033c4f27-a068-4057-aa2b-23c66f6e24fb", "Administrator", "ADMINISTRATOR" });
        }
    }
}
