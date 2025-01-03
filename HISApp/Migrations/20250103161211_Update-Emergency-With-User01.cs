using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HISApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmergencyWithUser01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentName",
                table: "Emergencies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentName",
                table: "Emergencies");
        }
    }
}
