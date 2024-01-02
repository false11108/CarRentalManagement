using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ee3d4ea-b945-4a86-ae24-fd7214807f04", null, "User2", "USER2" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0d76c4ee-aad6-460f-844b-cc1aabccbec0", 0, "a2d54b03-85ce-4a1b-aadf-dcecfc1416b5", "admin2@localhost.com", false, "Admin2", "User2", false, null, "ADMIN2@LOCALHOST.COM", "ADMIN2@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAIGCXx+/Zoph5tlufbHlRu5Y6HnhYBb1U8QdZPBkIsUTg6rJyaEWxOps01nLzsQCw==", null, false, "579adcdd-f1b7-4b97-a751-91702c804bbe", false, "admin2@localhost.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "36329eac-acd1-4883-8aa9-0b58e2a3b5f0", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEINRLX16M1aIB3YRnAE2t94KHQk/PAg+5a8CqGNr501ThxkUdgyALXZc+YbpWOkzeA==", null, false, "f3b8e221-7473-4cc0-8ccd-5795e612455c", false, "admin@localhost.com" },
                    { "ee642944-ea4e-4195-971d-c843ffc4d6a6", 0, "a1d78a2d-deac-46f9-a6ba-29da5d1bff91", "admin1@localhost.com", false, "Admin1", "User1", false, null, "ADMIN1@LOCALHOST.COM", "ADMIN1@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFJrjMMgCrhvrrNWgKHEI+bvIbqEUkja7SHPKIwgVyDXUtuS/B/2deAeYP+Y/QM7Rw==", null, false, "7f9b69f4-b088-49d8-8e29-1be87783c501", false, "admin1@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(4351), new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(4371), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(4375), new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(4376), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(5112), new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(5114), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(5118), new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(5118), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(5546), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(5548), new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(5549), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(5551), new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(5551), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(5553), new DateTime(2023, 11, 24, 11, 42, 18, 548, DateTimeKind.Local).AddTicks(5554), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5ee3d4ea-b945-4a86-ae24-fd7214807f04", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "ee642944-ea4e-4195-971d-c843ffc4d6a6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ee3d4ea-b945-4a86-ae24-fd7214807f04", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "ee642944-ea4e-4195-971d-c843ffc4d6a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d76c4ee-aad6-460f-844b-cc1aabccbec0");

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ee3d4ea-b945-4a86-ae24-fd7214807f04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee642944-ea4e-4195-971d-c843ffc4d6a6");
        }
    }
}
