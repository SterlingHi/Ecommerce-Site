using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class UpdatedShoppingCartTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ed5c09f-2cb5-43dc-92cb-3826225776ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf12c17e-2110-4827-8e29-ce2e6764386f");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ShopppingCarts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a84d4078-36e1-4688-8533-6cf01e4ab506", "88622875-7b7c-43d4-a7f9-af066db5bb9a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3734c68-fb4e-4300-8577-9210bd7e4ef0", "5a78ff70-4dfb-4d3e-a465-9df71e3925b7", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a84d4078-36e1-4688-8533-6cf01e4ab506");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3734c68-fb4e-4300-8577-9210bd7e4ef0");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ShopppingCarts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ed5c09f-2cb5-43dc-92cb-3826225776ed", "2b45c979-114a-4418-9979-db9726ff698f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf12c17e-2110-4827-8e29-ce2e6764386f", "c8e4644e-b9fc-4920-8530-a26ec09d5db0", "Admin", "ADMIN" });
        }
    }
}
