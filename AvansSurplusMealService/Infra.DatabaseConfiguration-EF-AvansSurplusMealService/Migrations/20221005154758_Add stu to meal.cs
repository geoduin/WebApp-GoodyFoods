using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Migrations
{
    public partial class Addstutomeal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MealPackets",
                columns: new[] { "Id", "CantineId", "DateToReceive", "Name", "Opgehaald", "OphalingsDatum", "Price", "ReserveDate", "StudentClaimId", "TypeMeal" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 6, 17, 47, 57, 938, DateTimeKind.Local).AddTicks(3059), "Zomerse Special", false, null, 21.879999999999999, null, null, "Gezond" },
                    { 2, 2, new DateTime(2022, 10, 7, 17, 47, 57, 938, DateTimeKind.Local).AddTicks(3066), "Vleespakket", false, null, 25.0, null, 1, "Vless" },
                    { 3, 1, new DateTime(2022, 10, 7, 17, 47, 57, 938, DateTimeKind.Local).AddTicks(3069), "Vegapakket", false, null, 12.99, null, null, "Gezond" },
                    { 4, 2, new DateTime(2022, 10, 8, 17, 47, 57, 938, DateTimeKind.Local).AddTicks(3072), "Sandwich pakket", false, null, 10.0, null, null, "Sandwiches" },
                    { 5, 1, new DateTime(2022, 10, 9, 17, 47, 57, 938, DateTimeKind.Local).AddTicks(3075), "Snackpakket", false, null, 12.5, null, null, "Snack" },
                    { 6, 2, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hartige pakket", false, null, 9.9000000000000004, null, null, "Snack" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
