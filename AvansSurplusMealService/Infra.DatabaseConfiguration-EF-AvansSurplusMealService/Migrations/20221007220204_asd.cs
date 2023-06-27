using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 9, 0, 2, 4, 398, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineDate", "ReservationDate" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 2, 4, 398, DateTimeKind.Local).AddTicks(4933), null });

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 10, 0, 2, 4, 398, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 4,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 11, 0, 2, 4, 398, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 12, 0, 2, 4, 398, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "Email", "Name", "NoShows", "StudentId", "role" },
                values: new object[] { 3, new DateTime(1982, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin@example.com", "Admin", 0, "0", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
