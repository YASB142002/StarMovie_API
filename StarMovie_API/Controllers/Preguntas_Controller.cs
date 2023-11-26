using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarMovie_API_Data.Repository;

namespace StarMovie_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Preguntas_Controller : ControllerBase
    {
        private readonly IPreguntasRepository _PreguntasRepository;
        public Preguntas_Controller(IPreguntasRepository PreguntasRepository)
        {
            _PreguntasRepository = PreguntasRepository;
        }
        [HttpGet]
        public async  Task<IActionResult> GetAllPreguntas()
        {
            return Ok();
        }
    }
}
