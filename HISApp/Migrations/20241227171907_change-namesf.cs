using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HISApp.Migrations
{
    /// <inheritdoc />
    public partial class changenamesf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22285aeb-4b5a-492e-aaab-a7a0f426a7f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7392c0fe-97ac-407e-95f9-f86fde34106e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1f25fdf-ba9d-46bd-978d-9c484d849a7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5a2aef9-24a6-4847-b8d1-f0a771217099");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Doctor", "DOCTOR" },
                    { "2", null, "Nurse", "NURSE" },
                    { "3", null, "ManagementStaff", "MANAGEMENTSTAFF" },
                    { "4", null, "Pharmacist", "PHARMACIST" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22285aeb-4b5a-492e-aaab-a7a0f426a7f3", null, "Nurse", "NURSE" },
                    { "7392c0fe-97ac-407e-95f9-f86fde34106e", null, "Doctor", "DOCTOR" },
                    { "d1f25fdf-ba9d-46bd-978d-9c484d849a7f", null, "ManagementStaff", "MANAGEMENTSTAFF" },
                    { "e5a2aef9-24a6-4847-b8d1-f0a771217099", null, "Pharmacist", "PHARMACIST" }
                });
        }
    }
}
