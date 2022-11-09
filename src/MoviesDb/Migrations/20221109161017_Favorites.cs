using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesCore.Migrations
{
    public partial class Favorites : Migration
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
                name: "MovieUser",
                columns: table => new
                {
                    MoviesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieUser", x => new { x.MoviesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MovieUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieUser_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a0f748b-a5c4-427c-b0bd-11130c39b485", "a08f1c05-1a71-4218-b031-886555176dbc", "Admin", "ADMIN" },
                    { "8f8e1a59-120f-4fb9-ba45-6e8a919608b3", "7703ba7a-a387-4d1e-87b0-7c989d397f10", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "553fe4ee-64fe-4d3a-890c-0b3706f4be89", 0, "c9907a95-8857-444d-a299-ded38dfdd332", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEOocRpt+5nHUklvZMVNIiGXpigYccMvM9HjRniZiIaocWPt8Erw21OUi7Aczz/e1wg==", null, false, "7dd1cb12-4fa4-4808-87c9-0c02c2b620e2", false, "user@gmail.com" },
                    { "5f56ad75-4b7c-44f4-ae28-a2ec8c3056bf", 0, "809ada30-1bf4-40b3-90e7-b68d761b7060", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEACI6Te3PkuZeVWiWXJ8pbDauKrcUgymp+2va5cRXfMo/hzya/D/QPy9EzDm1xs5gQ==", null, false, "0b0da775-abbd-442e-900d-937f7da0f013", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8f8e1a59-120f-4fb9-ba45-6e8a919608b3", "553fe4ee-64fe-4d3a-890c-0b3706f4be89" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5a0f748b-a5c4-427c-b0bd-11130c39b485", "5f56ad75-4b7c-44f4-ae28-a2ec8c3056bf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8f8e1a59-120f-4fb9-ba45-6e8a919608b3", "5f56ad75-4b7c-44f4-ae28-a2ec8c3056bf" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_UsersId",
                table: "MovieUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieUser");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f8e1a59-120f-4fb9-ba45-6e8a919608b3", "553fe4ee-64fe-4d3a-890c-0b3706f4be89" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5a0f748b-a5c4-427c-b0bd-11130c39b485", "5f56ad75-4b7c-44f4-ae28-a2ec8c3056bf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f8e1a59-120f-4fb9-ba45-6e8a919608b3", "5f56ad75-4b7c-44f4-ae28-a2ec8c3056bf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a0f748b-a5c4-427c-b0bd-11130c39b485");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f8e1a59-120f-4fb9-ba45-6e8a919608b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "553fe4ee-64fe-4d3a-890c-0b3706f4be89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f56ad75-4b7c-44f4-ae28-a2ec8c3056bf");

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
