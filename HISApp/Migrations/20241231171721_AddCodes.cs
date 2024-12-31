using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HISApp.Migrations
{
    /// <inheritdoc />
    public partial class AddCodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Codes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emergencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmergencyCodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emergencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emergencies_Codes_EmergencyCodeId",
                        column: x => x.EmergencyCodeId,
                        principalTable: "Codes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Codes",
                columns: new[] { "Id", "Code", "Color", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Code BLUE", "#2A7DCE", "Represents a critical medical emergency, such as cardiopulmonary arrest, requiring immediate medical intervention.", "Medical Emergency" },
                    { 2, "Code RED", "#D94141", "Indicates a fire emergency, necessitating fire safety protocols and evacuation procedures", "Fire" },
                    { 3, "Code GREY", "#D94141", "indicates radioactive contamination or incidents, requiring specialized radiology and safety teams", "Radioactive Accident" },
                    { 4, "Code GREEN", "#49B06C", "Denotes a chemical or biological spill, requiring specialized cleanup and safety measures", "Chemical or Biological spillage" },
                    { 5, "Code ORANGE", "#F28C3A", "Refers to mass casualty incidents, involving coordination for large-scale emergency medical response", "Mass casualties" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emergencies_EmergencyCodeId",
                table: "Emergencies",
                column: "EmergencyCodeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emergencies");

            migrationBuilder.DropTable(
                name: "Codes");
        }
    }
}
