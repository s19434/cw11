using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD.Migrations
{
    public partial class AddMedicament : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicaments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prescription_Medicament",
                columns: table => new
                {
                    PrescriptionId = table.Column<int>(nullable: false),
                    MedicamentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionMedicament", x => new { x.MedicamentId, x.PrescriptionId });
                    table.ForeignKey(
                        name: "FK_PrescriptionMedicament_Medicaments_MedicamentId",
                        column: x => x.MedicamentId,
                        principalTable: "Medicaments",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionMedicament_Prescriptions_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescriptions",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionMedicament_PrescriptionId",
                table: "Prescription_Medicament",
                column: "IdPrescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescription_Medicament");

            migrationBuilder.DropTable(
                name: "Medicaments");
        }
    }
}
