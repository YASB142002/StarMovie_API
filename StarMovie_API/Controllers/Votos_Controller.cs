using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarMovie_API_Data.Repository;
using StarMovie_API_Models;

namespace StarMovie_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Votos_Controller : ControllerBase
    {
        private readonly IVotosRepository _VotosRepository;
        public Votos_Controller(IVotosRepository VotosRepository)
        {
            _VotosRepository = VotosRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllVotos() 
        {
            return Ok(await _VotosRepository.GetAllVotos());
        }
        [HttpGet("{Id_Voto}")]
        public async Task<IActionResult> GetVotosDetails(int Id_Voto)
        {
            return Ok(await _VotosRepository.GetVotosDetails(Id_Voto));
        }
        [HttpPost]
        public async Task<IActionResult> CreateVoto([FromBody] Votos Voto)
        {
            if (Voto == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();
            var created = await _VotosRepository.InsertVoto(Voto);
            return Created("Created new voto", created);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateVotos([FromBody] Votos voto)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _VotosRepository.UpdateVoto(voto);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteVoto(int Id_Voto)
        {
            if(Id_Voto == 0)
                return BadRequest();
            await _VotosRepository.DeleteVoto(Id_Voto);
            return NoContent();
        }
    }
}
