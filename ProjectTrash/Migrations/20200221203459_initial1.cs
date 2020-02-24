using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectTrash.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_AccountSubscriptions_AccountSubscriptionID",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Addresses_AddressID",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_WeeklyPickUps_WeeklyPickUpID",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Accounts_accountID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_PickUps_Employees_EmployeeID",
                table: "PickUps");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Customers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "accountID",
                table: "Customers",
                newName: "AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_accountID",
                table: "Customers",
                newName: "IX_Customers_AccountID");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "PickUps",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AccountID",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "WeeklyPickUpID",
                table: "Accounts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AddressID",
                table: "Accounts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AccountSubscriptionID",
                table: "Accounts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02468 - employee",
                column: "ConcurrencyStamp",
                value: "5f300375-c417-435c-a77c-5f4ff9a33273");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13579 - customer",
                column: "ConcurrencyStamp",
                value: "3c7f051b-9afe-498c-801c-eb1f9d802094");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10-DLagrange",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1cbd6ec6-8710-48e6-80b9-a168c8b36e62", "c0831ca7-3c9d-48a8-8ef4-4a36dd57dcd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11-CKIng",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86d363fe-f783-4953-9569-e074d8f49d33", "110c335e-72e0-4969-a3f5-6e73dd15eb4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12-MTerril",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d872cfef-1c06-496b-96aa-65668ecf9285", "eab39bc2-40bd-43cd-ad1e-4529066a199e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1-Ajpbarry",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63907637-a7a9-472e-b616-dc8437489f80", "b740c1f5-f9e8-49d9-b6c1-c2340caca1f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2-ABaird",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d6799870-4f48-40f0-a0fa-45f83385bc04", "612f33fe-afec-4661-b1a2-00eae5dec7da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3-DSteinhafel",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bc58742f-d424-41f8-bcb2-9de00689c47c", "8d3272dd-51d7-48af-a412-51f12d9ba6d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4-MAcker",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c394d82e-466d-4589-a02c-652fc4ef7f49", "9e8e9108-c146-4a8e-aca3-54103b62a6e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5-RHolman",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "69d01d75-53c7-44d7-b238-41c482d2803f", "1269d76c-1ad7-41ed-8ca9-d434839ec056" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6-DTirnanic",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e35b13b7-b72f-4f39-b749-7cda69a0dd60", "897d329b-524a-4341-b2a9-2862897ebedb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7-GSanchez",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0824f673-d958-4abb-b2be-95dd51240ca6", "d19390b9-0740-4beb-af6d-96ccc21bcee7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8-JBrockman",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9bbbf18-9625-4726-a169-68c016139229", "d793b092-f4a8-46ff-a5ca-a966f53f3d5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9-NSeibel",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa06621b-954a-4fb8-a8fe-3e0350501548", "6303bce4-d0d8-4d41-90f6-9e4b5e438395" });

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_AccountSubscriptions_AccountSubscriptionID",
                table: "Accounts",
                column: "AccountSubscriptionID",
                principalTable: "AccountSubscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Addresses_AddressID",
                table: "Accounts",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_WeeklyPickUps_WeeklyPickUpID",
                table: "Accounts",
                column: "WeeklyPickUpID",
                principalTable: "WeeklyPickUps",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Accounts_AccountID",
                table: "Customers",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PickUps_Employees_EmployeeID",
                table: "PickUps",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_AccountSubscriptions_AccountSubscriptionID",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Addresses_AddressID",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_WeeklyPickUps_WeeklyPickUpID",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Accounts_AccountID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_PickUps_Employees_EmployeeID",
                table: "PickUps");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customers",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "Customers",
                newName: "accountID");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_AccountID",
                table: "Customers",
                newName: "IX_Customers_accountID");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "PickUps",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "accountID",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WeeklyPickUpID",
                table: "Accounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressID",
                table: "Accounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccountSubscriptionID",
                table: "Accounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02468 - employee",
                column: "ConcurrencyStamp",
                value: "1628ea8b-15a8-4e44-8953-22a958f06773");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13579 - customer",
                column: "ConcurrencyStamp",
                value: "b4eef8f7-d156-46a9-8ccb-ddc4d1f3ccfa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10-DLagrange",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "30cbfeab-1aa5-4edf-a788-42f890668431", "324e364f-774c-4f18-ac87-2b446f9ebaa1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11-CKIng",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b948849b-e6ba-48be-96fa-a94d139cb2b3", "7cb29e2f-4152-4121-8ad1-88f085048e35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12-MTerril",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "40cc4429-9efe-42ef-9398-799b6f3349fd", "38fd8a46-6108-4da3-b1aa-161200805710" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1-Ajpbarry",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2612c05-98d2-4142-8009-5706c15419bb", "0a30a101-d865-4be4-966b-2994ba1cd281" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2-ABaird",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0f944752-dd60-4ba1-943a-2873ca881e81", "a7c04a16-d0e5-488e-98ee-c3cd976a6c45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3-DSteinhafel",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01644b7a-ba1d-4832-b3ce-93fb6ca40cfb", "dd975317-9a14-4b26-88bf-e03ba6cd1a84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4-MAcker",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "571a7990-1542-4605-937e-78ed0b4e41b3", "29aa3ac3-2c9d-4c6d-a9ab-ec624a9d5fc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5-RHolman",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0bfe3322-fc46-4d07-82f4-df0869619fff", "f207d7ee-61a0-49d9-ac77-9f7bdd353852" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6-DTirnanic",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b02cc39-db9a-4c15-b0c7-49c0a6bb4ebd", "a98d3f48-f1e7-4df7-8439-66bbafb95503" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7-GSanchez",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f636434-2357-461f-82ba-37cd90eb1add", "6dca1df3-62cd-4a5d-b857-6cf00fa9fa53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8-JBrockman",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42b4b379-5c59-4937-b441-010915b24e62", "8155e82f-39e5-4a7b-9c0c-a9d70f36eb89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9-NSeibel",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6bba2357-fc92-49f7-ad77-2f1e57db93ba", "747cd7b4-87a8-4fed-902e-52b479096667" });

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_AccountSubscriptions_AccountSubscriptionID",
                table: "Accounts",
                column: "AccountSubscriptionID",
                principalTable: "AccountSubscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Addresses_AddressID",
                table: "Accounts",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_WeeklyPickUps_WeeklyPickUpID",
                table: "Accounts",
                column: "WeeklyPickUpID",
                principalTable: "WeeklyPickUps",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Accounts_accountID",
                table: "Customers",
                column: "accountID",
                principalTable: "Accounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PickUps_Employees_EmployeeID",
                table: "PickUps",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
