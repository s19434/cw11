using System;
using System.Collections;
using System.Collections.Generic;

namespace APBD.Models
{
    public class Trener : Pracownik
    {
        public int IdTrener { get; set; }  
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override DateTime BirthDate { get; set; }
        public override char Plec { get; set; }
        public override string Telefon { get; set; }
        public override string PESEL { get; set; }
        public override string NumerPaszportu { get; set; }
        public override double StawkaGodzinowa { get; set; }

        public virtual ICollection<Program> Programs { get; set; }
        
    }
}