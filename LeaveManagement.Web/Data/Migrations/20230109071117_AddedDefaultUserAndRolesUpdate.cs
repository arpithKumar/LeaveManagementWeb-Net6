using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserAndRolesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a17ab9f9-59ab-4a6a-aa79-b6151f2e764a",
                column: "ConcurrencyStamp",
                value: "aa4ff5ab-9f11-4d88-bb43-f551ffc2c9eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a17cb9f9-59cb-4a6c-aa79-b6151f2e764c",
                column: "ConcurrencyStamp",
                value: "9ea015ff-f617-4013-a53c-2acb6b2e8be3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a17db9f9-59db-4a6d-aa79-b6151f2e764d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8e89d736-66f9-425e-8ca5-35e3db2bc07d", true, "ARPITHK3@GMAIL.COM", "AQAAAAEAACcQAAAAECcTTjDzqtuuBBL5ROH9f0CH5w6vxlNPe36H3ff+/GEWFG5nSfwjTjXU2xgpC5TLEw==", "3979d160-94d6-4a7d-9356-46f52aeaea90", "arpithk3@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a17ab9f9-59ab-4a6a-aa79-b6151f2e764a",
                column: "ConcurrencyStamp",
                value: "a28d0059-196c-473c-8d1f-07b8e2bfcac9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a17cb9f9-59cb-4a6c-aa79-b6151f2e764c",
                column: "ConcurrencyStamp",
                value: "c5ca2344-985f-47cc-8996-d93857791483");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a17db9f9-59db-4a6d-aa79-b6151f2e764d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ed3cdfee-bb46-4b6e-8eee-39e3a3ac5430", false, null, "AQAAAAEAACcQAAAAEGGNCuMJS5AQYRur6m6AnxszndTIvLbArGPP1O0IWC1rLZY5J+DaZNijsNs2vk5WuQ==", "62c29b5f-4983-45de-905b-b0ff591a2eb9", null });
        }
    }
}
