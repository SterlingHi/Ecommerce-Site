using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class UserIdKeyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a84d4078-36e1-4688-8533-6cf01e4ab506");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3734c68-fb4e-4300-8577-9210bd7e4ef0");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4313c462-ad87-44f7-834a-2cea5ffdf3c3", "8460e507-abd4-4ce1-925f-7c3d2ac8da89", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4cafa8c-45f0-4289-8f25-2073c45d0b24", "81758ddc-a6e0-4e8f-af4a-ec28d9415c0b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4313c462-ad87-44f7-834a-2cea5ffdf3c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4cafa8c-45f0-4289-8f25-2073c45d0b24");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a84d4078-36e1-4688-8533-6cf01e4ab506", "88622875-7b7c-43d4-a7f9-af066db5bb9a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3734c68-fb4e-4300-8577-9210bd7e4ef0", "5a78ff70-4dfb-4d3e-a465-9df71e3925b7", "Admin", "ADMIN" });
        }
    }
}
