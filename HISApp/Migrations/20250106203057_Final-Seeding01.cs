using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HISApp.Migrations
{
    /// <inheritdoc />
    public partial class FinalSeeding01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("818c0a1d-8ded-41c0-878f-6045afa87bf5"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("96b2bfe8-a075-4edf-bf1b-ad27c0287650"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9ad03a9e-5402-486c-b449-70de4dc4a1a8"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a5baf789-f480-4b5e-8f79-1d1ab75468c6"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("dde58956-8840-4f60-923c-831b606abecd"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "4c6e76e2-b401-424c-9e43-3b6fd67de69b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5", "9631cb6c-b01d-4fb2-b2c6-f257967ca683" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "9e95c3b8-51fd-4997-8436-eb39fc91e543" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "cff7e19d-1239-4b79-ba44-d6d29b6fea1b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "da6f9481-573c-494e-9be9-6be00fa714fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c6e76e2-b401-424c-9e43-3b6fd67de69b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9631cb6c-b01d-4fb2-b2c6-f257967ca683");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e95c3b8-51fd-4997-8436-eb39fc91e543");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cff7e19d-1239-4b79-ba44-d6d29b6fea1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da6f9481-573c-494e-9be9-6be00fa714fc");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Addresses",
                columns: new[] { "Id", "AreaId", "CityId", "UserId" },
                values: new object[,]
                {
                    { new Guid("818c0a1d-8ded-41c0-878f-6045afa87bf5"), 1, 1, null },
                    { new Guid("96b2bfe8-a075-4edf-bf1b-ad27c0287650"), 1, 1, null },
                    { new Guid("9ad03a9e-5402-486c-b449-70de4dc4a1a8"), 1, 1, null },
                    { new Guid("a5baf789-f480-4b5e-8f79-1d1ab75468c6"), 1, 1, null },
                    { new Guid("dde58956-8840-4f60-923c-831b606abecd"), 1, 1, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Age", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "Experience", "FirstName", "Gender", "HireDate", "ImagePath", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialization", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4c6e76e2-b401-424c-9e43-3b6fd67de69b", 0, new Guid("96b2bfe8-a075-4edf-bf1b-ad27c0287650"), null, "ebcde769-eb48-4a4a-93c4-20e052f9bef2", 1, "d@d.d", false, null, "Doctor", null, new DateTime(2025, 1, 6, 23, 26, 37, 522, DateTimeKind.Local).AddTicks(2587), null, null, "Ahmad", false, null, "D@D.D", "D@D.D", "AQAAAAIAAYagAAAAEE3gD0IjL+qKKbh8tUh4aNRUlEDYzzj73Id8F7ovBaZ1kFEe4xVipf5wI5ewfR2cyg==", "1234567890", false, "153a80b7-f8c2-4785-bc64-0dad894ce295", null, false, "d@d.d" },
                    { "9631cb6c-b01d-4fb2-b2c6-f257967ca683", 0, new Guid("818c0a1d-8ded-41c0-878f-6045afa87bf5"), null, "0d17bb5b-d3da-4296-b34d-401d0b606412", 1, "a@a.a", false, null, "Admin", null, new DateTime(2025, 1, 6, 23, 26, 37, 721, DateTimeKind.Local).AddTicks(8113), null, null, "Yousef", false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEAEhn/BtCxgXhlqTQuGWhOZZ0CCwybq0iHgzGPPK8f6DdB1pjq++Yr3OiIH/3Ck60Q==", "3216549870", false, "7b4da10a-ff9b-49ad-bb7d-7147fa502d8f", null, false, "a@a.a" },
                    { "9e95c3b8-51fd-4997-8436-eb39fc91e543", 0, new Guid("9ad03a9e-5402-486c-b449-70de4dc4a1a8"), null, "eb20eb7e-4342-4bfc-ba36-58fd5a663d92", 8, "p@p.p", false, null, "Pharmacist", null, new DateTime(2025, 1, 6, 23, 26, 37, 669, DateTimeKind.Local).AddTicks(1143), null, null, "Ayham", false, null, "P@P.P", "P@P.P", "AQAAAAIAAYagAAAAED7OHJvJiyftvZXsQ03EykQKwVZESExXSWeE3wYhGclzxlaeQhnbDzpnipAMQ/MCvw==", "7894561230", false, "04f551cd-71ff-4822-bc30-f0e4ef94bc85", null, false, "p@p.p" },
                    { "cff7e19d-1239-4b79-ba44-d6d29b6fea1b", 0, new Guid("dde58956-8840-4f60-923c-831b606abecd"), null, "9a90add9-ce8d-497f-ad9b-57bca3e43ce8", 1, "n@n.n", false, null, "Nurse", null, new DateTime(2025, 1, 6, 23, 26, 37, 569, DateTimeKind.Local).AddTicks(7230), null, null, "Sameera", false, null, "N@N.N", "N@N.N", "AQAAAAIAAYagAAAAEBV3DMkR3qUs8Nwn6AM8E1GNstm4kFpgS1yZK3Sk8oZq8HU99V+799kMQAA0Z2YRBA==", "0987654321", false, "0157bf48-a82d-489e-b025-22d3c020915d", null, false, "n@n.n" },
                    { "da6f9481-573c-494e-9be9-6be00fa714fc", 0, new Guid("a5baf789-f480-4b5e-8f79-1d1ab75468c6"), null, "03f4dc95-8f4c-4490-9e3e-6eb223e3d69a", 9, "m@m.m", false, null, "Manager", null, new DateTime(2025, 1, 6, 23, 26, 37, 620, DateTimeKind.Local).AddTicks(2366), null, null, "Mohammad", false, null, "M@M.M", "M@M.M", "AQAAAAIAAYagAAAAEEcE9RjwAz01yKI8XX+Lo5a+pPHxzecJH8QqZDbn4mUqKRwUW/HnH+IBcWO7VjMJBg==", "4561237890", false, "cdfead61-db82-4b5a-a2ff-7956fdadfe73", null, false, "m@m.m" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "4c6e76e2-b401-424c-9e43-3b6fd67de69b" },
                    { "5", "9631cb6c-b01d-4fb2-b2c6-f257967ca683" },
                    { "4", "9e95c3b8-51fd-4997-8436-eb39fc91e543" },
                    { "2", "cff7e19d-1239-4b79-ba44-d6d29b6fea1b" },
                    { "3", "da6f9481-573c-494e-9be9-6be00fa714fc" }
                });
        }
    }
}
