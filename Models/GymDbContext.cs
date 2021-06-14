using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APBD.Models
{
    public class GymDbContext : DbContext
    {
        public DbSet<Trener> Treners { get; set; }
        public DbSet<Klient> Klients { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

        public DbSet<Program> Programs { get; set; }
        public DbSet<Uwaga> Uwagi { get; set; }




        public GymDbContext(DbContextOptions options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Trener>(opt =>
            {
                opt.HasKey(e => e.IdTrener);
                

                opt.Property(p => p.FirstName)
                .HasMaxLength(30);

                opt.Property(p => p.LastName)
                .HasMaxLength(30);

                opt.Property(p => p.Telefon)
                .HasMaxLength(12);

                opt.Property(p => p.PESEL)
                .HasMaxLength(11);

                opt.Property(p => p.NumerPaszportu)
                .HasMaxLength(9);


                opt.HasMany(e => e.Programs)
                .WithOne(e => e.Trener)
                .HasForeignKey(e => e.IdTrener);

            });

            modelBuilder.Entity<Administrator>(opt =>
            {
                opt.HasKey(e => e.IdAdministrator);
                

                opt.Property(p => p.FirstName)
                .HasMaxLength(30);

                opt.Property(p => p.LastName)
                .HasMaxLength(30);

                opt.Property(p => p.Telefon)
                .HasMaxLength(12);

                opt.Property(p => p.PESEL)
                .HasMaxLength(11);

                opt.Property(p => p.NumerPaszportu)
                .HasMaxLength(9);

            });

            modelBuilder.Entity<Klient>(opt =>
            {
                opt.HasKey(e => e.IdKlient);
                

                opt.Property(p => p.FirstName)
                .HasMaxLength(30);

                opt.Property(p => p.LastName)
                .HasMaxLength(30);

                opt.Property(p => p.Telefon)
                .HasMaxLength(12);

                opt.Property(p => p.PESEL)
                .HasMaxLength(11);

                opt.Property(p => p.NumerPaszportu)
                .HasMaxLength(9);


            });

            modelBuilder.Entity<Program>(opt =>
            {
                opt.HasKey(e => e.IdProgram);
               

                opt.HasOne(e => e.Klient)
                .WithOne(e => e.Program)
                .HasForeignKey<Klient>(e => e.IdKlient);

                opt.HasOne(e => e.Uwaga)
                .WithOne(e => e.Program)
                .HasForeignKey<Uwaga>(e => e.IdUwaga);


                opt.Property(p => p.Dane)
                .HasMaxLength(1000);


            });

            modelBuilder.Entity<Uwaga>(opt =>
            {
                opt.HasKey(e => e.IdUwaga);
              
                
                opt.Property(p => p.Opis)
                .HasMaxLength(500);


            });

            SeedSampleData(modelBuilder);
        }

        private void SeedSampleData(ModelBuilder modelBuilder)
        {
            var Treners = new List<Trener>() {

            new Trener { IdTrener = 1, FirstName = "Nigel", LastName = "Hodgson", BirthDate = DateTime.Parse("1973-07-25"), Plec = 'M', Telefon = "628370610", PESEL = "87011172711",  NumerPaszportu = "ZE9754217", StawkaGodzinowa = 40.0},
            new Trener { IdTrener = 2, FirstName = "Anita", LastName = "Monroe", BirthDate = DateTime.Parse("1985-07-20"), Plec = 'K', Telefon = "979117677", PESEL = "89102665995", NumerPaszportu = "ZE1728081", StawkaGodzinowa = 45.5 },
            new Trener { IdTrener = 3, FirstName = "Maisie", LastName = "Fowler", BirthDate = DateTime.Parse("1978-05-13"), Plec = 'K', Telefon = "492947624", PESEL = "62082369316", NumerPaszportu = "ZE5747434", StawkaGodzinowa = 35.0 },
        };

            var Klients = new List<Klient>() {

            new Klient { IdKlient = 1, FirstName = "Ayah", LastName = "Mcdonnell", BirthDate = DateTime.Parse("1984-05-19"), Plec = 'K', Telefon = "904826683", PESEL = "97072477841", NumerPaszportu = "ZE4267334", KontoBankowe = "28461889464437738943448551"},
            new Klient { IdKlient = 2, FirstName = "Mehmet", LastName = "Doherty", BirthDate = DateTime.Parse("1991-04-18"),  Plec = 'M', Telefon = "072277030", PESEL = "75100148497", NumerPaszportu = "ZE1732550", KontoBankowe = "50439485639173067302973087"},
            new Klient { IdKlient = 3, FirstName = "Macsen", LastName = "George", BirthDate = DateTime.Parse("2004-09-13"), Plec = 'M', Telefon = "377531593", PESEL = "66041366424", NumerPaszportu = "ZE3587822", KontoBankowe = "40198752755832572842834646"}
        };

            var Administrators = new List<Administrator>() {

            new Administrator { IdAdministrator = 1, FirstName = "Ayah", LastName = "Mcdonnell", BirthDate = DateTime.Parse("1973-07-25"), Plec = 'K', Telefon = "904826683", PESEL = "00241377251", NumerPaszportu = "ZE0534979", StawkaGodzinowa = 25.0},
            new Administrator { IdAdministrator = 2, FirstName = "Sandy", LastName = "Smith", BirthDate = DateTime.Parse("1978-07-25"), Plec = 'K', Telefon = "904826683", PESEL = "62010793329", NumerPaszportu = "ZE5321833", StawkaGodzinowa = 27.5},

        };




            var Uwagi = new List<Uwaga>() {

            new Uwaga { IdUwaga= 1, Opis = "Proszę o przepisaniu treningu ze względu na niedawna kontuzje kolana." },

        };
            var Programs = new List<Program>() {

            new Program { IdProgram= 1, Dane = "1. Wyciskanie sztangi głową w dół – można zastąpić wyciskanie na ławce płaskiej"
                                                +"\n2. Podciąganie na drążku, chwyt młotkowy – można zastąpić ściąganiem wyciągu górnego"
                                                +"\n3. Wyciskanie żołnierskie"
                                                +"\n4. Przysiad"
                                                +"\n5. Uginanie ramion ze sztangą łamaną"
                                                +"\n6. Prostowanie ramion przy wyciągu"
                                                +"\n7. Ściągnie nóg do klatki przy wyciągu – ćwiczenie na brzuch", Ocena = 5, IdKlient = 1, IdTrener = 1},
            new Program { IdProgram= 2, Dane = "1. Pompki na poręczach"
                                                +"\n2. Wiosłowanie półsztangą – można zastąpić wiosłowaniem sztangą"
                                                +"\n3. Unoszenie hantli bokiem"
                                                +"\n4. Martwy ciąg"
                                                +"\n5. Podciągnie pochwytem – można zastąpić ściąganiem wyciągu górnego"
                                                +"\n6. Wyciskanie francuskie za głową"
                                                +"\n7. Rollout – ćwiczenie na brzuch", Ocena = 4, IdKlient = 2, IdTrener = 1},
            new Program { IdProgram= 3, Dane = "1. Wyciskanie hantli głową w górę"
                                                +"\n2. Podciąganie na drążku, chwyt szeroki – można zastąpić ściąganiem wyciągu górnego"
                                                +"\n3. Wyciskanie hantli nad głowę"
                                                +"\n4. Wypychanie nogami na maszynie"
                                                +"\n6. Uginanie ramion z liną wyciągu"
                                                +"\n7. Pompki na triceps"
                                                +"\n8. Crunch", Ocena = 2, IdKlient = 3, IdTrener = 3, IdUwaga = 1 }

        };
            modelBuilder.Entity<Trener>().HasData(Treners);
            modelBuilder.Entity<Klient>().HasData(Klients);
            modelBuilder.Entity<Administrator>().HasData(Administrators);
            modelBuilder.Entity<Uwaga>().HasData(Uwagi);
            modelBuilder.Entity<Program>().HasData(Programs);

        }
    }
}