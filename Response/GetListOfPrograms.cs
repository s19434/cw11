using APBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD.Response
{
    public class GetListOfPrograms
    {
        public int IdProgram { get; set; }
        public string OpisProgramu { get; set; }
        public int OcenaProgramu { get; set; }

        public string ImieKlienta { get; set; }
        public string NazwiskoKlienta { get; set; }
        public string TelefonKlienta { get; set; }

        public string ImieTrenera { get; set; }
        public string NazwiskoTrenera { get; set; }
        public string TelefonTrenera { get; set; }

        public string OpisUwag { get; set; }

    }
}
