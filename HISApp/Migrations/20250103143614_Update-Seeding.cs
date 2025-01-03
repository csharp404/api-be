using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HISApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Abdoun");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Jabal Al-Weibdeh");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Sweifieh");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Dabouq");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Al-Husn");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Al-Ramtha");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Downtown");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 2, "Bani Kinana" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Aqaba City Center");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Industrial Zone");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 3, "Southern Beach" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 3, "Wadi Rum" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 4, "New Zarqa" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 4, "Al-Ruseifa" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 4, "Al-Dhuleil" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 4, "Hashemiyah" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 5, "Madaba Center" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 5, "Mount Nebo" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 5, "Al-Faisaliah" });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { 20, 5, "Ma'in" },
                    { 21, 6, "Salt City Center" },
                    { 22, 6, "Fuheis" },
                    { 23, 6, "Ain Al-Basha" },
                    { 24, 6, "Mahes" },
                    { 25, 7, "Mafraq City Center" },
                    { 26, 7, "Al-Khalidiya" },
                    { 27, 7, "Ruwaished" },
                    { 28, 7, "Um Al-Jimal" },
                    { 29, 8, "Tafilah City Center" },
                    { 30, 8, "Busaira" },
                    { 31, 8, "Al-Hasa" },
                    { 32, 8, "Dana" },
                    { 33, 9, "Karak City Center" },
                    { 34, 9, "Al-Qasr" },
                    { 35, 9, "Mu'tah" },
                    { 36, 9, "Al-Mazar" },
                    { 37, 10, "Jerash City Center" },
                    { 38, 10, "Souf" },
                    { 39, 10, "Sakib" },
                    { 40, 10, "Al-Kitta" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Albalqa");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 11, "Ma'an" },
                    { 12, "Ajloun" }
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { 41, 11, "Ma'an City Center" },
                    { 42, 11, "Petra" },
                    { 43, 11, "Shobak" },
                    { 44, 11, "Al-Husseinieh" },
                    { 45, 12, "Ajloun City Center" },
                    { 46, 12, "Anjara" },
                    { 47, 12, "Al-Wahadneh" },
                    { 48, 12, "Kufranjah" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Jabal Amman");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Sweifieh");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Dabouq");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Al-Abdali");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Al-Hassan Industrial Estate");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "University District");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Al-Sarih");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 3, "North Beach" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "South Port");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Ayla Oasis");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 4, "New Zarqa" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 4, "Al-Ghabawi" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 5, "Mount Nebo" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 5, "Al-Rumaytha" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 6, "Wadi Al-Seer" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 7, "North Mafraq" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 8, "Dana Reserve" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 9, "Shihan" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CityId", "Name" },
                values: new object[] { 10, "Souf" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Salt");
        }
    }
}
