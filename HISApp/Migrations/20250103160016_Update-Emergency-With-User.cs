using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HISApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmergencyWithUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameOfUser",
                table: "Emergencies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameOfUser",
                table: "Emergencies");
        }
    }
}
