using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD.Migrations
{
    public partial class AddPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions");

            migrationBuilder.AlterColumn<int>(
                name: "IdDoctor",
                table: "Prescriptions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPatient",
                table: "Prescriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions",
                column: "IdPatient");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions",
                column: "IdDoctor",
                principalTable: "Doctors",
                principalColumn: "IdDoctor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patients_PatientId",
                table: "Prescriptions",
                column: "IdPatient",
                principalTable: "Patients",
                principalColumn: "IdDoctor",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patients_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "IdPatient",
                table: "Prescriptions");

            migrationBuilder.AlterColumn<int>(
                name: "IdDoctor",
                table: "Prescriptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdDoctor",
                table: "Prescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPatient",
                table: "Prescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions",
                column: "IdDoctor",
                principalTable: "Doctors",
                principalColumn: "IdDoctor",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
