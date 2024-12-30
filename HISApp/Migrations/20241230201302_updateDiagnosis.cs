using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HISApp.Migrations
{
    /// <inheritdoc />
    public partial class updateDiagnosis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientName",
                table: "Diagnosis");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AreaId",
                table: "Patients",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CityId",
                table: "Patients",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DepartmentId",
                table: "Patients",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Areas_AreaId",
                table: "Patients",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Cities_CityId",
                table: "Patients",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Departments_DepartmentId",
                table: "Patients",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Areas_AreaId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Cities_CityId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Departments_DepartmentId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_AreaId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_CityId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DepartmentId",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "PatientName",
                table: "Diagnosis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
