
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hospital.Models.Entities;
using Hospital.Repository.Data;

namespace Hospital.Api.Controllers
{
    [Route("api/patients")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PatientsController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAllPatients()
        {
            var result = _context.Patients.ToList();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult GetSinglePatientnt([FromRoute] int id)
        {
            var result = _context.Patients.FirstOrDefault(x => x.Id == id);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletePatient([FromRoute] int id)
        {
            var patientToDelete = _context.Patients.FirstOrDefault(x => x.Id == id);
            _context.Patients.Remove(patientToDelete);
            _context.SaveChanges();

            return Ok();
        }


        [HttpPost]
        public IActionResult AddPatient([FromBody] Patient model)
        {
            _context.Patients.Add(model);
            _context.SaveChanges();

            return Ok();
        }


        [HttpPut]
        public IActionResult UpdatePatient([FromBody] Patient model)
        {
            var patientToUpdate = _context.Patients.FirstOrDefault(x => x.Id == model.Id);

            patientToUpdate.FullName = model.FullName;
            patientToUpdate.BirthDate = model.BirthDate;
            patientToUpdate.Email = model.Email;
            patientToUpdate.MedicalRecord = model.MedicalRecord;
            patientToUpdate.Appointments = model.Appointments;

            _context.Patients.Update(patientToUpdate);
            _context.SaveChanges();

            return Ok();
        }
    }
}
