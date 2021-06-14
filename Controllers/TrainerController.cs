using System;
using System.Linq;
using APBD.Models;
using APBD.Response;

using Microsoft.AspNetCore.Mvc;

namespace APBD.Controllers
{
    [Route("api/trainer")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        private readonly GymDbContext _context;

        public TrainerController(GymDbContext context)
        {
            _context = context;
        }

        [HttpGet("{index}")]
        public IActionResult GetTrainers(int index)
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Treners.Select(tre => new GetListOfTrainers
                {
                    IdTrenera = tre.IdTrener,
                    Imie = tre.FirstName,
                    Nazwisko = tre.LastName,
                    DataUrodzenia = tre.BirthDate,
                    Plec = tre.Plec,
                    Telefon = tre.Telefon,
                    PESEL = tre.PESEL,
                    NumerPaszportu = tre.NumerPaszportu,
                    StawkaGodzinowa = tre.StawkaGodzinowa
                }).Where(tre => tre.IdTrenera == index));
            }
            catch (ArgumentNullException e)
            {
                response = NotFound("Nie ma takiego trenera" + e.Message);
            }

            return response;
        }

        [HttpGet("all")]
        public IActionResult GetTrainers()
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Treners.Select(tre => new GetListOfTrainers
                {
                    IdTrenera = tre.IdTrener,
                    Imie = tre.FirstName,
                    Nazwisko = tre.LastName,
                    DataUrodzenia = tre.BirthDate,
                    Plec = tre.Plec,
                    Telefon = tre.Telefon,
                    PESEL = tre.PESEL,
                    NumerPaszportu = tre.NumerPaszportu,
                    StawkaGodzinowa = tre.StawkaGodzinowa
                }).ToList());
            }
            catch (ArgumentNullException e)
            {
                response = NotFound("Nie ma takiego trenera" + e.Message);
            }

            return response;
        }

        [HttpGet("all/sort/age")]
        public IActionResult GetTrainersSortByAge()
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Treners.Select(tre => new GetListOfTrainers
                {
                    IdTrenera = tre.IdTrener,
                    Imie = tre.FirstName,
                    Nazwisko = tre.LastName,
                    DataUrodzenia = tre.BirthDate,
                    Plec = tre.Plec,
                    Telefon = tre.Telefon,
                    PESEL = tre.PESEL,
                    NumerPaszportu = tre.NumerPaszportu,
                    StawkaGodzinowa = tre.StawkaGodzinowa
                }).ToList().OrderBy(item => item.DataUrodzenia));
            }
            catch (ArgumentNullException e)
            {
                response = NotFound("Nie ma takiego trenera" + e.Message);
            }

            return response;
        }

        [HttpGet("all/sort/name")]
        public IActionResult GetTrainersSortByName()
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Treners.Select(tre => new GetListOfTrainers
                {
                    IdTrenera = tre.IdTrener,
                    Imie = tre.FirstName,
                    Nazwisko = tre.LastName,
                    DataUrodzenia = tre.BirthDate,
                    Plec = tre.Plec,
                    Telefon = tre.Telefon,
                    PESEL = tre.PESEL,
                    NumerPaszportu = tre.NumerPaszportu,
                    StawkaGodzinowa = tre.StawkaGodzinowa
                }).ToList().OrderBy(item => item.Imie));
            }
            catch (ArgumentNullException e)
            {
                response = NotFound("Nie ma takiego trenera" + e.Message);
            }

            return response;
        }
    }
}
