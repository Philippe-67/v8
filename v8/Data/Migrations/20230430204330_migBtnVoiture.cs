using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace v8.Data.Migrations
{
    public partial class migBtnVoiture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Intervention",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomIntervention = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrixIntervention = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intervention", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reparation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePEC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDisponibilite = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reparation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voiture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Annee = table.Column<int>(type: "int", nullable: false),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Finition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAchat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateVente = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrixAchat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrixVente = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voiture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReparationIntervention",
                columns: table => new
                {
                    ReparationId = table.Column<int>(type: "int", nullable: false),
                    InterventionId = table.Column<int>(type: "int", nullable: false),
                    ReparationInterventionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReparationIntervention", x => new { x.ReparationId, x.InterventionId });
                    table.ForeignKey(
                        name: "FK_ReparationIntervention_Intervention_InterventionId",
                        column: x => x.InterventionId,
                        principalTable: "Intervention",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReparationIntervention_Reparation_ReparationId",
                        column: x => x.ReparationId,
                        principalTable: "Reparation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReparationIntervention_InterventionId",
                table: "ReparationIntervention",
                column: "InterventionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReparationIntervention");

            migrationBuilder.DropTable(
                name: "Voiture");

            migrationBuilder.DropTable(
                name: "Intervention");

            migrationBuilder.DropTable(
                name: "Reparation");
        }
    }
}
