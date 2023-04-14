using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedUsersAndRolesDefault1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6ac1256-96ee-4efa-8c92-f138480610af",
                column: "ConcurrencyStamp",
                value: "ddbd6eff-dae1-4e42-ab2f-4b87c4c6ff99");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-a290380610ea",
                column: "ConcurrencyStamp",
                value: "d9455154-f7a4-4940-af0f-c00b98b6d762");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d162da66-b0e3-49bb-9a4a-0863b3b19f8b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "57203733-6892-4e30-9000-357bf58cca99", true, "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEDUCgQ39lpQl29BP6rTFY0f7Y0ud5L6wK5DNbghwOlyg76P9H1cgQTQiHXjL2DMHzQ==", "e15175d4-99ea-41f3-9a78-52cdc5934588", "user@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-f138480610cb",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6767dadd-a11a-4f88-ad12-0071937f6a6c", true, "ADMIN1@GMAIL.COM", "AQAAAAEAACcQAAAAELDufE1q8DGLL5225f+3nAVaMox8aCVI7qCr+8DgNdV2p+SEQYvhwa4tHKcImLMMnA==", "073897ac-9bb4-4f70-96fd-825121ca181c", "admin1@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6ac1256-96ee-4efa-8c92-f138480610af",
                column: "ConcurrencyStamp",
                value: "43f5eb78-9150-4b5c-9e69-c629dc3ec65e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-a290380610ea",
                column: "ConcurrencyStamp",
                value: "8877ee47-32c7-418e-be89-3bba14075b9c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d162da66-b0e3-49bb-9a4a-0863b3b19f8b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fcd0a837-fb04-4158-9f81-98dbd1b4ae39", false, null, "AQAAAAEAACcQAAAAEJGChGdBO+rQ0b9f2R/C+bA1Avx5iYjLuSfgWlI6ns7xvNM+kz4pF8rsMyNFQEjqMg==", "b00566ab-d1c4-49ad-97a1-7298a4e998c5", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-f138480610cb",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c52c2e18-ae19-4350-a4d9-a2b02f5056b9", false, null, "AQAAAAEAACcQAAAAEHbAcuMwQlAaaJgtj2UpkJ0M5y5O5EVzlp2jnqPURnTo62/z/OLKWCUH2kPwR7yEew==", "25484b7b-6ada-411a-ba66-5a53f8e21e45", null });
        }
    }
}
