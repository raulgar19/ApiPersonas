using ApiPersonas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiPersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPersonas()
        {
            List<Persona> personas = new List<Persona>();

            return Ok(personas);
        }
    }
}