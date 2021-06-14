﻿// <auto-generated />
using System;
using APBD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APBD.Migrations
{
    [DbContext(typeof(GymDbContext))]
    partial class GymDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APBD.Models.Administrator", b =>
                {
                    b.Property<int>("IdAdministrator")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("NumerPaszportu")
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("PESEL")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Plec")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<double>("StawkaGodzinowa")
                        .HasColumnType("float");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.HasKey("IdAdministrator");

                    b.ToTable("Administrators");

                    b.HasData(
                        new
                        {
                            IdAdministrator = 1,
                            BirthDate = new DateTime(1973, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ayah",
                            LastName = "Mcdonnell",
                            NumerPaszportu = "ZE0534979",
                            PESEL = "00241377251",
                            Plec = "K",
                            StawkaGodzinowa = 25.0,
                            Telefon = "904826683"
                        },
                        new
                        {
                            IdAdministrator = 2,
                            BirthDate = new DateTime(1978, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Sandy",
                            LastName = "Smith",
                            NumerPaszportu = "ZE5321833",
                            PESEL = "62010793329",
                            Plec = "K",
                            StawkaGodzinowa = 27.5,
                            Telefon = "904826683"
                        });
                });

            modelBuilder.Entity("APBD.Models.Klient", b =>
                {
                    b.Property<int>("IdKlient")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("KontoBankowe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("NumerPaszportu")
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("PESEL")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Plec")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.HasKey("IdKlient");

                    b.ToTable("Klients");

                    b.HasData(
                        new
                        {
                            IdKlient = 1,
                            BirthDate = new DateTime(1984, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ayah",
                            KontoBankowe = "28461889464437738943448551",
                            LastName = "Mcdonnell",
                            NumerPaszportu = "ZE4267334",
                            PESEL = "97072477841",
                            Plec = "K",
                            Telefon = "904826683"
                        },
                        new
                        {
                            IdKlient = 2,
                            BirthDate = new DateTime(1991, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mehmet",
                            KontoBankowe = "50439485639173067302973087",
                            LastName = "Doherty",
                            NumerPaszportu = "ZE1732550",
                            PESEL = "75100148497",
                            Plec = "M",
                            Telefon = "072277030"
                        },
                        new
                        {
                            IdKlient = 3,
                            BirthDate = new DateTime(2004, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Macsen",
                            KontoBankowe = "40198752755832572842834646",
                            LastName = "George",
                            NumerPaszportu = "ZE3587822",
                            PESEL = "66041366424",
                            Plec = "M",
                            Telefon = "377531593"
                        });
                });

            modelBuilder.Entity("APBD.Models.Program", b =>
                {
                    b.Property<int>("IdProgram")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dane")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<int>("IdKlient")
                        .HasColumnType("int");

                    b.Property<int>("IdTrener")
                        .HasColumnType("int");

                    b.Property<int>("IdUwaga")
                        .HasColumnType("int");

                    b.Property<int>("Ocena")
                        .HasColumnType("int");

                    b.HasKey("IdProgram");

                    b.HasIndex("IdTrener");

                    b.ToTable("Programs");

                    b.HasData(
                        new
                        {
                            IdProgram = 1,
                            Dane = @"1. Wyciskanie sztangi głową w dół – można zastąpić wyciskanie na ławce płaskiej
2. Podciąganie na drążku, chwyt młotkowy – można zastąpić ściąganiem wyciągu górnego
3. Wyciskanie żołnierskie
4. Przysiad
5. Uginanie ramion ze sztangą łamaną
6. Prostowanie ramion przy wyciągu
7. Ściągnie nóg do klatki przy wyciągu – ćwiczenie na brzuch",
                            IdKlient = 1,
                            IdTrener = 1,
                            IdUwaga = 0,
                            Ocena = 5
                        },
                        new
                        {
                            IdProgram = 2,
                            Dane = @"1. Pompki na poręczach
2. Wiosłowanie półsztangą – można zastąpić wiosłowaniem sztangą
3. Unoszenie hantli bokiem
4. Martwy ciąg
5. Podciągnie pochwytem – można zastąpić ściąganiem wyciągu górnego
6. Wyciskanie francuskie za głową
7. Rollout – ćwiczenie na brzuch",
                            IdKlient = 2,
                            IdTrener = 1,
                            IdUwaga = 0,
                            Ocena = 4
                        },
                        new
                        {
                            IdProgram = 3,
                            Dane = @"1. Wyciskanie hantli głową w górę
2. Podciąganie na drążku, chwyt szeroki – można zastąpić ściąganiem wyciągu górnego
3. Wyciskanie hantli nad głowę
4. Wypychanie nogami na maszynie
6. Uginanie ramion z liną wyciągu
7. Pompki na triceps
8. Crunch",
                            IdKlient = 3,
                            IdTrener = 3,
                            IdUwaga = 1,
                            Ocena = 2
                        });
                });

            modelBuilder.Entity("APBD.Models.Trener", b =>
                {
                    b.Property<int>("IdTrener")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("NumerPaszportu")
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("PESEL")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Plec")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<double>("StawkaGodzinowa")
                        .HasColumnType("float");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.HasKey("IdTrener");

                    b.ToTable("Treners");

                    b.HasData(
                        new
                        {
                            IdTrener = 1,
                            BirthDate = new DateTime(1973, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Nigel",
                            LastName = "Hodgson",
                            NumerPaszportu = "ZE9754217",
                            PESEL = "87011172711",
                            Plec = "M",
                            StawkaGodzinowa = 40.0,
                            Telefon = "628370610"
                        },
                        new
                        {
                            IdTrener = 2,
                            BirthDate = new DateTime(1985, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Anita",
                            LastName = "Monroe",
                            NumerPaszportu = "ZE1728081",
                            PESEL = "89102665995",
                            Plec = "K",
                            StawkaGodzinowa = 45.5,
                            Telefon = "979117677"
                        },
                        new
                        {
                            IdTrener = 3,
                            BirthDate = new DateTime(1978, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Maisie",
                            LastName = "Fowler",
                            NumerPaszportu = "ZE5747434",
                            PESEL = "62082369316",
                            Plec = "K",
                            StawkaGodzinowa = 35.0,
                            Telefon = "492947624"
                        });
                });

            modelBuilder.Entity("APBD.Models.Uwaga", b =>
                {
                    b.Property<int>("IdUwaga")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("IdUwaga");

                    b.ToTable("Uwagi");

                    b.HasData(
                        new
                        {
                            IdUwaga = 1,
                            Opis = "Proszę o przepisaniu treningu ze względu na niedawna kontuzje kolana."
                        });
                });

            modelBuilder.Entity("APBD.Models.Klient", b =>
                {
                    b.HasOne("APBD.Models.Program", "Program")
                        .WithOne("Klient")
                        .HasForeignKey("APBD.Models.Klient", "IdKlient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APBD.Models.Program", b =>
                {
                    b.HasOne("APBD.Models.Trener", "Trener")
                        .WithMany("Programs")
                        .HasForeignKey("IdTrener")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APBD.Models.Uwaga", b =>
                {
                    b.HasOne("APBD.Models.Program", "Program")
                        .WithOne("Uwaga")
                        .HasForeignKey("APBD.Models.Uwaga", "IdUwaga")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
