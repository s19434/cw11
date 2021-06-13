using System;
using System.Collections.Generic;

namespace APBD.Models
{
    public class Program
    {
        public int IdProgram{ get; set; }
        public string Dane { get; set; }
        public int Ocena { get; set; }

        public int IdKlient { get; set; }
        public int IdTrener { get; set; }
        public int IdUwagi { get; set; }

        public virtual Klient Klient { get; set; }
        public virtual Trener Trener { get; set; }
        public virtual Uwaga Uwagi { get; set; }

    }
}