using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD.Models
{
    public abstract class Osoba
    {
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract DateTime BirthDate { get; set; }
        public abstract char Plec { get; set; }
        public abstract string Telefon { get; set; }
        public abstract string PESEL { get; set; }
        public abstract string NumerPaszportu { get; set; }

    }
}
