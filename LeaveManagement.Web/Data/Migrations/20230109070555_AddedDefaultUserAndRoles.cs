using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a17ab9f9-59ab-4a6a-aa79-b6151f2e764a", "a28d0059-196c-473c-8d1f-07b8e2bfcac9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a17cb9f9-59cb-4a6c-aa79-b6151f2e764c", "c5ca2344-985f-47cc-8996-d93857791483", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoining", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "TxId", "UserName" },
                values: new object[] { "a17db9f9-59db-4a6d-aa79-b6151f2e764d", 0, "ed3cdfee-bb46-4b6e-8eee-39e3a3ac5430", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arpithk3@gmail.com", false, "Arpith", "Dubey", false, null, "ARPITHK3@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGGNCuMJS5AQYRur6m6AnxszndTIvLbArGPP1O0IWC1rLZY5J+DaZNijsNs2vk5WuQ==", null, false, "62c29b5f-4983-45de-905b-b0ff591a2eb9", false, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a17cb9f9-59cb-4a6c-aa79-b6151f2e764c", "a17db9f9-59db-4a6d-aa79-b6151f2e764d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a17ab9f9-59ab-4a6a-aa79-b6151f2e764a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a17cb9f9-59cb-4a6c-aa79-b6151f2e764c", "a17db9f9-59db-4a6d-aa79-b6151f2e764d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a17cb9f9-59cb-4a6c-aa79-b6151f2e764c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a17db9f9-59db-4a6d-aa79-b6151f2e764d");
        }
    }
}
