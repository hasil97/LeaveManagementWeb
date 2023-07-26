using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6ac1256-96ee-4efa-8c92-f138480610af",
                column: "ConcurrencyStamp",
                value: "09e9ec4e-23d5-45a3-97bd-721092469b30");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-a290380610ea",
                column: "ConcurrencyStamp",
                value: "fada31fd-b08b-442c-a04d-f8f3f9809c03");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d162da66-b0e3-49bb-9a4a-0863b3b19f8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd7ab066-2f88-4a30-8429-2e50ca3ed059", "AQAAAAEAACcQAAAAELUmbpUVuLUIwWv4lRpeTHTy4ZbbJ+KqoAPYUedXcLzMyMZb/m+LwCAJfUcn5TDZ0g==", "2c25d5bb-afcd-4d8d-8f9a-743f6be88c4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-f138480610cb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df1e6c0b-62b9-4e1b-a712-7191cbbef625", "AQAAAAEAACcQAAAAEKNmYQXYx9TmjWYM0cesmux5JVGJQbj+sFDIi8rQH8SiQSJf5XeYfB8BmtIhev9Bpw==", "7cb68915-6c78-4198-885c-8d154eca4088" });
        }
    }
}
