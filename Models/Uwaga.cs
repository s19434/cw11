using System.Collections;
using System.Collections.Generic;

namespace APBD.Models
{
    public class Uwaga
    {
        public int IdUwaga{ get; set; }
        public string Opis { get; set; }

        public virtual Program Program { get; set; }
    }
}