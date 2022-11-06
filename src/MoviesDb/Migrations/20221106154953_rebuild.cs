using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesCore.Migrations
{
    public partial class rebuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4cc48fb1-0b61-49a4-b06e-d370bc73fd68", "5f80a340-82f2-4cd7-8f66-cb8cb85c0da0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd098bd2-5437-49b7-93b4-445b828129c4", "5f80a340-82f2-4cd7-8f66-cb8cb85c0da0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4cc48fb1-0b61-49a4-b06e-d370bc73fd68", "67043fa0-890d-411d-9a8c-cfcc603720cf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cc48fb1-0b61-49a4-b06e-d370bc73fd68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd098bd2-5437-49b7-93b4-445b828129c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f80a340-82f2-4cd7-8f66-cb8cb85c0da0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67043fa0-890d-411d-9a8c-cfcc603720cf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "63efad41-cd0e-4325-ba57-81143557b87a", "73b3a2c3-f0fb-42a0-988b-2ac165d50c0d", "User", "USER" },
                    { "cebf5788-8d36-430f-bf8c-9d3c98db65a1", "18be2193-dcce-4b2a-a0bb-888aa3a1a545", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2cd2e39a-3f69-4ea6-8143-ecd3e7a54765", 0, "265b6330-3d1d-4c49-b5e0-a6eec3130df8", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEHDvefw5USWUpWZMeGD9lWZNXY6m9fe2imL560A/IFnxu7l7txkAVQbl9jdDcIgYFA==", null, false, "601f1586-510a-4f39-a0e1-179dc9f23d45", false, "user@gmail.com" },
                    { "8504f73a-553e-4bec-b366-bfa4e2966646", 0, "fa8f5b05-d072-4bc3-be36-6158514cfac5", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEM4x2A25sNYyceBJqgs1sLW2cnWn3y95L3Qxz943C9CcIulze8l+RmgPrPZE0ZZvDw==", null, false, "85f4bddb-18d5-47cd-a8f5-f459a258ca2c", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "63efad41-cd0e-4325-ba57-81143557b87a", "2cd2e39a-3f69-4ea6-8143-ecd3e7a54765" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "63efad41-cd0e-4325-ba57-81143557b87a", "8504f73a-553e-4bec-b366-bfa4e2966646" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cebf5788-8d36-430f-bf8c-9d3c98db65a1", "8504f73a-553e-4bec-b366-bfa4e2966646" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63efad41-cd0e-4325-ba57-81143557b87a", "2cd2e39a-3f69-4ea6-8143-ecd3e7a54765" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63efad41-cd0e-4325-ba57-81143557b87a", "8504f73a-553e-4bec-b366-bfa4e2966646" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cebf5788-8d36-430f-bf8c-9d3c98db65a1", "8504f73a-553e-4bec-b366-bfa4e2966646" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63efad41-cd0e-4325-ba57-81143557b87a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cebf5788-8d36-430f-bf8c-9d3c98db65a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd2e39a-3f69-4ea6-8143-ecd3e7a54765");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8504f73a-553e-4bec-b366-bfa4e2966646");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4cc48fb1-0b61-49a4-b06e-d370bc73fd68", "b5d1af77-e13d-4f3a-adfc-7ce676dac03f", "User", "USER" },
                    { "dd098bd2-5437-49b7-93b4-445b828129c4", "327a96ad-7e97-473d-ad93-4cde79144dba", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5f80a340-82f2-4cd7-8f66-cb8cb85c0da0", 0, "325f1f48-3bfc-4ecf-881c-199266a17eff", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAELB5uP9+BG/JI+sQQA6yrMuaiFgTFsetajOGaFoQqj/vuZsTkZxOkMh67LVFMBWV6A==", null, false, "1cd74e15-2cd0-4e08-8238-24708c7ff5dc", false, "admin@gmail.com" },
                    { "67043fa0-890d-411d-9a8c-cfcc603720cf", 0, "677e5f8e-53fc-4d64-baaf-448866a2953a", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEAhDbyS1MlExDiHKn4tF7HqNKy9nGacn84ad8mU7QHEZ7EPFYeCIb58/0jxysPqYEg==", null, false, "01e85a3d-e6b1-4003-9d03-bc15fb630791", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4cc48fb1-0b61-49a4-b06e-d370bc73fd68", "5f80a340-82f2-4cd7-8f66-cb8cb85c0da0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dd098bd2-5437-49b7-93b4-445b828129c4", "5f80a340-82f2-4cd7-8f66-cb8cb85c0da0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4cc48fb1-0b61-49a4-b06e-d370bc73fd68", "67043fa0-890d-411d-9a8c-cfcc603720cf" });
        }
    }
}
