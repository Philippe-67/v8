using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace v8.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reparation_Voiture_VoitureId",
                table: "Reparation");

            migrationBuilder.DropForeignKey(
                name: "FK_ReparationInterventions_Intervention_InId",
                table: "ReparationInterventions");

            migrationBuilder.RenameColumn(
                name: "InId",
                table: "ReparationInterventions",
                newName: "InterventionId");

            migrationBuilder.RenameIndex(
                name: "IX_ReparationInterventions_InId",
                table: "ReparationInterventions",
                newName: "IX_ReparationInterventions_InterventionId");

            migrationBuilder.AlterColumn<int>(
                name: "VoitureId",
                table: "Reparation",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Intervention",
                columns: new[] { "Id", "NomIntervention", "PrixIntervention" },
                values: new object[,]
                {
                    { 1, "Plaquette", 40m },
                    { 2, "Courroie distribution", 120m }
                });

            migrationBuilder.InsertData(
                table: "Voiture",
                columns: new[] { "Id", "Annee", "DateAchat", "DateVente", "Finition", "Marque", "Modele", "PrixAchat", "PrixVente" },
                values: new object[,]
                {
                    { 1, 2010, new DateTime(2023, 5, 8, 18, 0, 26, 609, DateTimeKind.Local).AddTicks(1649), null, "Sline", "Audi", "A3", 12000m, null },
                    { 2, 2015, new DateTime(2023, 5, 5, 18, 0, 26, 609, DateTimeKind.Local).AddTicks(1697), null, "M", "BMW", "Serie 3", 18000m, null }
                });

            migrationBuilder.InsertData(
                table: "Reparation",
                columns: new[] { "Id", "DateDisponibilite", "DatePEC", "Description", "VoitureId" },
                values: new object[] { 1, new DateTime(2023, 5, 8, 18, 0, 26, 609, DateTimeKind.Local).AddTicks(1796), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plaquette", 1 });

            migrationBuilder.InsertData(
                table: "ReparationInterventions",
                columns: new[] { "Id", "InterventionId", "ReparationId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Reparation_Voiture_VoitureId",
                table: "Reparation",
                column: "VoitureId",
                principalTable: "Voiture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReparationInterventions_Intervention_InterventionId",
                table: "ReparationInterventions",
                column: "InterventionId",
                principalTable: "Intervention",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reparation_Voiture_VoitureId",
                table: "Reparation");

            migrationBuilder.DropForeignKey(
                name: "FK_ReparationInterventions_Intervention_InterventionId",
                table: "ReparationInterventions");

            migrationBuilder.DeleteData(
                table: "Intervention",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReparationInterventions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Voiture",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Intervention",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reparation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Voiture",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "InterventionId",
                table: "ReparationInterventions",
                newName: "InId");

            migrationBuilder.RenameIndex(
                name: "IX_ReparationInterventions_InterventionId",
                table: "ReparationInterventions",
                newName: "IX_ReparationInterventions_InId");

            migrationBuilder.AlterColumn<int>(
                name: "VoitureId",
                table: "Reparation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reparation_Voiture_VoitureId",
                table: "Reparation",
                column: "VoitureId",
                principalTable: "Voiture",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReparationInterventions_Intervention_InId",
                table: "ReparationInterventions",
                column: "InId",
                principalTable: "Intervention",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
