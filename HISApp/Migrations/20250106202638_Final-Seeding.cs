using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HISApp.Migrations
{
    /// <inheritdoc />
    public partial class FinalSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("16022e3a-02a5-497f-bf64-e0323763cde2"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("40129129-83eb-4441-a3a9-d169403f0d1a"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("75c30058-dc93-4687-bd16-64e698021147"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8a27c24c-e202-49a0-a0d8-19808d7fb09f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b017af2e-b132-4d16-8ad6-c1efdb514ab2"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1ae647e3-337d-4565-baa1-739a6ee86408" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "9b1a1b29-56f2-4db8-a659-39a829f1ca3d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "e912474e-a4d8-43a9-953a-f491f07d937a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5", "eb08654f-58ec-4921-8d1c-64b6aa8429b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "f375e769-8fa6-4ef2-99c3-9b62f4e26132" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae647e3-337d-4565-baa1-739a6ee86408");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a1b29-56f2-4db8-a659-39a829f1ca3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e912474e-a4d8-43a9-953a-f491f07d937a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb08654f-58ec-4921-8d1c-64b6aa8429b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f375e769-8fa6-4ef2-99c3-9b62f4e26132");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Addresses",
                columns: new[] { "Id", "AreaId", "CityId", "UserId" },
                values: new object[,]
                {
                    { new Guid("16022e3a-02a5-497f-bf64-e0323763cde2"), 1, 1, null },
                    { new Guid("40129129-83eb-4441-a3a9-d169403f0d1a"), 1, 1, null },
                    { new Guid("75c30058-dc93-4687-bd16-64e698021147"), 1, 1, null },
                    { new Guid("8a27c24c-e202-49a0-a0d8-19808d7fb09f"), 1, 1, null },
                    { new Guid("b017af2e-b132-4d16-8ad6-c1efdb514ab2"), 1, 1, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Age", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "Experience", "FirstName", "Gender", "HireDate", "ImagePath", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialization", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1ae647e3-337d-4565-baa1-739a6ee86408", 0, new Guid("16022e3a-02a5-497f-bf64-e0323763cde2"), null, "85f7b0d7-1d36-4442-9a23-7b21a9514666", null, "d@d.d", false, null, "Doctor", null, new DateTime(2025, 1, 6, 23, 23, 42, 67, DateTimeKind.Local).AddTicks(9647), null, null, "Ahmad", false, null, "D@D.D", "D@D.D", "AQAAAAIAAYagAAAAEIQeuwYtvtCTWfiwA+n6pEEAnrWB8s6gaG4C9fJ6jcWPNt897H3AJ2Td3jZoR1HwkA==", "1234567890", false, "6c441e76-79c5-47bb-b4a6-db4e7616ca2a", null, false, "d@d.d" },
                    { "9b1a1b29-56f2-4db8-a659-39a829f1ca3d", 0, new Guid("75c30058-dc93-4687-bd16-64e698021147"), null, "2dccab44-d7f0-4de5-bc10-2ff91700cb81", null, "p@p.p", false, null, "Pharmacist", null, new DateTime(2025, 1, 6, 23, 23, 42, 217, DateTimeKind.Local).AddTicks(93), null, null, "Ayham", false, null, "P@P.P", "P@P.P", "AQAAAAIAAYagAAAAEKvoJVaLs3jTbVTuQLXOZkG0326tBjaP6LbYqwpC1dKIWCO4U6zSpw+aOwIwibvfhQ==", "7894561230", false, "46c93dc0-a949-4140-8abd-36df836dcbcb", null, false, "p@p.p" },
                    { "e912474e-a4d8-43a9-953a-f491f07d937a", 0, new Guid("b017af2e-b132-4d16-8ad6-c1efdb514ab2"), null, "2b5c8293-883e-4c57-9f3e-262f54538ca5", null, "m@m.m", false, null, "Manager", null, new DateTime(2025, 1, 6, 23, 23, 42, 166, DateTimeKind.Local).AddTicks(9282), null, null, "Mohammad", false, null, "M@M.M", "M@M.M", "AQAAAAIAAYagAAAAEBEWrjX2UEEH8dXbFILgr9+zABx8BToW+fhfxQvZC9Xr/OKhngxc/Ecd269aWeXN8Q==", "4561237890", false, "7e0c5e66-3265-4dcb-8d9c-a64b5fde9055", null, false, "m@m.m" },
                    { "eb08654f-58ec-4921-8d1c-64b6aa8429b4", 0, new Guid("40129129-83eb-4441-a3a9-d169403f0d1a"), null, "82284cd2-9cca-4a59-835a-ac0de689c2f4", null, "a@a.a", false, null, "Admin", null, new DateTime(2025, 1, 6, 23, 23, 42, 266, DateTimeKind.Local).AddTicks(756), null, null, "Yousef", false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEJd9BNwpDQhfoHLOLmn5IPBl1dxcXXFWfVqq6qoJEcPYV1RZt0NYAIn7E/qKRGHVfA==", "3216549870", false, "edd2a746-c3fb-4c0e-9a2e-1bd111945573", null, false, "a@a.a" },
                    { "f375e769-8fa6-4ef2-99c3-9b62f4e26132", 0, new Guid("8a27c24c-e202-49a0-a0d8-19808d7fb09f"), null, "45bb6543-66ee-4f1d-b9d5-fe62823ba349", null, "n@n.n", false, null, "Nurse", null, new DateTime(2025, 1, 6, 23, 23, 42, 117, DateTimeKind.Local).AddTicks(119), null, null, "Sameera", false, null, "N@N.N", "N@N.N", "AQAAAAIAAYagAAAAEB2vzgdd33sPIu/L5uOfcdeqm3u0l4Gay5DC+e1gSLtPjGNropp59F7+37C57v+4Ow==", "0987654321", false, "2619729d-e2e7-40d2-bbfb-86b4bf2fca65", null, false, "n@n.n" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1ae647e3-337d-4565-baa1-739a6ee86408" },
                    { "4", "9b1a1b29-56f2-4db8-a659-39a829f1ca3d" },
                    { "3", "e912474e-a4d8-43a9-953a-f491f07d937a" },
                    { "5", "eb08654f-58ec-4921-8d1c-64b6aa8429b4" },
                    { "2", "f375e769-8fa6-4ef2-99c3-9b62f4e26132" }
                });
        }
    }
}
