using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HISApp.Migrations
{
    /// <inheritdoc />
    public partial class editSeeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Codes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Color",
                value: "#808080");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Codes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Color",
                value: "#D94141");
        }
    }
}
