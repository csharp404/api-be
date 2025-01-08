using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HISApp.Migrations
{
    /// <inheritdoc />
    public partial class fixing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("058fb2cf-9c80-4d9b-83a7-639488cc6342"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("11ec1d7a-5b99-4147-9c20-5717585dfb68"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("1da6ae9e-04ed-4c1c-84a9-bf005ea05e23"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2c371044-fbda-4fc3-b89d-799385947ab2"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("53125a5a-e5e3-4ecc-b36c-f3c325ded6f1"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "1c9134a1-ffa3-4ba9-806f-1bc9c6a40487" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "48fedb94-6b86-4cc9-9bb7-f541ef628e04" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "96aaaade-b4ca-43b6-8afe-dac218f22ecc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5", "e9cd048e-920d-478b-a8b2-80a8b0ee7291" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "fc1ad53c-ca87-429d-9b85-24aa0853d016" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c9134a1-ffa3-4ba9-806f-1bc9c6a40487");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48fedb94-6b86-4cc9-9bb7-f541ef628e04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96aaaade-b4ca-43b6-8afe-dac218f22ecc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9cd048e-920d-478b-a8b2-80a8b0ee7291");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc1ad53c-ca87-429d-9b85-24aa0853d016");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "1c9134a1-ffa3-4ba9-806f-1bc9c6a40487", 0, null, null, "5bdff36d-40da-4b6d-854e-8e0db0ceedfc", 1, "n@n.n", false, null, "Nurse", null, new DateTime(2025, 1, 6, 23, 30, 57, 164, DateTimeKind.Local).AddTicks(2662), null, null, "Sameera", false, null, "N@N.N", "N@N.N", "AQAAAAIAAYagAAAAENr+IsCMzMaaQfNYP1oZ7bx2LVTmNPfDh/tjYuP0DJf0e6VriM1e8Uf6Hgz50ecJ9g==", "0987654321", false, "46e15e6d-6b9e-4a31-bab3-453afb964d8f", null, false, "n@n.n" },
                    { "48fedb94-6b86-4cc9-9bb7-f541ef628e04", 0, null, null, "3922b4df-87dd-4613-9350-d02359f2c77d", 9, "m@m.m", false, null, "Manager", null, new DateTime(2025, 1, 6, 23, 30, 57, 214, DateTimeKind.Local).AddTicks(4966), null, null, "Mohammad", false, null, "M@M.M", "M@M.M", "AQAAAAIAAYagAAAAEJJwpjEGVYmBVuLlavlwVvRGA3nMp12/bsqVQKjYTsp/OENdTRdNQiKMhH8bjkS7MQ==", "4561237890", false, "9c292c0c-428b-465b-9002-8f68575401d5", null, false, "m@m.m" },
                    { "96aaaade-b4ca-43b6-8afe-dac218f22ecc", 0, null, null, "b2e0e36f-f29d-491a-b571-001915f76c35", 1, "d@d.d", false, null, "Doctor", null, new DateTime(2025, 1, 6, 23, 30, 57, 116, DateTimeKind.Local).AddTicks(9901), null, null, "Ahmad", false, null, "D@D.D", "D@D.D", "AQAAAAIAAYagAAAAEFmAUjZzKv8SVq76cxFmKXLbfervIMr63Cs92tcXkCoc273iV81YI7J/e+rNHTK5Xg==", "1234567890", false, "a3cc1905-a1c7-478a-a03f-9b9a09af0f22", null, false, "d@d.d" },
                    { "e9cd048e-920d-478b-a8b2-80a8b0ee7291", 0, null, null, "3e7f16a8-5e76-4036-b26a-bc07697d2c4f", 1, "a@a.a", false, null, "Admin", null, new DateTime(2025, 1, 6, 23, 30, 57, 322, DateTimeKind.Local).AddTicks(4830), null, null, "Yousef", false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEACzu6DgaXX2DfX8hvAng9d4xmU0GKJORLPSGGNIyUEeJmdn0VqO26+XehUmGprw5w==", "3216549870", false, "8ad87687-2320-4892-bed5-e9bfb9da0bdb", null, false, "a@a.a" },
                    { "fc1ad53c-ca87-429d-9b85-24aa0853d016", 0, null, null, "0eb94951-24ec-4bb0-bd76-c32d2403fd94", 8, "p@p.p", false, null, "Pharmacist", null, new DateTime(2025, 1, 6, 23, 30, 57, 264, DateTimeKind.Local).AddTicks(4224), null, null, "Ayham", false, null, "P@P.P", "P@P.P", "AQAAAAIAAYagAAAAEE5yE2vthdUSYCkM5dgo1s/t8lqeIXFC8RUtrk6yJh6pvxOLeap0R2REayUsPrBcFA==", "7894561230", false, "e19e48f4-060f-488e-ba06-5685dc6e9544", null, false, "p@p.p" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AreaId", "CityId", "UserId" },
                values: new object[,]
                {
                    { new Guid("058fb2cf-9c80-4d9b-83a7-639488cc6342"), 1, 1, "96aaaade-b4ca-43b6-8afe-dac218f22ecc" },
                    { new Guid("11ec1d7a-5b99-4147-9c20-5717585dfb68"), 1, 1, "e9cd048e-920d-478b-a8b2-80a8b0ee7291" },
                    { new Guid("1da6ae9e-04ed-4c1c-84a9-bf005ea05e23"), 1, 1, "48fedb94-6b86-4cc9-9bb7-f541ef628e04" },
                    { new Guid("2c371044-fbda-4fc3-b89d-799385947ab2"), 1, 1, "1c9134a1-ffa3-4ba9-806f-1bc9c6a40487" },
                    { new Guid("53125a5a-e5e3-4ecc-b36c-f3c325ded6f1"), 1, 1, "fc1ad53c-ca87-429d-9b85-24aa0853d016" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "1c9134a1-ffa3-4ba9-806f-1bc9c6a40487" },
                    { "3", "48fedb94-6b86-4cc9-9bb7-f541ef628e04" },
                    { "1", "96aaaade-b4ca-43b6-8afe-dac218f22ecc" },
                    { "5", "e9cd048e-920d-478b-a8b2-80a8b0ee7291" },
                    { "4", "fc1ad53c-ca87-429d-9b85-24aa0853d016" }
                });
        }
    }
}
