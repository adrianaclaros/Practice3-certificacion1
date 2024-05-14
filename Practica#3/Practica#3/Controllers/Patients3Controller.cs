using Microsoft.AspNetCore.Mvc;
using Patient3Manager;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Patients3Controller : ControllerBase
    {
        private readonly PatientM _patientM;

        public Patients3Controller(PatientM patientM)
        {
            _patientM = patientM;
        }

        [HttpPost]
        public IActionResult GeneratePatientCode([FromBody] Patient3 patient3)
        {
            string code = _patientM.GeneratePatientCode(patient3.Name, patient3.LastName, patient3.CI);
            return Ok(new { PatientCode = code });
        }

    }
}
