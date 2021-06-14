using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD.Response
{
    public class GetListOfClients
    {
        public int IdKlient { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public char Plec { get; set; }
        public string Telefon { get; set; }
        public string PESEL { get; set; }
        public string NumerPaszportu { get; set; }

        public string KontoBankowe { get; set; }

        public string ImieTrenera { get; set; }
        public string NazwiskoTrenera { get; set; }

        public string OpisTreningu { get; set; }
        public string UwagaDoTreningu { get; set; }
    }
}
