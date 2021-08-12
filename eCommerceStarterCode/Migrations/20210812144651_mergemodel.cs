using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class mergemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "45528c0e-fe6d-4e44-9cfd-fed894652e5c");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "d6f1af1b-b30a-4541-acb6-e7fef5673f2e");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[] { "bfd7464f-c9b2-497a-bed3-0c0e06fa0787", "383fb5fb-1dfd-4fb6-ba74-158d2ccaad7d", "User", "USER" });

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[] { "085cb137-5ea8-4314-bd22-15a83dac7ecc", "f0370df5-be77-40b3-bc6e-76d20361e685", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "085cb137-5ea8-4314-bd22-15a83dac7ecc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfd7464f-c9b2-497a-bed3-0c0e06fa0787");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45528c0e-fe6d-4e44-9cfd-fed894652e5c", "2d487317-cddf-4101-aa7d-bf7bb13cdf99", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6f1af1b-b30a-4541-acb6-e7fef5673f2e", "c35c2f69-de43-43f8-ac18-e0c573a822d3", "Admin", "ADMIN" });
        }
    }
}
