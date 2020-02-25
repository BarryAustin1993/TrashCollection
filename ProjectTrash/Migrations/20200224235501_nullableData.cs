using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectTrash.Migrations
{
    public partial class nullableData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a31d524-5845-4a1d-a716-2cb981166411");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c990a4a-e1a3-4299-8c98-1a4bee9f1a09");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SuspensionStartDate",
                table: "AccountSubscriptions",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SuspensionEndDate",
                table: "AccountSubscriptions",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AccountEndDate",
                table: "AccountSubscriptions",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "890fb32b-6a2c-4872-af4a-dfac5a0c1d19", "bb217dee-59ab-4d5e-a3a1-1fcaa0baebf5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c1ebcab4-9ac9-42c1-a7a4-a5f8ff3c9d74", "b504f286-dd4b-46b8-b2e7-3e7dab2b7c7c", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "890fb32b-6a2c-4872-af4a-dfac5a0c1d19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1ebcab4-9ac9-42c1-a7a4-a5f8ff3c9d74");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SuspensionStartDate",
                table: "AccountSubscriptions",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SuspensionEndDate",
                table: "AccountSubscriptions",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AccountEndDate",
                table: "AccountSubscriptions",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c990a4a-e1a3-4299-8c98-1a4bee9f1a09", "4ba89101-d85d-4b33-9e3b-c74970d7a524", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a31d524-5845-4a1d-a716-2cb981166411", "2d1e0dd0-ebd0-4628-96f4-062fca175265", "Employee", "EMPLOYEE" });
        }
    }
}
