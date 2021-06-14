using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    IdAdministrator = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Plec = table.Column<string>(nullable: false),
                    Telefon = table.Column<string>(maxLength: 12, nullable: true),
                    PESEL = table.Column<string>(maxLength: 11, nullable: true),
                    NumerPaszportu = table.Column<string>(maxLength: 9, nullable: true),
                    StawkaGodzinowa = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.IdAdministrator);
                });

            migrationBuilder.CreateTable(
                name: "Treners",
                columns: table => new
                {
                    IdTrener = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Plec = table.Column<string>(nullable: false),
                    Telefon = table.Column<string>(maxLength: 12, nullable: true),
                    PESEL = table.Column<string>(maxLength: 11, nullable: true),
                    NumerPaszportu = table.Column<string>(maxLength: 9, nullable: true),
                    StawkaGodzinowa = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treners", x => x.IdTrener);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    IdProgram = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dane = table.Column<string>(maxLength: 1000, nullable: true),
                    Ocena = table.Column<int>(nullable: false),
                    IdKlient = table.Column<int>(nullable: false),
                    IdTrener = table.Column<int>(nullable: false),
                    IdUwaga = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.IdProgram);
                    table.ForeignKey(
                        name: "FK_Programs_Treners_IdTrener",
                        column: x => x.IdTrener,
                        principalTable: "Treners",
                        principalColumn: "IdTrener",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Klients",
                columns: table => new
                {
                    IdKlient = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Plec = table.Column<string>(nullable: false),
                    Telefon = table.Column<string>(maxLength: 12, nullable: true),
                    PESEL = table.Column<string>(maxLength: 11, nullable: true),
                    NumerPaszportu = table.Column<string>(maxLength: 9, nullable: true),
                    KontoBankowe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klients", x => x.IdKlient);
                    table.ForeignKey(
                        name: "FK_Klients_Programs_IdKlient",
                        column: x => x.IdKlient,
                        principalTable: "Programs",
                        principalColumn: "IdProgram",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uwagi",
                columns: table => new
                {
                    IdUwaga = table.Column<int>(nullable: false),
                    Opis = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uwagi", x => x.IdUwaga);
                    table.ForeignKey(
                        name: "FK_Uwagi_Programs_IdUwaga",
                        column: x => x.IdUwaga,
                        principalTable: "Programs",
                        principalColumn: "IdProgram",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Administrators",
                columns: new[] { "IdAdministrator", "BirthDate", "FirstName", "LastName", "NumerPaszportu", "PESEL", "Plec", "StawkaGodzinowa", "Telefon" },
                values: new object[,]
                {
                    { 1, new DateTime(1973, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ayah", "Mcdonnell", "ZE0534979", "00241377251", "K", 25.0, "904826683" },
                    { 2, new DateTime(1978, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandy", "Smith", "ZE5321833", "62010793329", "K", 27.5, "904826683" }
                });

            migrationBuilder.InsertData(
                table: "Treners",
                columns: new[] { "IdTrener", "BirthDate", "FirstName", "LastName", "NumerPaszportu", "PESEL", "Plec", "StawkaGodzinowa", "Telefon" },
                values: new object[,]
                {
                    { 1, new DateTime(1973, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nigel", "Hodgson", "ZE9754217", "87011172711", "M", 40.0, "628370610" },
                    { 2, new DateTime(1985, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anita", "Monroe", "ZE1728081", "89102665995", "K", 45.5, "979117677" },
                    { 3, new DateTime(1978, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maisie", "Fowler", "ZE5747434", "62082369316", "K", 35.0, "492947624" }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "IdProgram", "Dane", "IdKlient", "IdTrener", "IdUwaga", "Ocena" },
                values: new object[] { 1, @"1. Wyciskanie sztangi głową w dół – można zastąpić wyciskanie na ławce płaskiej
2. Podciąganie na drążku, chwyt młotkowy – można zastąpić ściąganiem wyciągu górnego
3. Wyciskanie żołnierskie
4. Przysiad
5. Uginanie ramion ze sztangą łamaną
6. Prostowanie ramion przy wyciągu
7. Ściągnie nóg do klatki przy wyciągu – ćwiczenie na brzuch", 1, 1, 0, 5 });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "IdProgram", "Dane", "IdKlient", "IdTrener", "IdUwaga", "Ocena" },
                values: new object[] { 2, @"1. Pompki na poręczach
2. Wiosłowanie półsztangą – można zastąpić wiosłowaniem sztangą
3. Unoszenie hantli bokiem
4. Martwy ciąg
5. Podciągnie pochwytem – można zastąpić ściąganiem wyciągu górnego
6. Wyciskanie francuskie za głową
7. Rollout – ćwiczenie na brzuch", 2, 1, 0, 4 });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "IdProgram", "Dane", "IdKlient", "IdTrener", "IdUwaga", "Ocena" },
                values: new object[] { 3, @"1. Wyciskanie hantli głową w górę
2. Podciąganie na drążku, chwyt szeroki – można zastąpić ściąganiem wyciągu górnego
3. Wyciskanie hantli nad głowę
4. Wypychanie nogami na maszynie
6. Uginanie ramion z liną wyciągu
7. Pompki na triceps
8. Crunch", 3, 3, 1, 2 });

            migrationBuilder.InsertData(
                table: "Klients",
                columns: new[] { "IdKlient", "BirthDate", "FirstName", "KontoBankowe", "LastName", "NumerPaszportu", "PESEL", "Plec", "Telefon" },
                values: new object[,]
                {
                    { 1, new DateTime(1984, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ayah", "28461889464437738943448551", "Mcdonnell", "ZE4267334", "97072477841", "K", "904826683" },
                    { 2, new DateTime(1991, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mehmet", "50439485639173067302973087", "Doherty", "ZE1732550", "75100148497", "M", "072277030" },
                    { 3, new DateTime(2004, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Macsen", "40198752755832572842834646", "George", "ZE3587822", "66041366424", "M", "377531593" }
                });

            migrationBuilder.InsertData(
                table: "Uwagi",
                columns: new[] { "IdUwaga", "Opis" },
                values: new object[] { 1, "Proszę o przepisaniu treningu ze względu na niedawna kontuzje kolana." });

            migrationBuilder.CreateIndex(
                name: "IX_Programs_IdTrener",
                table: "Programs",
                column: "IdTrener");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrators");

            migrationBuilder.DropTable(
                name: "Klients");

            migrationBuilder.DropTable(
                name: "Uwagi");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "Treners");
        }
    }
}
