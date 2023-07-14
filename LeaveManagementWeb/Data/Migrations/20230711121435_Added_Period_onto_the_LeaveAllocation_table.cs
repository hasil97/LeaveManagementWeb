using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class Added_Period_onto_the_LeaveAllocation_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57203733-6892-4e30-9000-357bf58cca99", "AQAAAAEAACcQAAAAEDUCgQ39lpQl29BP6rTFY0f7Y0ud5L6wK5DNbghwOlyg76P9H1cgQTQiHXjL2DMHzQ==", "e15175d4-99ea-41f3-9a78-52cdc5934588" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6ac0515-96ee-4efa-8c72-f138480610cb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6767dadd-a11a-4f88-ad12-0071937f6a6c", "AQAAAAEAACcQAAAAELDufE1q8DGLL5225f+3nAVaMox8aCVI7qCr+8DgNdV2p+SEQYvhwa4tHKcImLMMnA==", "073897ac-9bb4-4f70-96fd-825121ca181c" });
        }
    }
}
