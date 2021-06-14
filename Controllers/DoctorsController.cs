using System;
using System.Linq;
using APBD.Models;
using APBD.Response;

using Microsoft.AspNetCore.Mvc;

namespace APBD.Controllers
{
    [Route("api/Treners")]
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
                response = Ok(_context.Treners
                    .First(Trener => Trener.IdTrener == index)

                    );
            }
            catch (Exception exc)
            {
                response = BadRequest("ERROR with geting Trener" + exc.StackTrace);
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
                    OpisProgramu = pro.Dane,
                    OcenaProgramu = pro.Ocena,
                    ImieKlienta = pro.Klient.FirstName,
                    NazwiskoKlienta = pro.Klient.LastName,
                    TelefonKlienta = pro.Klient.Telefon,
                    ImieTrenera = pro.Trener.FirstName,
                    NazwiskoTrenera = pro.Trener.LastName,
                    TelefonTrenera = pro.Trener.Telefon,
                    OpisUwag = pro.Uwaga.Opis
                }).ToList());
            }
            catch (Exception exc)
            {
                response = BadRequest("ERROR with geting Trener" + exc.StackTrace);
            }

            return response;

        }



    }
}