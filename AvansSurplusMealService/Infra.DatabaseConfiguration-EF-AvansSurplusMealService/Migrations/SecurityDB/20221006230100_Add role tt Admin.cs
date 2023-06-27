using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Migrations.SecurityDB
{
    public partial class AddrolettAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "CharacterRole", "Admin", "b74ddd14-6340-4840-95c2-db12554843e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00182742-36d8-4988-bd1b-6ad2b3c87ff3", "AQAAAAEAACcQAAAAEEj/TSwhDpZAZqGX3G+t3n2Rs+qqTbIYlL/17bt/MIQvqi2frGodfR6CQ+Bmvux9lA==", "2a29bf2b-ea1e-418f-bbb9-dc0a7b2917c9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "781ac8df-2cfa-4f66-99cf-2023d7258c0e", "AQAAAAEAACcQAAAAEClLBM5VDEfqUpB/pMxCMhmZuFCzXGH+xdge3HqzdRAWWV+579JExojV4uQBolivcw==", "b3cea4c4-b641-47a1-b103-9ed4649424e7" });
        }
    }
}
