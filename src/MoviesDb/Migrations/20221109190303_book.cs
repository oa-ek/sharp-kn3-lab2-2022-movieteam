using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesCore.Migrations
{
    public partial class book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "446a5531-d3c4-4607-94f9-ae4271529f70", "21b54ce2-ab7c-4458-b43e-1b4dd4acff53" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9c42a9c-d52b-4c0c-9656-a661211b6ff2", "21b54ce2-ab7c-4458-b43e-1b4dd4acff53" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "446a5531-d3c4-4607-94f9-ae4271529f70", "6b155db3-30f2-491a-a133-95e10729df23" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "446a5531-d3c4-4607-94f9-ae4271529f70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9c42a9c-d52b-4c0c-9656-a661211b6ff2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21b54ce2-ab7c-4458-b43e-1b4dd4acff53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b155db3-30f2-491a-a133-95e10729df23");

            migrationBuilder.CreateTable(
                name: "Bookmarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookmarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookmarks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookmarks_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Bookmarks_MovieId",
                table: "Bookmarks",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookmarks_UserId",
                table: "Bookmarks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookmarks");

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
                    { "446a5531-d3c4-4607-94f9-ae4271529f70", "b4e62473-f1ce-418b-ada0-7ed73ffd78c3", "User", "USER" },
                    { "e9c42a9c-d52b-4c0c-9656-a661211b6ff2", "41266aff-3432-4a3f-9a2c-727992ffe640", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "21b54ce2-ab7c-4458-b43e-1b4dd4acff53", 0, "7d3338bc-e670-4952-b687-7863c79f9568", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENsqA5gSzTLDxClkK07q7kA5eloyJZJFBAzhn8OGHpTjSfol7QUGh2JQai5LL7Ydlg==", null, false, "3be2f2d9-9976-4f3a-ac96-432027042a34", false, "admin@gmail.com" },
                    { "6b155db3-30f2-491a-a133-95e10729df23", 0, "939c7152-a3ac-4d44-9b0d-3302c92fd617", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEL6/Gm5qcbJkLl6W2xy8d6Nuh2/Zz/BvpqCOyl6hUF4nGewPs2Hdw8D98S4V4IO+gw==", null, false, "70ee17bb-3953-4001-aaa5-9d48ab3d3a0c", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "446a5531-d3c4-4607-94f9-ae4271529f70", "21b54ce2-ab7c-4458-b43e-1b4dd4acff53" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e9c42a9c-d52b-4c0c-9656-a661211b6ff2", "21b54ce2-ab7c-4458-b43e-1b4dd4acff53" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "446a5531-d3c4-4607-94f9-ae4271529f70", "6b155db3-30f2-491a-a133-95e10729df23" });
        }
    }
}
