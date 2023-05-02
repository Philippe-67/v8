using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace v8.Data.Migrations
{
    public partial class migjointure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReparationInterventionId",
                table: "ReparationIntervention",
                newName: "VoitureId");

            migrationBuilder.AddColumn<int>(
                name: "VoitureId",
                table: "Voiture",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ReparationIntervention",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VoitureId",
                table: "Reparation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoitureId",
                table: "Intervention",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReparationIntervention_VoitureId",
                table: "ReparationIntervention",
                column: "VoitureId");

            migrationBuilder.CreateIndex(
                name: "IX_Reparation_VoitureId",
                table: "Reparation",
                column: "VoitureId");

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_VoitureId",
                table: "Intervention",
                column: "VoitureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Intervention_Voiture_VoitureId",
                table: "Intervention",
                column: "VoitureId",
                principalTable: "Voiture",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reparation_Voiture_VoitureId",
                table: "Reparation",
                column: "VoitureId",
                principalTable: "Voiture",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReparationIntervention_Voiture_VoitureId",
                table: "ReparationIntervention",
                column: "VoitureId",
                principalTable: "Voiture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Voiture_VoitureId",
                table: "Intervention");

            migrationBuilder.DropForeignKey(
                name: "FK_Reparation_Voiture_VoitureId",
                table: "Reparation");

            migrationBuilder.DropForeignKey(
                name: "FK_ReparationIntervention_Voiture_VoitureId",
                table: "ReparationIntervention");

            migrationBuilder.DropIndex(
                name: "IX_ReparationIntervention_VoitureId",
                table: "ReparationIntervention");

            migrationBuilder.DropIndex(
                name: "IX_Reparation_VoitureId",
                table: "Reparation");

            migrationBuilder.DropIndex(
                name: "IX_Intervention_VoitureId",
                table: "Intervention");

            migrationBuilder.DropColumn(
                name: "VoitureId",
                table: "Voiture");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ReparationIntervention");

            migrationBuilder.DropColumn(
                name: "VoitureId",
                table: "Reparation");

            migrationBuilder.DropColumn(
                name: "VoitureId",
                table: "Intervention");

            migrationBuilder.RenameColumn(
                name: "VoitureId",
                table: "ReparationIntervention",
                newName: "ReparationInterventionId");
        }
    }
}
