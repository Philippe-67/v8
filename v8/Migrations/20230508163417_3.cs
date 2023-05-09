using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace v8.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Intervention",
                columns: new[] { "Id", "NomIntervention", "PrixIntervention" },
                values: new object[,]
                {
                    { 3, "Turbo", 250m },
                    { 4, "Embrayage", 220m }
                });

            migrationBuilder.UpdateData(
                table: "Reparation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDisponibilite", "Description" },
                values: new object[] { new DateTime(2023, 5, 8, 18, 34, 17, 500, DateTimeKind.Local).AddTicks(6), "Courroie distribution + embrayage" });

            migrationBuilder.InsertData(
                table: "Reparation",
                columns: new[] { "Id", "DateDisponibilite", "DatePEC", "Description", "VoitureId" },
                values: new object[] { 2, new DateTime(2023, 5, 10, 18, 34, 17, 500, DateTimeKind.Local).AddTicks(12), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Remplacement turbo + Plaquette", 1 });

            migrationBuilder.InsertData(
                table: "ReparationInterventions",
                columns: new[] { "Id", "InterventionId", "ReparationId" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Voiture",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAchat",
                value: new DateTime(2023, 5, 8, 18, 34, 17, 499, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Voiture",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAchat",
                value: new DateTime(2023, 5, 5, 18, 34, 17, 499, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "ReparationInterventions",
                keyColumn: "Id",
                keyValue: 1,
                column: "InterventionId",
                value: 4);

            migrationBuilder.InsertData(
                table: "ReparationInterventions",
                columns: new[] { "Id", "InterventionId", "ReparationId" },
                values: new object[] { 3, 1, 2 });

            migrationBuilder.InsertData(
                table: "ReparationInterventions",
                columns: new[] { "Id", "InterventionId", "ReparationId" },
                values: new object[] { 4, 3, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Intervention",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReparationInterventions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReparationInterventions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReparationInterventions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Intervention",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reparation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Reparation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDisponibilite", "Description" },
                values: new object[] { new DateTime(2023, 5, 8, 18, 26, 6, 51, DateTimeKind.Local).AddTicks(2142), "Plaquette" });

            migrationBuilder.UpdateData(
                table: "ReparationInterventions",
                keyColumn: "Id",
                keyValue: 1,
                column: "InterventionId",
                value: 1);

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
    }
}
