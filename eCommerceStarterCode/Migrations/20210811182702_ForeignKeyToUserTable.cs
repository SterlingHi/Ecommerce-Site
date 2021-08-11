using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class ForeignKeyToUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "CartId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9ca669b-2a9a-499d-bc6d-d96f2fb2ee50", "43190e49-c91b-4c43-845b-767fe4a98047", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc187942-d287-4fa3-88dc-39e034a28352", "dcaafc42-fc9d-4d96-ae60-6fd299f68cae", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc187942-d287-4fa3-88dc-39e034a28352");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9ca669b-2a9a-499d-bc6d-d96f2fb2ee50");

            migrationBuilder.RenameColumn(
                name: "CartId",
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
    }
}
