using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD.Migrations
{
    public partial class AddSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Treners",
                columns: new[] { "IdTrener", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "j@k.pl", "Jan", "Kowalski" },
                    { 2, "j@n.com", "Jakub", "Nowak" },
                    { 3, "ml@ml.pl", "Marcin", "Log" }
                });

            migrationBuilder.InsertData(
                table: "Uwagi",
                columns: new[] { "IdTrener", "Description", "Opis", "Type" },
                values: new object[,]
                {
                    { 1, "na bol", "apap", "lek" },
                    { 2, "na bol glowy", "ibuprom", "lek" },
                    { 3, "na odpornosc", "rutinoscorbin", "lek" }
                });

            migrationBuilder.InsertData(
                table: "Klients",
                columns: new[] { "IdTrener", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1999, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ania", "Kowalewska" },
                    { 2, new DateTime(1998, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mateusz", "Domb" },
                    { 3, new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ignacy", "Ignacewicz" }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "IdTrener", "Date", "IdTrener", "DueDate", "IdKlient" },
                values: new object[] { 3, new DateTime(2020, 5, 18, 12, 34, 10, 977, DateTimeKind.Local).AddTicks(2980), 3, new DateTime(2020, 6, 18, 12, 34, 10, 977, DateTimeKind.Local).AddTicks(2990), 1 });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "IdTrener", "Date", "IdTrener", "DueDate", "IdKlient" },
                values: new object[] { 2, new DateTime(2020, 5, 18, 12, 34, 10, 977, DateTimeKind.Local).AddTicks(2940), 2, new DateTime(2020, 6, 18, 12, 34, 10, 977, DateTimeKind.Local).AddTicks(2960), 2 });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "IdTrener", "Date", "IdTrener", "DueDate", "IdKlient" },
                values: new object[] { 1, new DateTime(2020, 5, 18, 12, 34, 10, 975, DateTimeKind.Local).AddTicks(120), 1, new DateTime(2020, 6, 18, 12, 34, 10, 977, DateTimeKind.Local).AddTicks(1860), 3 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription" },
                values: new object[] { 3, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Uwagi",
                keyColumn: "IdTrener",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Uwagi",
                keyColumn: "IdTrener",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Uwagi",
                keyColumn: "IdTrener",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "IdTrener",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "IdTrener",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "IdTrener",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Treners",
                keyColumn: "IdTrener",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Treners",
                keyColumn: "IdTrener",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Treners",
                keyColumn: "IdTrener",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Klients",
                keyColumn: "IdTrener",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Klients",
                keyColumn: "IdTrener",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Klients",
                keyColumn: "IdTrener",
                keyValue: 3);
        }
    }
}
