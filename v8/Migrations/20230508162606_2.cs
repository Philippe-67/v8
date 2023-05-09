using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace v8.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reparation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDisponibilite", "VoitureId" },
                values: new object[] { new DateTime(2023, 5, 8, 18, 26, 6, 51, DateTimeKind.Local).AddTicks(2142), 2 });

            migrationBuilder.UpdateData(
                table: "Voiture",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAchat",
                value: new DateTime(2023, 5, 8, 18, 26, 6, 51, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Voiture",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAchat",
                value: new DateTime(2023, 5, 5, 18, 26, 6, 51, DateTimeKind.Local).AddTicks(2034));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reparation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDisponibilite", "VoitureId" },
                values: new object[] { new DateTime(2023, 5, 8, 18, 0, 26, 609, DateTimeKind.Local).AddTicks(1796), 1 });

            migrationBuilder.UpdateData(
                table: "Voiture",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAchat",
                value: new DateTime(2023, 5, 8, 18, 0, 26, 609, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Voiture",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAchat",
                value: new DateTime(2023, 5, 5, 18, 0, 26, 609, DateTimeKind.Local).AddTicks(1697));
        }
    }
}
