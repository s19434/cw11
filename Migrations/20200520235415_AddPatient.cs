using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD.Migrations
{
    public partial class AddKlient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Treners_TrenerId",
                table: "Programs");

            migrationBuilder.AlterColumn<int>(
                name: "IdTrener",
                table: "Programs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdKlient",
                table: "Programs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Klients",
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
                    table.PrimaryKey("PK_Klients", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programs_KlientId",
                table: "Programs",
                column: "IdKlient");

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Treners_TrenerId",
                table: "Programs",
                column: "IdTrener",
                principalTable: "Treners",
                principalColumn: "IdTrener",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Klients_KlientId",
                table: "Programs",
                column: "IdKlient",
                principalTable: "Klients",
                principalColumn: "IdTrener",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Treners_TrenerId",
                table: "Programs");

            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Klients_KlientId",
                table: "Programs");

            migrationBuilder.DropTable(
                name: "Klients");

            migrationBuilder.DropIndex(
                name: "IX_Programs_KlientId",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "IdKlient",
                table: "Programs");

            migrationBuilder.AlterColumn<int>(
                name: "IdTrener",
                table: "Programs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdTrener",
                table: "Programs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdKlient",
                table: "Programs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Treners_TrenerId",
                table: "Programs",
                column: "IdTrener",
                principalTable: "Treners",
                principalColumn: "IdTrener",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
