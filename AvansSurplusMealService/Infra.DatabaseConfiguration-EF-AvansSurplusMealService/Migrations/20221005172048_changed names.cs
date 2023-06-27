using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Migrations
{
    public partial class changednames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReserveDate",
                table: "MealPackets",
                newName: "ReservationDate");

            migrationBuilder.RenameColumn(
                name: "DateToReceive",
                table: "MealPackets",
                newName: "DeadlineDate");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReservationDate",
                table: "MealPackets",
                newName: "ReserveDate");

            migrationBuilder.RenameColumn(
                name: "DeadlineDate",
                table: "MealPackets",
                newName: "DateToReceive");

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
    }
}
