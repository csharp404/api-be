using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HISApp.Migrations
{
    /// <inheritdoc />
    public partial class finalize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaim_Role_RoleId",
                table: "RoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaim_AspNetUsers_UserId",
                table: "UserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_AspNetUsers_UserId",
                table: "UserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_AspNetUsers_UserId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToken_AspNetUsers_UserId",
                table: "UserToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserToken",
                table: "UserToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogin",
                table: "UserLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaim",
                table: "UserClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaim",
                table: "RoleClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2faf3fb8-a244-4b16-a64b-292bc41ab33f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("33b381b1-9aee-4738-80d0-cfaa227f6c84"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("43df8245-0b6e-4bb5-ac84-6a4483a721f7"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5b14b6c5-7b1c-40b3-989f-a344ad9649de"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("c1b83720-f0ec-4ec0-af03-73f750f5d0a9"));

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "036ef810-4ddb-40b5-a735-8a389f534ec1" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5", "281598ab-3ed7-45d0-a986-b085013fb81e" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "89dfed28-2508-4a36-b0c4-af3a24dc98ab" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "a245ac46-0713-44bb-9f96-95901165694b" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "dcc48351-d017-4746-b2ab-a6df4ea5615f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "036ef810-4ddb-40b5-a735-8a389f534ec1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "281598ab-3ed7-45d0-a986-b085013fb81e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89dfed28-2508-4a36-b0c4-af3a24dc98ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a245ac46-0713-44bb-9f96-95901165694b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dcc48351-d017-4746-b2ab-a6df4ea5615f");

            migrationBuilder.RenameTable(
                name: "UserToken",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogin",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaim",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "RoleClaim",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "AspNetRoles");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogin_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaim_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaim_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Age", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "Experience", "FirstName", "Gender", "HireDate", "ImagePath", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialization", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3357d377-776f-4414-a3eb-2d8e1fd3b025", 0, new Guid("33fa2f3e-373f-4448-b037-57745771946d"), 45, "a3cfbe71-e86b-4bad-9704-4712bd7ad98e", 1, "n@p2h.com", false, "12", "Nurse", false, new DateTime(2025, 1, 9, 3, 51, 51, 303, DateTimeKind.Local).AddTicks(4153), null, null, "Sameera", false, null, "N@P2H.COM", "N@P2H.COM", "AQAAAAIAAYagAAAAEAjcj2URZwpNfSt05xfTFX+XGpk21DPpLIyWZsj16hN6GUFRzY6CXQ7bLvZkfOwvUw==", "0781227894", false, "69714fde-fce7-4356-8416-a6c54996c0b2", null, false, "n@p2h.com" },
                    { "720a2ab3-d717-48e1-81ed-f4319d99f6ba", 0, new Guid("27e8f53d-a5cd-419c-baa7-8e5545c1aaf9"), 33, "466f4cdf-0a2a-441b-925c-71c00e95691f", 8, "p@p2h.com", false, "12", "Pharmacist", true, new DateTime(2025, 1, 9, 3, 51, 51, 401, DateTimeKind.Local).AddTicks(7544), null, null, "Ayham", false, null, "P@P2H.COM", "P@P2H.COM", "AQAAAAIAAYagAAAAEPcLvJJXo4DZEQ/qb0yr+nXLTejx22bLy4P0EMaKBL9UdDij59kSq+FyRwt7sbWJKw==", "0781227894", false, "4b2f21fa-4ded-4616-a104-c9c064e9fc31", null, false, "p@p2h.com" },
                    { "7eb60dc9-0624-464d-b714-40d7969c1bf1", 0, new Guid("15a24dfe-845b-4a6b-8381-e6af77b0aee3"), 40, "a29c25e2-16a3-4a9b-b92d-cd30cd0a8e8a", 1, "d@p2h.com", false, "12", "Doctor", true, new DateTime(2025, 1, 9, 3, 51, 51, 253, DateTimeKind.Local).AddTicks(8407), null, null, "Ahmad", false, null, "D@P2H.COM", "D@P2H.COM", "AQAAAAIAAYagAAAAEIFKxORZnf4RrJhi0nrZMrNEnsC3SRgyAItS3hv6rIKExb5pvju+ya14goKAuRFAKQ==", "0781221223", false, "79da8b94-93d1-450c-ab93-97c5a25bd559", null, false, "d@p2h.com" },
                    { "ad806a90-0577-4811-bb3e-c7589835476d", 0, new Guid("d36412b1-542d-44b9-9dd4-3bf1538149a7"), 40, "6f8c0442-0bff-4cfd-a1a8-795d4cda1c5e", 9, "m@p2h.com", false, "12", "Manager", true, new DateTime(2025, 1, 9, 3, 51, 51, 354, DateTimeKind.Local).AddTicks(3400), null, null, "Mohammad", false, null, "M@P2H.COM", "M@P2H.COM", "AQAAAAIAAYagAAAAEN9U+VDZYCi2wT0+IIEHHGCpuduvdbBcfzN3ftfdb/uyPaQbIFO8JY9zyHK/qbw/7g==", "0781221244", false, "0a8493ab-f4d5-43e1-aa65-f4495fac8290", null, false, "m@p2h.com" },
                    { "fd05d6dc-2699-4f5f-bef7-bd12ef130408", 0, new Guid("93816845-789a-4e32-967f-40cea279b8a7"), 26, "3fab5cf4-45cb-4fc9-a7db-7970b0bdc666", 1, "a@p2h.com", false, "12", "Admin", true, new DateTime(2025, 1, 9, 3, 51, 51, 453, DateTimeKind.Local).AddTicks(3654), null, null, "Yousef", false, null, "A@P2H.COM", "A@P2H.COM", "AQAAAAIAAYagAAAAEFAjDVaj/7yeITZlgPyRpmPgbcXWgQ7KzXuq2gcANA3DTwoXra7yA54H7bn8OOvScQ==", "0781224567", false, "b1916a6f-6718-402c-bfda-8edeaa2cb1f2", null, false, "a@p2h.com" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AreaId", "CityId", "UserId" },
                values: new object[,]
                {
                    { new Guid("15a24dfe-845b-4a6b-8381-e6af77b0aee3"), 1, 1, "7eb60dc9-0624-464d-b714-40d7969c1bf1" },
                    { new Guid("27e8f53d-a5cd-419c-baa7-8e5545c1aaf9"), 1, 1, "720a2ab3-d717-48e1-81ed-f4319d99f6ba" },
                    { new Guid("33fa2f3e-373f-4448-b037-57745771946d"), 1, 1, "3357d377-776f-4414-a3eb-2d8e1fd3b025" },
                    { new Guid("93816845-789a-4e32-967f-40cea279b8a7"), 1, 1, "fd05d6dc-2699-4f5f-bef7-bd12ef130408" },
                    { new Guid("d36412b1-542d-44b9-9dd4-3bf1538149a7"), 1, 1, "ad806a90-0577-4811-bb3e-c7589835476d" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "3357d377-776f-4414-a3eb-2d8e1fd3b025" },
                    { "4", "720a2ab3-d717-48e1-81ed-f4319d99f6ba" },
                    { "1", "7eb60dc9-0624-464d-b714-40d7969c1bf1" },
                    { "3", "ad806a90-0577-4811-bb3e-c7589835476d" },
                    { "5", "fd05d6dc-2699-4f5f-bef7-bd12ef130408" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("15a24dfe-845b-4a6b-8381-e6af77b0aee3"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("27e8f53d-a5cd-419c-baa7-8e5545c1aaf9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("33fa2f3e-373f-4448-b037-57745771946d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("93816845-789a-4e32-967f-40cea279b8a7"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d36412b1-542d-44b9-9dd4-3bf1538149a7"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "3357d377-776f-4414-a3eb-2d8e1fd3b025" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "720a2ab3-d717-48e1-81ed-f4319d99f6ba" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "7eb60dc9-0624-464d-b714-40d7969c1bf1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "ad806a90-0577-4811-bb3e-c7589835476d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5", "fd05d6dc-2699-4f5f-bef7-bd12ef130408" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3357d377-776f-4414-a3eb-2d8e1fd3b025");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "720a2ab3-d717-48e1-81ed-f4319d99f6ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7eb60dc9-0624-464d-b714-40d7969c1bf1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad806a90-0577-4811-bb3e-c7589835476d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd05d6dc-2699-4f5f-bef7-bd12ef130408");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "UserToken");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "UserLogin");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "UserClaim");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "RoleClaim");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "UserRole",
                newName: "IX_UserRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "UserLogin",
                newName: "IX_UserLogin_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "UserClaim",
                newName: "IX_UserClaim_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "RoleClaim",
                newName: "IX_RoleClaim_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserToken",
                table: "UserToken",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogin",
                table: "UserLogin",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaim",
                table: "UserClaim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaim",
                table: "RoleClaim",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Age", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "Experience", "FirstName", "Gender", "HireDate", "ImagePath", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialization", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "036ef810-4ddb-40b5-a735-8a389f534ec1", 0, new Guid("33b381b1-9aee-4738-80d0-cfaa227f6c84"), 45, "492fe301-d035-4168-b1bb-ba951d3e3143", 1, "n@p2h.com", false, "12", "Nurse", false, new DateTime(2025, 1, 9, 0, 54, 7, 22, DateTimeKind.Local).AddTicks(1745), null, null, "Sameera", false, null, "n@p2h.com", "n@p2h.com", "AQAAAAIAAYagAAAAED4y9RvYyMQW0Guq6e+RZAKduIVDCurtjfqtrAyjB6b5JMnrnSE4hwk9uNrM3uSj+A==", "0781227894", false, "b966dc56-33fd-4310-8157-1349f9428118", null, false, "n@p2h.com" },
                    { "281598ab-3ed7-45d0-a986-b085013fb81e", 0, new Guid("5b14b6c5-7b1c-40b3-989f-a344ad9649de"), 26, "acd00d3d-e676-42f6-8086-a60299dca5af", 1, "a@p2h.com", false, "12", "Admin", true, new DateTime(2025, 1, 9, 0, 54, 7, 167, DateTimeKind.Local).AddTicks(1749), null, null, "Yousef", false, null, "A@P2H.COM", "a@p2h.com", "AQAAAAIAAYagAAAAEKtTh2R0DGm1hI3A5DE9x5Ff63/l20P04uvdLQLhW6kPEl/Eq4/ir1Tz82+L3xfQNw==", "0781224567", false, "2ad84626-be1f-4b2e-a949-896a288512e1", null, false, "a@p2h.com" },
                    { "89dfed28-2508-4a36-b0c4-af3a24dc98ab", 0, new Guid("43df8245-0b6e-4bb5-ac84-6a4483a721f7"), 40, "c694e968-9017-4d47-8f92-e31e1abc69dd", 1, "d@p2h.com", false, "12", "Doctor", true, new DateTime(2025, 1, 9, 0, 54, 6, 973, DateTimeKind.Local).AddTicks(9923), null, null, "Ahmad", false, null, "d@p2h.com", "d@p2h.com", "AQAAAAIAAYagAAAAEMFyQFpnKn9GA6m02yjkmXST2krYJ/op+sED/hlEgkTx5D+bI3sqvZGoE2RFExq3dg==", "0781221223", false, "2b4fbd3e-2e1a-4bd9-906e-8a8c48a17308", null, false, "d@p2h.com" },
                    { "a245ac46-0713-44bb-9f96-95901165694b", 0, new Guid("c1b83720-f0ec-4ec0-af03-73f750f5d0a9"), 40, "bfa76dee-9018-4e2a-84ca-62828571957f", 9, "m@p2h.com", false, "12", "Manager", true, new DateTime(2025, 1, 9, 0, 54, 7, 70, DateTimeKind.Local).AddTicks(3368), null, null, "Mohammad", false, null, "m@p2h.com", "m@p2h.com", "AQAAAAIAAYagAAAAEGPF6zzVV2sR0Cbr+U1hsFMMRyT+fqFqgg+8eEHod2/5PKBzgBLTfSgszP/lcDGqCw==", "0781221244", false, "35c776b2-de97-4cfd-a891-0c03e2d4f0f9", null, false, "m@p2h.com" },
                    { "dcc48351-d017-4746-b2ab-a6df4ea5615f", 0, new Guid("2faf3fb8-a244-4b16-a64b-292bc41ab33f"), 33, "83a782c9-3374-4c83-8690-e210349b61db", 8, "p@p2h.com", false, "12", "Pharmacist", true, new DateTime(2025, 1, 9, 0, 54, 7, 118, DateTimeKind.Local).AddTicks(3928), null, null, "Ayham", false, null, "p@p2h.com", "p@p2h.com", "AQAAAAIAAYagAAAAENRAJnkqaO3UwQhyamircdADpCsyFrwopVMAnuEw6BF4balsA32FPEx/IqVRizyXnA==", "0781227894", false, "888cc3eb-9b73-4824-9bf8-66003a3e986d", null, false, "p@p2h.com" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AreaId", "CityId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2faf3fb8-a244-4b16-a64b-292bc41ab33f"), 1, 1, "dcc48351-d017-4746-b2ab-a6df4ea5615f" },
                    { new Guid("33b381b1-9aee-4738-80d0-cfaa227f6c84"), 1, 1, "036ef810-4ddb-40b5-a735-8a389f534ec1" },
                    { new Guid("43df8245-0b6e-4bb5-ac84-6a4483a721f7"), 1, 1, "89dfed28-2508-4a36-b0c4-af3a24dc98ab" },
                    { new Guid("5b14b6c5-7b1c-40b3-989f-a344ad9649de"), 1, 1, "281598ab-3ed7-45d0-a986-b085013fb81e" },
                    { new Guid("c1b83720-f0ec-4ec0-af03-73f750f5d0a9"), 1, 1, "a245ac46-0713-44bb-9f96-95901165694b" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "036ef810-4ddb-40b5-a735-8a389f534ec1" },
                    { "5", "281598ab-3ed7-45d0-a986-b085013fb81e" },
                    { "1", "89dfed28-2508-4a36-b0c4-af3a24dc98ab" },
                    { "3", "a245ac46-0713-44bb-9f96-95901165694b" },
                    { "4", "dcc48351-d017-4746-b2ab-a6df4ea5615f" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaim_Role_RoleId",
                table: "RoleClaim",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaim_AspNetUsers_UserId",
                table: "UserClaim",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_AspNetUsers_UserId",
                table: "UserLogin",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_AspNetUsers_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToken_AspNetUsers_UserId",
                table: "UserToken",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
