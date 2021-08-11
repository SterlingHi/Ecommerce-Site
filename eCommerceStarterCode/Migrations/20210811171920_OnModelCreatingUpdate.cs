using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class OnModelCreatingUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ShopppingCarts",
                newName: "ProductId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ed5c09f-2cb5-43dc-92cb-3826225776ed", "2b45c979-114a-4418-9979-db9726ff698f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf12c17e-2110-4827-8e29-ce2e6764386f", "c8e4644e-b9fc-4920-8530-a26ec09d5db0", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ed5c09f-2cb5-43dc-92cb-3826225776ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf12c17e-2110-4827-8e29-ce2e6764386f");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ShopppingCarts",
                newName: "UserId");
        }
    }
}
