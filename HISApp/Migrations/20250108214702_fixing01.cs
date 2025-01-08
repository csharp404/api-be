using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HISApp.Migrations
{
    /// <inheritdoc />
    public partial class fixing01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("0699e4af-6a8b-4647-80f9-f567610901ae"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("0ccd5f8b-c033-42d3-9865-be981abb1344"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5531533d-5e32-49cf-bbce-c599db02c5a3"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a0219a68-9759-4d19-b69b-b06ab2734e37"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("bb2f8927-6eec-4f59-85ba-7fa71af0d4e9"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "5e23e00a-b0fc-4b3e-9a7f-bb9a5250e0ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5", "974350b0-5ecb-4015-8825-19f190c268bc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "cea7eb50-7d7e-4515-8830-f9d3f3e80753" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "e386740c-cd9b-40e8-88b0-455bd4769f59" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "f42cf095-eed2-4f46-87f8-8abcb25eb59f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e23e00a-b0fc-4b3e-9a7f-bb9a5250e0ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "974350b0-5ecb-4015-8825-19f190c268bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cea7eb50-7d7e-4515-8830-f9d3f3e80753");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e386740c-cd9b-40e8-88b0-455bd4769f59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f42cf095-eed2-4f46-87f8-8abcb25eb59f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Age", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "Experience", "FirstName", "Gender", "HireDate", "ImagePath", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialization", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "27dd180e-4a4c-4c3f-849d-f61e0a846cc6", 0, new Guid("6636824e-d494-481f-ab8d-48e7ec49e3c8"), 40, "babb59de-5674-41ff-bb1e-85e86623947a", 9, "m@p2h.com", false, "12", "Manager", true, new DateTime(2025, 1, 9, 0, 47, 1, 646, DateTimeKind.Local).AddTicks(5271), null, null, "Mohammad", false, null, "m@p2h.com", "m@p2h.com", "AQAAAAIAAYagAAAAEGg3WeeHYutj0StKGLTVvBIhctQhhVRWZz0wPYeTPyift9kj4k0S/3B17gsR/LniJw==", "4561237890", false, "8bedf043-f18a-4101-a082-9bef10f0f491", null, false, "m@p2h.com" },
                    { "3acc729d-1693-400f-adb3-382c9419d50c", 0, new Guid("9cec542b-d7a6-4f3e-a1c9-604bca3fb60c"), 40, "9dfa94be-c170-4665-b05d-2db613cc2d1a", 1, "d@p2h.com", false, "12", "Doctor", true, new DateTime(2025, 1, 9, 0, 47, 1, 551, DateTimeKind.Local).AddTicks(3444), null, null, "Ahmad", false, null, "d@p2h.com", "d@p2h.com", "AQAAAAIAAYagAAAAEOungGC2cr7X1K9i0+bSd31Jdcfh5tpcYXHRlo4ctCCmhtPV8P/NqX6p9Ovh32LNHA==", "1234567890", false, "8839dd94-5f1f-47ac-a179-702f74d73531", null, false, "d@p2h.com" },
                    { "955c02e9-e68f-49db-a6dd-f520c4d35cdc", 0, new Guid("b6b7ac1f-bab4-4594-adc4-2254cf90ef9a"), 26, "3c16b6d9-2a3f-4f13-9244-3e17c13dfc7d", 1, "a@p2h.com", false, "12", "Admin", true, new DateTime(2025, 1, 9, 0, 47, 1, 743, DateTimeKind.Local).AddTicks(2478), null, null, "Yousef", false, null, "A@P2H.COM", "a@p2h.com", "AQAAAAIAAYagAAAAEGotzpXVdyZrmzZKsgIDLqmse5O1jDQ7A1dxB9VBpIU/DDorNzaiF90w7FLrjsWcEw==", "3216549870", false, "7172b752-d546-4d32-a429-f08609b53adb", null, false, "a@p2h.com" },
                    { "cef369e2-8698-450b-818a-46a5733a2e23", 0, new Guid("49b301b7-839a-4d34-9e51-53732be5931f"), 45, "c519c7d2-b926-4448-a74e-4005d77fd7e0", 1, "n@p2h.com", false, "12", "Nurse", false, new DateTime(2025, 1, 9, 0, 47, 1, 599, DateTimeKind.Local).AddTicks(803), null, null, "Sameera", false, null, "n@p2h.com", "n@p2h.com", "AQAAAAIAAYagAAAAELj9Z9ASuQLt1woAcB433FPzdhoDPQve5gnv/5ux6kJDFtpw+4ePx6o4PtVkMtyptg==", "0987654321", false, "bc1c35bc-ebe3-4d25-94b1-0a280fe751f0", null, false, "n@p2h.com" },
                    { "dcb6dc20-faac-4a60-a0be-d4204016f5fc", 0, new Guid("174bdefa-6914-4a9b-9939-11dcd43b671f"), 33, "9121858a-6ecb-44c4-9251-f28fb11ecdab", 8, "p@p2h.com", false, "12", "Pharmacist", true, new DateTime(2025, 1, 9, 0, 47, 1, 695, DateTimeKind.Local).AddTicks(312), null, null, "Ayham", false, null, "p@p2h.com", "p@p2h.com", "AQAAAAIAAYagAAAAEIB5BEaauUFZfKej1+O34b92zl/zXLlpgMx1qCSx5gOOl/ZhKCPLhi6tegBt6U2rxw==", "7894561230", false, "ef433250-d9d0-4d5d-b839-85adb519f337", null, false, "p@p2h.com" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AreaId", "CityId", "UserId" },
                values: new object[,]
                {
                    { new Guid("174bdefa-6914-4a9b-9939-11dcd43b671f"), 1, 1, "dcb6dc20-faac-4a60-a0be-d4204016f5fc" },
                    { new Guid("49b301b7-839a-4d34-9e51-53732be5931f"), 1, 1, "cef369e2-8698-450b-818a-46a5733a2e23" },
                    { new Guid("6636824e-d494-481f-ab8d-48e7ec49e3c8"), 1, 1, "27dd180e-4a4c-4c3f-849d-f61e0a846cc6" },
                    { new Guid("9cec542b-d7a6-4f3e-a1c9-604bca3fb60c"), 1, 1, "3acc729d-1693-400f-adb3-382c9419d50c" },
                    { new Guid("b6b7ac1f-bab4-4594-adc4-2254cf90ef9a"), 1, 1, "955c02e9-e68f-49db-a6dd-f520c4d35cdc" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "27dd180e-4a4c-4c3f-849d-f61e0a846cc6" },
                    { "1", "3acc729d-1693-400f-adb3-382c9419d50c" },
                    { "5", "955c02e9-e68f-49db-a6dd-f520c4d35cdc" },
                    { "2", "cef369e2-8698-450b-818a-46a5733a2e23" },
                    { "4", "dcb6dc20-faac-4a60-a0be-d4204016f5fc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("174bdefa-6914-4a9b-9939-11dcd43b671f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("49b301b7-839a-4d34-9e51-53732be5931f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6636824e-d494-481f-ab8d-48e7ec49e3c8"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9cec542b-d7a6-4f3e-a1c9-604bca3fb60c"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b6b7ac1f-bab4-4594-adc4-2254cf90ef9a"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "27dd180e-4a4c-4c3f-849d-f61e0a846cc6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "3acc729d-1693-400f-adb3-382c9419d50c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5", "955c02e9-e68f-49db-a6dd-f520c4d35cdc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "cef369e2-8698-450b-818a-46a5733a2e23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "dcb6dc20-faac-4a60-a0be-d4204016f5fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27dd180e-4a4c-4c3f-849d-f61e0a846cc6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3acc729d-1693-400f-adb3-382c9419d50c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "955c02e9-e68f-49db-a6dd-f520c4d35cdc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cef369e2-8698-450b-818a-46a5733a2e23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dcb6dc20-faac-4a60-a0be-d4204016f5fc");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Age", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "Experience", "FirstName", "Gender", "HireDate", "ImagePath", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialization", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5e23e00a-b0fc-4b3e-9a7f-bb9a5250e0ee", 0, new Guid("a0219a68-9759-4d19-b69b-b06ab2734e37"), null, "82c7fe41-380e-47db-9205-a88694f2c303", 8, "p@p2h.com", false, null, "Pharmacist", null, new DateTime(2025, 1, 9, 0, 43, 11, 150, DateTimeKind.Local).AddTicks(1292), null, null, "Ayham", false, null, "p@p2h.com", "p@p2h.com", "AQAAAAIAAYagAAAAED1YcEf6y08gDvQy13QS8vSJgYCJxFEw47JsMSIT8DmTOYBBT/VhKrp7PnPtS/KCBA==", "7894561230", false, "62a157ae-1202-4115-a8ad-1273f3ff711c", null, false, "p@p2h.com" },
                    { "974350b0-5ecb-4015-8825-19f190c268bc", 0, new Guid("0ccd5f8b-c033-42d3-9865-be981abb1344"), null, "2fe0579c-00d0-416b-a4c0-fbf7b23ba73d", 1, "a@p2h.com", false, null, "Admin", null, new DateTime(2025, 1, 9, 0, 43, 11, 204, DateTimeKind.Local).AddTicks(1110), null, null, "Yousef", false, null, "A@P2H.COM", "a@p2h.com", "AQAAAAIAAYagAAAAEDUybBzosYBRm/K1ufky5BTwCiVn/UYv2Iup6hfdfDG7EilmosZX7n3GZePmOYGeCA==", "3216549870", false, "35281e7c-37e0-439a-8ab6-9deb9585b445", null, false, "a@p2h.com" },
                    { "cea7eb50-7d7e-4515-8830-f9d3f3e80753", 0, new Guid("bb2f8927-6eec-4f59-85ba-7fa71af0d4e9"), null, "5fec403c-276d-4e6b-b49c-fc7150ca2ec0", 1, "n@p2h.com", false, null, "Nurse", null, new DateTime(2025, 1, 9, 0, 43, 11, 45, DateTimeKind.Local).AddTicks(4501), null, null, "Sameera", false, null, "n@p2h.com", "n@p2h.com", "AQAAAAIAAYagAAAAEAMvqqoL4x/Nw+z1Wv9XRtJ/93qLKbaEQKItbxtqEOMRlfLoqfNtpV7gkdfZJ7TAlw==", "0987654321", false, "c8fa9867-7308-4c89-b323-afed432f90a6", null, false, "n@p2h.com" },
                    { "e386740c-cd9b-40e8-88b0-455bd4769f59", 0, new Guid("0699e4af-6a8b-4647-80f9-f567610901ae"), null, "0924f4b2-4792-4237-93ca-8280d7bee886", 1, "d@p2h.com", false, null, "Doctor", null, new DateTime(2025, 1, 9, 0, 43, 10, 998, DateTimeKind.Local).AddTicks(2676), null, null, "Ahmad", false, null, "d@p2h.com", "d@p2h.com", "AQAAAAIAAYagAAAAEETXpoh3EVZot3ta8+ciHRpLKteQvTiXIli/F6KyTvSovxDwNSYKI/2w3LbvUFOGng==", "1234567890", false, "6d79b5a6-63a5-403a-8305-a0aa7b4bb2a9", null, false, "d@p2h.com" },
                    { "f42cf095-eed2-4f46-87f8-8abcb25eb59f", 0, new Guid("5531533d-5e32-49cf-bbce-c599db02c5a3"), null, "d6c97ea8-3961-4280-ad88-f958828b92ae", 9, "m@p2h.com", false, null, "Manager", null, new DateTime(2025, 1, 9, 0, 43, 11, 93, DateTimeKind.Local).AddTicks(4816), null, null, "Mohammad", false, null, "m@p2h.com", "m@p2h.com", "AQAAAAIAAYagAAAAELN+eBne+CtbA9ZHJerXiepVbrJBvfLugUr+TOlTHtJIjDNb0WzG4L6bW5ftSNVYPg==", "4561237890", false, "ff0e5142-8586-4ffb-9cf4-9e46dec0665c", null, false, "m@p2h.com" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AreaId", "CityId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0699e4af-6a8b-4647-80f9-f567610901ae"), 1, 1, "e386740c-cd9b-40e8-88b0-455bd4769f59" },
                    { new Guid("0ccd5f8b-c033-42d3-9865-be981abb1344"), 1, 1, "974350b0-5ecb-4015-8825-19f190c268bc" },
                    { new Guid("5531533d-5e32-49cf-bbce-c599db02c5a3"), 1, 1, "f42cf095-eed2-4f46-87f8-8abcb25eb59f" },
                    { new Guid("a0219a68-9759-4d19-b69b-b06ab2734e37"), 1, 1, "5e23e00a-b0fc-4b3e-9a7f-bb9a5250e0ee" },
                    { new Guid("bb2f8927-6eec-4f59-85ba-7fa71af0d4e9"), 1, 1, "cea7eb50-7d7e-4515-8830-f9d3f3e80753" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4", "5e23e00a-b0fc-4b3e-9a7f-bb9a5250e0ee" },
                    { "5", "974350b0-5ecb-4015-8825-19f190c268bc" },
                    { "2", "cea7eb50-7d7e-4515-8830-f9d3f3e80753" },
                    { "1", "e386740c-cd9b-40e8-88b0-455bd4769f59" },
                    { "3", "f42cf095-eed2-4f46-87f8-8abcb25eb59f" }
                });
        }
    }
}
