using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD.Models
{
    public abstract class Pracownik : Osoba
    {
        public abstract double StawkaGodzinowa { get; set; }
    }
}
