using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectTrash.Data.Migrations
{
    public partial class failedTheFirstduetobuilderrorsjustrunningagaintoseewhathappens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e63fa33a-7869-42e3-9808-258ad1728eee");

            migrationBuilder.CreateTable(
                name: "AccountSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isActive = table.Column<bool>(nullable: false),
                    isSuspended = table.Column<bool>(nullable: false),
                    accountStartDate = table.Column<DateTime>(nullable: false),
                    accountEndDate = table.Column<DateTime>(nullable: false),
                    suspensionStartDate = table.Column<DateTime>(nullable: false),
                    suspensionEndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountSubscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    zipcode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeeklyPickUps",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dayOfTheWeek = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyPickUps", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    balance = table.Column<double>(nullable: false),
                    AccountSubscriptionID = table.Column<int>(nullable: false),
                    AddressID = table.Column<int>(nullable: false),
                    WeeklyPickUpID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountSubscriptions_AccountSubscriptionID",
                        column: x => x.AccountSubscriptionID,
                        principalTable: "AccountSubscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_WeeklyPickUps_WeeklyPickUpID",
                        column: x => x.WeeklyPickUpID,
                        principalTable: "WeeklyPickUps",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    accountID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Accounts_accountID",
                        column: x => x.accountID,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PickUps",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(nullable: false),
                    pickUpDate = table.Column<DateTime>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickUps", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PickUps_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PickUps_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccountSubscriptions",
                columns: new[] { "Id", "accountEndDate", "accountStartDate", "isActive", "isSuspended", "suspensionEndDate", "suspensionStartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2016, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2016, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                column: "ID",
                values: new object[]
                {
                    4,
                    7,
                    1,
                    2,
                    3,
                    6,
                    5
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b6fc3e2f-8cb0-4b6d-8c44-fca312389cd8", "a2a18e98-ddd9-4d8a-ab5e-77070443d3bc", "Customer", "Customer" },
                    { "66365948-ac06-4fc4-9ccb-2a4c6ca76841", "7d841805-7411-4b59-8692-e760e2a9a93d", "Employee", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "UserId", "firstName", "lastName", "zipcode" },
                values: new object[,]
                {
                    { 1, null, "Nevin", "Seibel", 53211 },
                    { 2, null, "David", "Lagrange", 53212 },
                    { 3, null, "Charles", "King", 53168 },
                    { 4, null, "Mike", "Terril", 48088 }
                });

            migrationBuilder.InsertData(
                table: "WeeklyPickUps",
                columns: new[] { "ID", "dayOfTheWeek" },
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

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "ID", "AccountSubscriptionID", "AddressID", "WeeklyPickUpID", "balance" },
                values: new object[,]
                {
                    { 5, 5, 5, 1, 0.0 },
                    { 6, 6, 6, 1, 33.0 },
                    { 8, 8, 2, 1, 20.0 },
                    { 7, 7, 7, 2, 150.0 },
                    { 1, 1, 1, 3, 25.0 },
                    { 2, 2, 2, 4, 50.0 },
                    { 3, 3, 3, 5, 25.0 },
                    { 4, 4, 4, 6, 50.0 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "UserId", "accountID" },
                values: new object[,]
                {
                    { 5, null, 5 },
                    { 6, null, 6 },
                    { 8, null, 8 },
                    { 7, null, 7 },
                    { 1, null, 1 },
                    { 2, null, 2 },
                    { 3, null, 3 },
                    { 4, null, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountSubscriptionID",
                table: "Accounts",
                column: "AccountSubscriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AddressID",
                table: "Accounts",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_WeeklyPickUpID",
                table: "Accounts",
                column: "WeeklyPickUpID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_accountID",
                table: "Customers",
                column: "accountID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PickUps_AccountID",
                table: "PickUps",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_PickUps_EmployeeID",
                table: "PickUps",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "PickUps");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "AccountSubscriptions");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "WeeklyPickUps");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66365948-ac06-4fc4-9ccb-2a4c6ca76841");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6fc3e2f-8cb0-4b6d-8c44-fca312389cd8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e63fa33a-7869-42e3-9808-258ad1728eee", "a432de9b-426a-4042-9ed0-c50d38e37123", "Admin", "ADMIN" });
        }
    }
}
