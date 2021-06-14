using System;
using System.Linq;
using APBD.Models;
using APBD.Response;

using Microsoft.AspNetCore.Mvc;

namespace APBD.Controllers
{
    [Route("api/programs")]
    [ApiController]
    public class TrenersController : ControllerBase
    {


        private readonly GymDbContext _context;

        public TrenersController(GymDbContext context)
        {
            _context = context;
        }

        [HttpGet("{index}")]
        public IActionResult GetTrener(int index)
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Programs.Select(pro => new GetListOfPrograms
                {
                    IdProgram = pro.IdProgram,
                    OpisProgramu = pro.Dane,
                    OcenaProgramu = pro.Ocena,
                    ImieKlienta = pro.Klient.FirstName,
                    NazwiskoKlienta = pro.Klient.LastName,
                    TelefonKlienta = pro.Klient.Telefon,
                    ImieTrenera = pro.Trener.FirstName,
                    NazwiskoTrenera = pro.Trener.LastName,
                    TelefonTrenera = pro.Trener.Telefon,
                    OpisUwag = pro.Uwaga.Opis ?? "Uwag nie ma od klienta"
                }).Where(Program => Program.IdProgram == index));
            }
            catch (ArgumentNullException e)
            {
                response = NotFound("Nie ma takiego programu" + e.Message);
            }

            return response;

        }

        [HttpGet("all")]
        public IActionResult GetTreners()
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Programs.Select(pro => new GetListOfPrograms
                {
                    IdProgram = pro.IdProgram,
                    OpisProgramu = pro.Dane,
                    OcenaProgramu = pro.Ocena,
                    ImieKlienta = pro.Klient.FirstName,
                    NazwiskoKlienta = pro.Klient.LastName,
                    TelefonKlienta = pro.Klient.Telefon,
                    ImieTrenera = pro.Trener.FirstName,
                    NazwiskoTrenera = pro.Trener.LastName,
                    TelefonTrenera = pro.Trener.Telefon,
                    OpisUwag = pro.Uwaga.Opis ?? "Uwag nie ma od klienta"
                }).ToList());
            }
            catch (ArgumentNullException e)
            {
                response = NotFound("Nie ma takiego programu" + e.Message);
            }

            return response;

        }

        [HttpGet("all/sort/name/client")]
        public IActionResult GetTrenersSortByNameClient()
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Programs.Select(pro => new GetListOfPrograms
                {
                    IdProgram = pro.IdProgram,
                    OpisProgramu = pro.Dane,
                    OcenaProgramu = pro.Ocena,
                    ImieKlienta = pro.Klient.FirstName,
                    NazwiskoKlienta = pro.Klient.LastName,
                    TelefonKlienta = pro.Klient.Telefon,
                    ImieTrenera = pro.Trener.FirstName,
                    NazwiskoTrenera = pro.Trener.LastName,
                    TelefonTrenera = pro.Trener.Telefon,
                    OpisUwag = pro.Uwaga.Opis ?? "Uwag nie ma od klienta"
                }).ToList().OrderBy(item => item.ImieKlienta));
            }
            catch (ArgumentNullException e)
            {
                response = NotFound("Nie ma takiego programu" + e.Message);
            }

            return response;

        }

                [HttpGet("all/sort/name/trainer")]
        public IActionResult GetProgramsSortByNameTrainer()
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Programs.Select(pro => new GetListOfPrograms
                {
                    IdProgram = pro.IdProgram,
                    OpisProgramu = pro.Dane,
                    OcenaProgramu = pro.Ocena,
                    ImieKlienta = pro.Klient.FirstName,
                    NazwiskoKlienta = pro.Klient.LastName,
                    TelefonKlienta = pro.Klient.Telefon,
                    ImieTrenera = pro.Trener.FirstName,
                    NazwiskoTrenera = pro.Trener.LastName,
                    TelefonTrenera = pro.Trener.Telefon,
                    OpisUwag = pro.Uwaga.Opis ?? "Uwag nie ma od klienta"
                }).ToList().OrderBy(item => item.ImieTrenera));
            }
            catch (ArgumentNullException e)
            {
                response = NotFound("Nie ma takiego programu" + e.Message);
            }

            return response;

        }



    }
}