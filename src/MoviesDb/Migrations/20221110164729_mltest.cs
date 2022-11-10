using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesCore.Migrations
{
    public partial class mltest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6d598dc8-951c-408f-a84f-e58f47ab2056", "3202f8cc-130e-4193-9a0d-943a0ff7656a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a784d59d-35ba-488c-b4ee-eba0fd6e0581", "3202f8cc-130e-4193-9a0d-943a0ff7656a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6d598dc8-951c-408f-a84f-e58f47ab2056", "edbc0e74-45e0-40fa-a272-d8be2c5a2498" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d598dc8-951c-408f-a84f-e58f47ab2056");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a784d59d-35ba-488c-b4ee-eba0fd6e0581");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3202f8cc-130e-4193-9a0d-943a0ff7656a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edbc0e74-45e0-40fa-a272-d8be2c5a2498");

            migrationBuilder.CreateTable(
                name: "Reccomendations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reccomendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reccomendations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reccomendations_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c7f7959-c839-47aa-9e5a-b34f90064ad4", "ca33964d-51f0-4ee2-a9f5-f9545e8d34d9", "Admin", "ADMIN" },
                    { "7adb7e3b-2a07-4d2d-bf80-961aa44977cb", "0b41a42d-9761-41a4-acf4-7f53a43ee469", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5baede0a-37a4-450b-86d9-c27e9e24b9d4", 0, "e7548706-d1f7-48e9-a2a3-abd853ba9538", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEPzrpdLBBQeOtMCvMIWHejDN2kT0ay310Qm42ItAW2F92r4HpG3ruYD+55hnFGzvfQ==", null, false, "60c6fba7-103f-4d66-94bd-3bff25703e92", false, "user@gmail.com" },
                    { "7dfd7009-8d1f-4570-8edc-ed6aa81c644c", 0, "6da92167-678a-4c76-9b2b-5e8dbbc9222d", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDHYFepor9v0THUh/s4GodHqyyEaE25X3dp0qJZa5XWeA5EfrkUIgto9w7hpC9MwQQ==", null, false, "f72ab387-9a04-499e-8626-1a72e2291bd6", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7adb7e3b-2a07-4d2d-bf80-961aa44977cb", "5baede0a-37a4-450b-86d9-c27e9e24b9d4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0c7f7959-c839-47aa-9e5a-b34f90064ad4", "7dfd7009-8d1f-4570-8edc-ed6aa81c644c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7adb7e3b-2a07-4d2d-bf80-961aa44977cb", "7dfd7009-8d1f-4570-8edc-ed6aa81c644c" });

            migrationBuilder.CreateIndex(
                name: "IX_Reccomendations_MovieId",
                table: "Reccomendations",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Reccomendations_UserId",
                table: "Reccomendations",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reccomendations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7adb7e3b-2a07-4d2d-bf80-961aa44977cb", "5baede0a-37a4-450b-86d9-c27e9e24b9d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c7f7959-c839-47aa-9e5a-b34f90064ad4", "7dfd7009-8d1f-4570-8edc-ed6aa81c644c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7adb7e3b-2a07-4d2d-bf80-961aa44977cb", "7dfd7009-8d1f-4570-8edc-ed6aa81c644c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c7f7959-c839-47aa-9e5a-b34f90064ad4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7adb7e3b-2a07-4d2d-bf80-961aa44977cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5baede0a-37a4-450b-86d9-c27e9e24b9d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dfd7009-8d1f-4570-8edc-ed6aa81c644c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d598dc8-951c-408f-a84f-e58f47ab2056", "5666eb51-3524-4fa9-8115-9409700fad6d", "User", "USER" },
                    { "a784d59d-35ba-488c-b4ee-eba0fd6e0581", "a84fd06b-296b-4166-8660-7ad7cf302fca", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3202f8cc-130e-4193-9a0d-943a0ff7656a", 0, "cb4eab94-d89f-4900-896b-a8ee427d2846", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEARnXSmWDvPj/5s1x8cj5VuxcjdJcy73Bhs72TNf5EG0XmuEQbZsqfQcvOaECjHFsw==", null, false, "68a636e3-7501-4979-8c23-cb9b0c14d9aa", false, "admin@gmail.com" },
                    { "edbc0e74-45e0-40fa-a272-d8be2c5a2498", 0, "db32535a-d0fc-43df-8179-77ca248be158", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEBzYONKNZIDabcffuJ+RUEPBLc78QjRPGicQYbGSF+lq29dIIFjlrOrJ5dWPCn/zfg==", null, false, "c5acf975-6a35-4e64-acfc-4a408e6a5933", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6d598dc8-951c-408f-a84f-e58f47ab2056", "3202f8cc-130e-4193-9a0d-943a0ff7656a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a784d59d-35ba-488c-b4ee-eba0fd6e0581", "3202f8cc-130e-4193-9a0d-943a0ff7656a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6d598dc8-951c-408f-a84f-e58f47ab2056", "edbc0e74-45e0-40fa-a272-d8be2c5a2498" });
        }
    }
}
