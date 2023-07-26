using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class MadetheLeaveRequestclassRequestCommentscoloumnNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6ac1256-96ee-4efa-8c92-f138480610af",
                column: "ConcurrencyStamp",
                value: "6bb652ac-58a3-4bb5-84c5-601a7485c1e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-a290380610ea",
                column: "ConcurrencyStamp",
                value: "26d656c3-f911-4222-8755-88972f51d9ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d162da66-b0e3-49bb-9a4a-0863b3b19f8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2ff6fae-55d7-42cd-8081-99a07da4f05a", "AQAAAAEAACcQAAAAEPMUAu1rtzCwrb47NXJvRTbnyNwvLtjZOprLHg6cA7qGahd5M+SrzhNVrwrAs3oFdQ==", "11b3b222-5f67-4b2a-8f12-b976f39c77ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-f138480610cb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abf64f14-92b3-4ad2-8ed6-3bd49e47c006", "AQAAAAEAACcQAAAAEGmVE7CMAiaNtvoApa2Q/hvE2ckmz26CvGHTCgw5r/EdheTOnn74trFsptvK0ObpNA==", "bd2a5cce-3eda-4a3d-a2a1-635bea0c9202" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6ac1256-96ee-4efa-8c92-f138480610af",
                column: "ConcurrencyStamp",
                value: "e4451b89-e629-41ed-bcf4-69d2bd2d756d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-a290380610ea",
                column: "ConcurrencyStamp",
                value: "64f0bd92-5be8-43b5-953a-77fed4979ca9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d162da66-b0e3-49bb-9a4a-0863b3b19f8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "446ee1f0-c466-4ce1-965b-400021563a75", "AQAAAAEAACcQAAAAEAVEZwWRtJa1/iXOfAabZl6hE/VA28qS5j+MeNKGpr8ls8Eo7WkXx6VP017Q1c8NPw==", "2184aac2-915a-47c3-bfa1-ce6491f6b2ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-f138480610cb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26332cd3-c304-42a4-baac-efebd7ba402f", "AQAAAAEAACcQAAAAEHnX4fJSLcQj4DBpDU7ORamh6v2mnQ3DFqpFpkTr7xAInvcmRWEPwamYbJayJCf8Wg==", "e4730e15-7df6-4193-8a99-1367df39289e" });
        }
    }
}
