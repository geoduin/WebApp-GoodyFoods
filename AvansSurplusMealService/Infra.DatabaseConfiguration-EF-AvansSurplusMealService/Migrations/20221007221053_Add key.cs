using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Migrations
{
    public partial class Addkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Cantines_cantineId",
                table: "Personels");

            migrationBuilder.RenameColumn(
                name: "cantineId",
                table: "Personels",
                newName: "CantineId");

            migrationBuilder.RenameIndex(
                name: "IX_Personels_cantineId",
                table: "Personels",
                newName: "IX_Personels_CantineId");

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 9, 0, 10, 53, 287, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 10, 0, 10, 53, 287, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 10, 0, 10, 53, 287, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 4,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 11, 0, 10, 53, 287, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "MealPackets",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 12, 0, 10, 53, 287, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Cantines_CantineId",
                table: "Personels",
                column: "CantineId",
                principalTable: "Cantines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Cantines_CantineId",
                table: "Personels");

            migrationBuilder.RenameColumn(
                name: "CantineId",
                table: "Personels",
                newName: "cantineId");

            migrationBuilder.RenameIndex(
                name: "IX_Personels_CantineId",
                table: "Personels",
                newName: "IX_Personels_cantineId");

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
                column: "DeadlineDate",
                value: new DateTime(2022, 10, 10, 0, 2, 4, 398, DateTimeKind.Local).AddTicks(4933));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Cantines_cantineId",
                table: "Personels",
                column: "cantineId",
                principalTable: "Cantines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
