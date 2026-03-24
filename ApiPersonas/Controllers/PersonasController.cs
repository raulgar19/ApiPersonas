using ApiPersonas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiPersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private List<Persona> personas;

        public PersonasController()
        {
            this.personas = new List<Persona>
            {
                new Persona
                {
                    IdPersona = 1,
                    Nombre = "Lucia",
                    Email = "lucia@gmail.com",
                    Edad = 42
                },
                new Persona
                {
                    IdPersona = 2,
                    Nombre = "Carlos",
                    Email = "carlos@example.com",
                    Edad = 35
                },
                new Persona
                {
                    IdPersona = 3,
                    Nombre = "Maria",
                    Email = "maria@example.com",
                    Edad = 28
                },
                new Persona
                {
                    IdPersona = 4,
                    Nombre = "Javier",
                    Email = "javier@example.com",
                    Edad = 50
                }
            };
        }

        [HttpGet]
        public ActionResult<List<Persona>> Get()
        {
            return personas;
        }

        [HttpGet("{id}")]
        public ActionResult<Persona> Find(int id)
        {
            return this.personas.FirstOrDefault(z => z.IdPersona == id);
        }
    }
}