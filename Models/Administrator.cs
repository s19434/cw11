using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD.Models
{
    public class Administrator : Pracownik
    {
        public int IdAdministrator { get; set; }
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override DateTime BirthDate { get; set; }
        public override char Plec { get; set; }
        public override string Telefon { get; set; }
        public override string PESEL { get; set; }
        public override string NumerPaszportu { get; set; }
        public override double StawkaGodzinowa { get; set; }
    }
}
