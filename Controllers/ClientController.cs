using System;
using System.Linq;
using APBD.Models;
using APBD.Response;

using Microsoft.AspNetCore.Mvc;

namespace APBD.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly GymDbContext _context;

        public ClientController(GymDbContext context)
        {
            _context = context;
        }

        [HttpGet("{index}")]
        public IActionResult GetClient(int index)
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Klients.Select(kli => new GetListOfClients
                {
                    IdKlient = kli.IdKlient,
                    Imie = kli.FirstName,
                    Nazwisko = kli.LastName,
                    DataUrodzenia = kli.BirthDate,
                    Plec = kli.Plec,
                    Telefon = kli.Telefon,
                    PESEL = kli.PESEL,
                    NumerPaszportu = kli.NumerPaszportu,
                    KontoBankowe = kli.KontoBankowe,
                    ImieTrenera = kli.Program.Trener.FirstName,
                    NazwiskoTrenera = kli.Program.Trener.LastName,
                    OpisTreningu = kli.Program.Dane,
                    UwagaDoTreningu = kli.Program.Uwaga.Opis ?? "Uwag nie ma od klienta"
                }).Where(Program => Program.IdKlient == index));
            }
            catch (ArgumentNullException e)
            {
                response = NotFound("Nie ma takiego klienta" + e.Message);
            }

            return response;
        }

        [HttpGet("all")]
        public IActionResult GetClients()
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Klients.Select(kli => new GetListOfClients
                {
                    IdKlient = kli.IdKlient,
                    Imie = kli.FirstName,
                    Nazwisko = kli.LastName,
                    DataUrodzenia = kli.BirthDate,
                    Plec = kli.Plec,
                    Telefon = kli.Telefon,
                    PESEL = kli.PESEL,
                    NumerPaszportu = kli.NumerPaszportu,
                    KontoBankowe = kli.KontoBankowe,
                    ImieTrenera = kli.Program.Trener.FirstName,
                    NazwiskoTrenera = kli.Program.Trener.LastName,
                    OpisTreningu = kli.Program.Dane,
                    UwagaDoTreningu = kli.Program.Uwaga.Opis ?? "Uwag nie ma od klienta"
                }).ToList());
            }
            catch (ArgumentNullException e)
            {
                response = NotFound("Nie ma takiego klienta" + e.Message);
            }

            return response;
        }

        [HttpGet("all/sort/name/client")]
        public IActionResult GetTClientsSortByNameClient()
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Klients.Select(kli => new GetListOfClients
                {
                    IdKlient = kli.IdKlient,
                    Imie = kli.FirstName,
                    Nazwisko = kli.LastName,
                    DataUrodzenia = kli.BirthDate,
                    Plec = kli.Plec,
                    Telefon = kli.Telefon,
                    PESEL = kli.PESEL,
                    NumerPaszportu = kli.NumerPaszportu,
                    KontoBankowe = kli.KontoBankowe,
                    ImieTrenera = kli.Program.Trener.FirstName,
                    NazwiskoTrenera = kli.Program.Trener.LastName,
                    OpisTreningu = kli.Program.Dane,
                    UwagaDoTreningu = kli.Program.Uwaga.Opis ?? "Uwag nie ma od klienta"
                }).ToList().OrderBy(item => item.Imie));
            }
            catch (ArgumentNullException e)
            {
                response = NotFound("Nie ma takiego klienta" + e.Message);
            }

            return response;
        }


        [HttpGet("all/sort/age/client")]
        public IActionResult GetTClientsSortByAgeClient()
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Klients.Select(kli => new GetListOfClients
                {
                    IdKlient = kli.IdKlient,
                    Imie = kli.FirstName,
                    Nazwisko = kli.LastName,
                    DataUrodzenia = kli.BirthDate,
                    Plec = kli.Plec,
                    Telefon = kli.Telefon,
                    PESEL = kli.PESEL,
                    NumerPaszportu = kli.NumerPaszportu,
                    KontoBankowe = kli.KontoBankowe,
                    ImieTrenera = kli.Program.Trener.FirstName,
                    NazwiskoTrenera = kli.Program.Trener.LastName,
                    OpisTreningu = kli.Program.Dane,
                    UwagaDoTreningu = kli.Program.Uwaga.Opis ?? "Uwag nie ma od klienta"
                }).ToList().OrderBy(item => item.DataUrodzenia));
            }
            catch (ArgumentNullException e)
            {
                response = NotFound("Nie ma takiego klienta" + e.Message);
            }

            return response;
        }

    }
}
