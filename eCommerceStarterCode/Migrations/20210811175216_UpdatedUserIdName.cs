using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class UpdatedUserIdName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4313c462-ad87-44f7-834a-2cea5ffdf3c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4cafa8c-45f0-4289-8f25-2073c45d0b24");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4313c462-ad87-44f7-834a-2cea5ffdf3c3", "8460e507-abd4-4ce1-925f-7c3d2ac8da89", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4cafa8c-45f0-4289-8f25-2073c45d0b24", "81758ddc-a6e0-4e8f-af4a-ec28d9415c0b", "Admin", "ADMIN" });
        }
    }
}
