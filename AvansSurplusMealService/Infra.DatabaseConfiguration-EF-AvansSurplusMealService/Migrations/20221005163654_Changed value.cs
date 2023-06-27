using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Migrations
{
    public partial class Changedvalue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateToReceive",
                value: new DateTime(2022, 10, 6, 18, 36, 54, 310, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateToReceive", "ReserveDate" },
                values: new object[] { new DateTime(2022, 10, 7, 18, 36, 54, 310, DateTimeKind.Local).AddTicks(7217), new DateTime(2022, 10, 6, 18, 36, 54, 310, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateToReceive",
                value: new DateTime(2022, 10, 7, 18, 36, 54, 310, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateToReceive",
                value: new DateTime(2022, 10, 8, 18, 36, 54, 310, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateToReceive",
                value: new DateTime(2022, 10, 9, 18, 36, 54, 310, DateTimeKind.Local).AddTicks(7231));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateToReceive",
                value: new DateTime(2022, 10, 6, 17, 47, 57, 938, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateToReceive", "ReserveDate" },
                values: new object[] { new DateTime(2022, 10, 7, 17, 47, 57, 938, DateTimeKind.Local).AddTicks(3066), null });

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateToReceive",
                value: new DateTime(2022, 10, 7, 17, 47, 57, 938, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateToReceive",
                value: new DateTime(2022, 10, 8, 17, 47, 57, 938, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateToReceive",
                value: new DateTime(2022, 10, 9, 17, 47, 57, 938, DateTimeKind.Local).AddTicks(3075));
        }
    }
}
