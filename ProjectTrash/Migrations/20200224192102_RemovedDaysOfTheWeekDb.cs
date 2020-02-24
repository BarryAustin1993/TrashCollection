using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectTrash.Migrations
{
    public partial class RemovedDaysOfTheWeekDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_WeeklyPickUps_WeeklyPickUpId",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "WeeklyPickUps");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_WeeklyPickUpId",
                table: "Accounts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be96afbf-52b1-4b92-ad22-04c4ad78e345");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0660ffa-7f5d-4b9b-97f1-e3c7a31fe856");

            migrationBuilder.DropColumn(
                name: "WeeklyPickUpId",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "PickUpDay",
                table: "Accounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c990a4a-e1a3-4299-8c98-1a4bee9f1a09", "4ba89101-d85d-4b33-9e3b-c74970d7a524", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a31d524-5845-4a1d-a716-2cb981166411", "2d1e0dd0-ebd0-4628-96f4-062fca175265", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a31d524-5845-4a1d-a716-2cb981166411");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c990a4a-e1a3-4299-8c98-1a4bee9f1a09");

            migrationBuilder.DropColumn(
                name: "PickUpDay",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "WeeklyPickUpId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WeeklyPickUps",
                columns: table => new
                {
                    WeeklyPickUpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfTheWeek = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyPickUps", x => x.WeeklyPickUpId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "be96afbf-52b1-4b92-ad22-04c4ad78e345", "78909414-32ed-45a2-ae56-bfb51c85d902", "Customer", "CUSTOMER" },
                    { "d0660ffa-7f5d-4b9b-97f1-e3c7a31fe856", "825c8000-7908-470d-8fba-2eefb6d08190", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "WeeklyPickUps",
                columns: new[] { "WeeklyPickUpId", "DayOfTheWeek" },
                values: new object[,]
                {
                    { 1, "Monday" },
                    { 2, "Tuesday" },
                    { 3, "Wednesday" },
                    { 4, "Thursday" },
                    { 5, "Friday" },
                    { 6, "Saturday" },
                    { 7, "Sunday" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_WeeklyPickUpId",
                table: "Accounts",
                column: "WeeklyPickUpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_WeeklyPickUps_WeeklyPickUpId",
                table: "Accounts",
                column: "WeeklyPickUpId",
                principalTable: "WeeklyPickUps",
                principalColumn: "WeeklyPickUpId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
