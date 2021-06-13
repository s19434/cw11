using System;
using System.Collections.Generic;

namespace APBD.Models
{
    public class Klient : Osoba
    {
        public int IdKlient { get; set; }
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override DateTime BirthDate { get; set; }
        public override char Plec { get; set; }
        public override string Telefon { get; set; }
        public override string PESEL { get; set; }
        public override string NumerPaszportu { get; set; }

        public string KontoBankowe { get; set; }

        public virtual Program Program { get; set; }
    }
}