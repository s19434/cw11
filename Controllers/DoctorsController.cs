using System;
using System.Linq;
using APBD.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD.Controllers
{
    [Route("api/Treners")]
    [ApiController]
    public class TrenersController : ControllerBase
    {
        private readonly PrescriptionDbContext _context;

        public TrenersController(PrescriptionDbContext context)
        {
            _context = context;
        }

        [HttpGet("get/{index}")]
        public IActionResult GetTrener(int index)
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Treners.First(Trener => Trener.IdTrener == index));
            }
            catch (Exception exc)
            {
                response = BadRequest("ERROR with geting Trener" + exc.StackTrace);
            }

            return response;

        }

        [HttpPost("add")]
        public IActionResult AddTrener(Trener Trener)

        {
            IActionResult response;
            try
            {
                _context.Treners.Add(Trener);
                _context.SaveChanges();

                response = Ok(Trener);
            }
            catch (Exception exc)
            {
                response = BadRequest("ERROR with adding Trener" + exc.StackTrace);
            }

            return response;
        }

        [HttpPut("modify")]
        public IActionResult ModifyTrener(Trener Trener)
        {
            IActionResult response;
            try
            {
                _context.Treners.Update(Trener);
                _context.SaveChanges();
                response = Ok(Trener);
            }
            catch (Exception exc)
            {
                response = BadRequest("ERROR with modifying Trener" + exc.StackTrace);
            }
            return response;
        }

        [HttpDelete("delete/{index}")]
        public IActionResult DeleteTrener(int index)
        {
            IActionResult response;
            try
            {
                var Trener = _context.Treners.First(doc => doc.IdTrener == index);
                _context.Treners.Remove(Trener);
                _context.SaveChanges();
            }
            catch (Exception exc)
            {
                response = BadRequest("ERROR with deleting Trener" + exc.StackTrace);
            }
            return NoContent();
        }

    }
}