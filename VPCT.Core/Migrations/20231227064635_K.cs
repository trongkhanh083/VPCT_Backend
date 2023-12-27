using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VPCT.Core.Migrations
{
    /// <inheritdoc />
    public partial class K : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e77a455c-05e0-4fa3-9840-576528f97539");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a91105e-6ec3-420e-824c-0eadf7c50ce9", "345cf02d-3757-4213-bdb9-1eb9ddab01e7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "edfbc4fe-ad76-411f-b6e3-47dcb8c7242a", "58332a1c-aba4-4c93-ad31-919d19c32bb7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a91105e-6ec3-420e-824c-0eadf7c50ce9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edfbc4fe-ad76-411f-b6e3-47dcb8c7242a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "345cf02d-3757-4213-bdb9-1eb9ddab01e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58332a1c-aba4-4c93-ad31-919d19c32bb7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b26ee79d-1dc6-424c-9690-892cbef87942", null, "ChuyenVien", "CHUYENVIEN" },
                    { "b518e84a-feca-45fe-9ec8-f158ce91d897", null, "KeToan", "KETOAN" },
                    { "f22e880d-b842-4647-b333-6beaad6c008b", null, "LanhDao", "LANHDAO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FullName", "ImageName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7623253c-c429-4ff2-88e1-a47a91f93aee", 0, null, "1e6b7850-a52f-4a9f-8a42-c572226cba05", null, "mm@mm.mm", true, "Hoang Khanh", null, false, null, "MM@MM.MM", "ADMIN13", "AQAAAAIAAYagAAAAEL3GxLrkyII0h1PNM1EjnceXMLVPmDJtbn6QGxaE8n+A78HY4VFpD6Oo0alsj+2bYw==", "01223456789", false, "f7abe5bd-4dc9-4670-baee-00ff3ae99fbb", false, "admin13" },
                    { "b3fbdb63-a5e2-4785-87bc-6d335e7fecd9", 0, null, "2209e2b5-0e5d-4a0b-9575-14e23a132ac8", null, "aa@aa.aa", true, "Luu Minh", null, false, null, "AA@AA.AA", "ADMIN12", "AQAAAAIAAYagAAAAEKWOY38u7XudnEkbS2rBY9TvRijuN/CQ6+2KYLDBN2V0f7mDbGclBz0LYXHFfvwYJQ==", "01223456789", false, "15e5325f-b80b-42d2-81bc-13beef73b539", false, "admin12" }
                });

            migrationBuilder.UpdateData(
                table: "CongVanNhiemVu",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDate",
                value: new DateTime(2023, 12, 27, 13, 46, 33, 949, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "LanDieuChinh",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 12, 27, 13, 46, 33, 949, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "LanDieuChinh",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "LanKiemTra",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTestDate",
                value: new DateTime(2023, 12, 27, 13, 46, 33, 949, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "LanKiemTra",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTestDate",
                value: new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b26ee79d-1dc6-424c-9690-892cbef87942", "7623253c-c429-4ff2-88e1-a47a91f93aee" },
                    { "f22e880d-b842-4647-b333-6beaad6c008b", "b3fbdb63-a5e2-4785-87bc-6d335e7fecd9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b518e84a-feca-45fe-9ec8-f158ce91d897");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b26ee79d-1dc6-424c-9690-892cbef87942", "7623253c-c429-4ff2-88e1-a47a91f93aee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f22e880d-b842-4647-b333-6beaad6c008b", "b3fbdb63-a5e2-4785-87bc-6d335e7fecd9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b26ee79d-1dc6-424c-9690-892cbef87942");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f22e880d-b842-4647-b333-6beaad6c008b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7623253c-c429-4ff2-88e1-a47a91f93aee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3fbdb63-a5e2-4785-87bc-6d335e7fecd9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a91105e-6ec3-420e-824c-0eadf7c50ce9", null, "LanhDao", "LANHDAO" },
                    { "e77a455c-05e0-4fa3-9840-576528f97539", null, "KeToan", "KETOAN" },
                    { "edfbc4fe-ad76-411f-b6e3-47dcb8c7242a", null, "ChuyenVien", "CHUYENVIEN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FullName", "ImageName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "345cf02d-3757-4213-bdb9-1eb9ddab01e7", 0, null, "3906ff0d-6d64-4463-ba44-906929ea23f2", null, "aa@aa.aa", true, "Luu Minh", null, false, null, "AA@AA.AA", "ADMIN12", "AQAAAAIAAYagAAAAEMDI7xFncavvlc13mIaYIAlr8uFYJcz04EQHlQTnDwVO6YONaLZUGxVwWTEyeWrIoQ==", "01223456789", false, "0016e6cb-29b7-4247-b686-83e8210827b6", false, "admin12" },
                    { "58332a1c-aba4-4c93-ad31-919d19c32bb7", 0, null, "9ed13a89-d24a-4527-ae71-6a22c608e714", null, "mm@mm.mm", true, "Hoang Khanh", null, false, null, "MM@MM.MM", "ADMIN13", "AQAAAAIAAYagAAAAEKG1/EkIzfa/j4vRlVimxiI4cBC6I0aEYOmooH7wxn3VSr2DpZ4Rr114ZqfzotdRdQ==", "01223456789", false, "f92e4e5e-fbdc-44af-ad57-25e38a8930dd", false, "admin13" }
                });

            migrationBuilder.UpdateData(
                table: "CongVanNhiemVu",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDate",
                value: new DateTime(2023, 12, 26, 9, 39, 20, 916, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "LanDieuChinh",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 12, 26, 9, 39, 20, 916, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "LanDieuChinh",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "LanKiemTra",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTestDate",
                value: new DateTime(2023, 12, 26, 9, 39, 20, 916, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "LanKiemTra",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTestDate",
                value: new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0a91105e-6ec3-420e-824c-0eadf7c50ce9", "345cf02d-3757-4213-bdb9-1eb9ddab01e7" },
                    { "edfbc4fe-ad76-411f-b6e3-47dcb8c7242a", "58332a1c-aba4-4c93-ad31-919d19c32bb7" }
                });
        }
    }
}
