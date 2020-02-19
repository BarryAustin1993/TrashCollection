using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectTrash.Data.Migrations
{
    public partial class FixedSomeOfTheClassesGetSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66365948-ac06-4fc4-9ccb-2a4c6ca76841");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6fc3e2f-8cb0-4b6d-8c44-fca312389cd8");

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "zipCode",
                table: "Addresses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "address", "city", "state", "zipCode" },
                values: new object[] { "14538 Talbot drive", "Warren", "Mi", 48088 });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "address", "city", "state", "zipCode" },
                values: new object[] { "6228 238th Avenue", "Salem", "Wi", 53168 });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "address", "city", "state", "zipCode" },
                values: new object[] { "6118 North Downer Avenue", "Milwaukee", "Wi", 53211 });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "address", "city", "state", "zipCode" },
                values: new object[] { "2438 North Bremen Street", "Milwaukee", "Wisconsin", 53212 });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "address", "city", "state", "zipCode" },
                values: new object[] { "3304 North Pierce Street", "Milwaukee", "Wisconsin", 53212 });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "address", "city", "state", "zipCode" },
                values: new object[] { "3232 North Summit Avenue", "Milwaukee", "Wisconsin", 53211 });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "address", "city", "state", "zipCode" },
                values: new object[] { "3333 North Hacket Avenue", "Milwaukee", "Wisconsin", 53211 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "92deba22-6d37-4747-bc6c-53510dcb1694", "d3ff1369-eaec-4a2a-9106-f1f4aab25c33", "Customer", "Customer" },
                    { "a688b36d-59cb-43f4-b504-bd049b97f7b1", "ecd5e6dd-606b-4097-850c-6700afc0aba4", "Employee", "Employee" }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "firstName", "lastName" },
                values: new object[] { "Austin", "Barry" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "firstName", "lastName" },
                values: new object[] { "Andrew", "Baird" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "firstName", "lastName" },
                values: new object[] { "David", "Steinhafel" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "firstName", "lastName" },
                values: new object[] { "Matthew", "Acker" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "firstName", "lastName" },
                values: new object[] { "Ryan", "Holman" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "firstName", "lastName" },
                values: new object[] { "Dejan", "Tirnanic" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "firstName", "lastName" },
                values: new object[] { "Gustavo", "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "firstName", "lastName" },
                values: new object[] { "Jacob", "Brockmann" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92deba22-6d37-4747-bc6c-53510dcb1694");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a688b36d-59cb-43f4-b504-bd049b97f7b1");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "address",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "zipCode",
                table: "Addresses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6fc3e2f-8cb0-4b6d-8c44-fca312389cd8", "a2a18e98-ddd9-4d8a-ab5e-77070443d3bc", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66365948-ac06-4fc4-9ccb-2a4c6ca76841", "7d841805-7411-4b59-8692-e760e2a9a93d", "Employee", "Employee" });
        }
    }
}
