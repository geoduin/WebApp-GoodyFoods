using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Migrations
{
    public partial class Addchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 6, 21, 0, 10, 64, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineDate", "ReservationDate" },
                values: new object[] { new DateTime(2022, 10, 7, 21, 0, 10, 64, DateTimeKind.Local).AddTicks(6164), new DateTime(2022, 10, 6, 21, 0, 10, 64, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 7, 21, 0, 10, 64, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 4,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 8, 21, 0, 10, 64, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 9, 21, 0, 10, 64, DateTimeKind.Local).AddTicks(6178));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 6, 19, 20, 48, 361, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineDate", "ReservationDate" },
                values: new object[] { new DateTime(2022, 10, 7, 19, 20, 48, 361, DateTimeKind.Local).AddTicks(1767), new DateTime(2022, 10, 6, 19, 20, 48, 361, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 7, 19, 20, 48, 361, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 4,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 8, 19, 20, 48, 361, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 9, 19, 20, 48, 361, DateTimeKind.Local).AddTicks(1783));
        }
    }
}
