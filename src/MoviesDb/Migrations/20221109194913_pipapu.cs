using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesCore.Migrations
{
    public partial class pipapu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6811a75d-6717-4ae0-a40e-9eb41cd303b7", "34c58b59-64dc-4671-938a-dd42a69cae04" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6811a75d-6717-4ae0-a40e-9eb41cd303b7", "6ff0a98d-3e84-462c-bbc0-d5b40e4d4f11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "821a939f-f679-44b7-b092-7201104e8e80", "6ff0a98d-3e84-462c-bbc0-d5b40e4d4f11" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6811a75d-6717-4ae0-a40e-9eb41cd303b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "821a939f-f679-44b7-b092-7201104e8e80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34c58b59-64dc-4671-938a-dd42a69cae04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ff0a98d-3e84-462c-bbc0-d5b40e4d4f11");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cc493cc1-5f47-48fe-acc3-3b0cad9ed579", "b32abe70-0f9f-463c-875a-cdbeddefbc5a", "User", "USER" },
                    { "f3817d61-f7a3-4e4b-aee4-b3cf2c010188", "52a239e9-0a44-458c-b36b-ec12f4f70116", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ba95939b-8511-49b1-bd46-fd1c274478e9", 0, "f75f8b98-52be-450a-aad5-8461170c62cb", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPRu7V0HuYRMLIEQjPemJgK0gVRiOIQi37LLvo/ZVO/utRd4za8IKELGI8wSSL9Fcw==", null, false, "7f54f09b-7301-4dd2-b1b0-8e54a5b06b8e", false, "admin@gmail.com" },
                    { "babe79a9-c3c8-45c1-9d25-4ba818e31c3a", 0, "4e04c01a-b6d1-449d-b0c3-b15098de5235", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEPPk/G56FwKfrFM+3WEaM7x4f2jlQSutbHPvFClGXsK7PqtCkRKZ4jpJhLimDRtslQ==", null, false, "1e1c87e1-5641-43c8-a7c4-3f84091dfdf5", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc493cc1-5f47-48fe-acc3-3b0cad9ed579", "ba95939b-8511-49b1-bd46-fd1c274478e9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f3817d61-f7a3-4e4b-aee4-b3cf2c010188", "ba95939b-8511-49b1-bd46-fd1c274478e9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc493cc1-5f47-48fe-acc3-3b0cad9ed579", "babe79a9-c3c8-45c1-9d25-4ba818e31c3a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc493cc1-5f47-48fe-acc3-3b0cad9ed579", "ba95939b-8511-49b1-bd46-fd1c274478e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f3817d61-f7a3-4e4b-aee4-b3cf2c010188", "ba95939b-8511-49b1-bd46-fd1c274478e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc493cc1-5f47-48fe-acc3-3b0cad9ed579", "babe79a9-c3c8-45c1-9d25-4ba818e31c3a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc493cc1-5f47-48fe-acc3-3b0cad9ed579");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3817d61-f7a3-4e4b-aee4-b3cf2c010188");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba95939b-8511-49b1-bd46-fd1c274478e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "babe79a9-c3c8-45c1-9d25-4ba818e31c3a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6811a75d-6717-4ae0-a40e-9eb41cd303b7", "ea4f7bfd-c21f-4cb8-a75f-6bc5a391231b", "User", "USER" },
                    { "821a939f-f679-44b7-b092-7201104e8e80", "e4916ce0-2f43-4144-aaff-d69d4bcfad92", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "34c58b59-64dc-4671-938a-dd42a69cae04", 0, "2aa22281-56a2-4299-867a-f429d7af1414", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEHBCJI+a2eXyJmr/Y/U3J06b3dnAJfEJdihpL94fBkFoxMM/Ym8Ud3tAz7F+X+sGsA==", null, false, "5d13b879-6cc7-4502-90fd-9718ea2b81bd", false, "user@gmail.com" },
                    { "6ff0a98d-3e84-462c-bbc0-d5b40e4d4f11", 0, "c98f02a3-9893-4e8f-a8ba-d6beccd1491f", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEOZzVeDeyDNphy9kNl5ukmLhIrlg6PKYVX91dqdEWKa8uRE0ux1JkWmWgOvuciRO0g==", null, false, "e98238e4-0d3c-435f-a75d-f3e209ab36c1", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6811a75d-6717-4ae0-a40e-9eb41cd303b7", "34c58b59-64dc-4671-938a-dd42a69cae04" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6811a75d-6717-4ae0-a40e-9eb41cd303b7", "6ff0a98d-3e84-462c-bbc0-d5b40e4d4f11" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "821a939f-f679-44b7-b092-7201104e8e80", "6ff0a98d-3e84-462c-bbc0-d5b40e4d4f11" });
        }
    }
}
