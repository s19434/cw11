using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD.Response
{
    public class GetListOfTrainers
    {
        public int IdTrenera { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public char Plec { get; set; }
        public string Telefon { get; set; }
        public string PESEL { get; set; }
        public string NumerPaszportu { get; set; }
        public double StawkaGodzinowa { get; set; }


    }
}
