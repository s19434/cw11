using System;
using System.Linq;
using APBD.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly PrescriptionDbContext _context;

        public DoctorsController(PrescriptionDbContext context)
        {
            _context = context;
        }

        [HttpGet("get/{index}")]
        public IActionResult GetDoctor(int index)
        {
            IActionResult response;
            try
            {
                response = Ok(_context.Doctors.First(doctor => doctor.IdDoctor == index));
            }
            catch (Exception exc)
            {
                response = BadRequest("ERROR with geting doctor" + exc.StackTrace);
            }

            return response;

        }

        [HttpPost("add")]
        public IActionResult AddDoctor(Doctor doctor)

        {
            IActionResult response;
            try
            {
                _context.Doctors.Add(doctor);
                _context.SaveChanges();

                response = Ok(doctor);
            }
            catch (Exception exc)
            {
                response = BadRequest("ERROR with adding doctor" + exc.StackTrace);
            }

            return response;
        }

        [HttpPut("modify")]
        public IActionResult ModifyDoctor(Doctor doctor)
        {
            IActionResult response;
            try
            {
                _context.Doctors.Update(doctor);
                _context.SaveChanges();
                response = Ok(doctor);
            }
            catch (Exception exc)
            {
                response = BadRequest("ERROR with modifying doctor" + exc.StackTrace);
            }
            return response;
        }

        [HttpDelete("delete/{index}")]
        public IActionResult DeleteDoctor(int index)
        {
            IActionResult response;
            try
            {
                var doctor = _context.Doctors.First(doc => doc.IdDoctor == index);
                _context.Doctors.Remove(doctor);
                _context.SaveChanges();
            }
            catch (Exception exc)
            {
                response = BadRequest("ERROR with deleting doctor" + exc.StackTrace);
            }
            return NoContent();
        }

    }
}