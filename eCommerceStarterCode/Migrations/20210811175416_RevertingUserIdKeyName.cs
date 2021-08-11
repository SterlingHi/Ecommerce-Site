using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class RevertingUserIdKeyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40d11591-9458-45d0-b592-3a5c014949b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "736ac519-8ed5-40ec-8f1d-daeb5c965639");

            migrationBuilder.RenameColumn(
                name: "AUserId",
                table: "AspNetUsers",
                newName: "UserId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "047c8ff6-0d37-45b4-a528-6a74bcf7c584", "ed41b94b-7571-4702-99b8-6052910a856a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54e2a773-e33f-4343-afbe-1cc2cccb6230", "2d9eb6a5-76be-4f12-878d-6302483cf3b4", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "047c8ff6-0d37-45b4-a528-6a74bcf7c584");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54e2a773-e33f-4343-afbe-1cc2cccb6230");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AspNetUsers",
                newName: "AUserId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "736ac519-8ed5-40ec-8f1d-daeb5c965639", "fe7738b5-0129-451a-847b-f51bff6bf7f9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "40d11591-9458-45d0-b592-3a5c014949b2", "e3df3f85-8e2f-44a7-a511-2d39a36c34b0", "Admin", "ADMIN" });
        }
    }
}
