using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APBD.Models
{
    public class PrescriptionDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }



        public PrescriptionDbContext(DbContextOptions options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            _ = modelBuilder.Entity<Prescription_Medicament>()
                .HasKey(pmK => new { pmK.IdMedicament, pmK.IdPrescription });

            SeedSampleData(modelBuilder);
        }

        private void SeedSampleData(ModelBuilder modelBuilder)
        {
            var doctors = new List<Doctor>() {

            new Doctor { IdDoctor = 1, FirstName = "Nigel", LastName = "Hodgson", Email = "kdipesh1attriz@billycarson.ga" },
            new Doctor { IdDoctor = 2, FirstName = "Anita", LastName = "Monroe", Email = "washtibesfkiu@rinito.gq" },
            new Doctor { IdDoctor = 3, FirstName = "Maisie", LastName = "Fowler", Email = "paminaoran-31o@graphtiobull.tk" },
            new Doctor { IdDoctor = 4, FirstName = "Kiera", LastName = "Leblanc", Email = "rhazem_ab@tisrendvi.ml" }
        };

            var patients = new List<Patient>() {

            new Patient { IdPatient = 1, FirstName = "Ayah", LastName = "Mcdonnell", BirthDate = DateTime.Parse("1973-07-25") },
            new Patient { IdPatient = 2, FirstName = "Mehmet", LastName = "Doherty", BirthDate = DateTime.Parse("1991-12-18")  },
            new Patient { IdPatient = 3, FirstName = "Macsen", LastName = "George", BirthDate = DateTime.Parse("2004-09-13") },
            new Patient { IdPatient = 4, FirstName = "Zidane", LastName = "James", BirthDate = DateTime.Parse("2005-03-27") }
        };


            var prescriptions = new List<Prescription>() {

            new Prescription { IdPrescription = 1, Date = DateTime.Now, DueDate = DateTime.Now.AddMonths(1), IdDoctor = 1, IdPatient = 1 },
            new Prescription { IdPrescription = 2, Date = DateTime.Now, DueDate = DateTime.Now.AddMonths(1), IdDoctor = 2, IdPatient = 2 },
            new Prescription { IdPrescription = 3, Date = DateTime.Now, DueDate = DateTime.Now.AddMonths(1), IdDoctor = 3, IdPatient = 3 },
            new Prescription { IdPrescription = 4, Date = DateTime.Now, DueDate = DateTime.Now.AddMonths(1), IdDoctor = 4, IdPatient = 4 },

        };

            var medicaments = new List<Medicament>() {

            new Medicament { IdMedicament = 1, Name = "Mistress", Description = "against stress", Type = "pills" },
            new Medicament { IdMedicament = 2, Name = "Blitz", Description = "against toothache", Type = "pills" },
            new Medicament { IdMedicament = 3, Name = "Tails", Description = "against hair loss", Type = "ointment" },
            new Medicament { IdMedicament = 4, Name = "Diamond", Description = "for good skin", Type = "syrup" }
        };

            var prescriptionMedicaments = new List<Prescription_Medicament>() {

            new Prescription_Medicament { IdPrescription = 1, IdMedicament = 1 },
            new Prescription_Medicament { IdPrescription = 2, IdMedicament = 2 },
            new Prescription_Medicament { IdPrescription = 3, IdMedicament = 3 },
            new Prescription_Medicament { IdPrescription = 4, IdMedicament = 4 }
        };

            modelBuilder.Entity<Doctor>().HasData(doctors);
            modelBuilder.Entity<Patient>().HasData(patients);
            modelBuilder.Entity<Prescription>().HasData(prescriptions);
            modelBuilder.Entity<Medicament>().HasData(medicaments);
            modelBuilder.Entity<Prescription_Medicament>().HasData(prescriptionMedicaments);
        }
    }
}