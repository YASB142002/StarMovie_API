using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarMovie_API_Data.Repository;
using StarMovie_API_Models;

namespace StarMovie_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatgPeli_Controller : ControllerBase
    {
        private readonly ICatgPeliRepository _CatgPeliRepository;
        public CatgPeli_Controller(ICatgPeliRepository CatgPeliRepository)
        {
            _CatgPeliRepository = CatgPeliRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GettAllCatgPeli()
        {
            return Ok(await _CatgPeliRepository.GetAllCatgPelis());
        }
        [HttpGet("{NombreCatg}")]
        public async Task<IActionResult> GetCatgPelis(string NombreCatg)
        {
            return Ok(await _CatgPeliRepository.GetCatgPeli(NombreCatg));
        }
        [HttpPost]
        public async Task<IActionResult> CreateCatgPeli([FromBody] CatgPeli CatgPeli)
        {
            if (CatgPeli == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();
            var created = await _CatgPeliRepository.InsertCatgPeli(CatgPeli);
            return Created("Created", created);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCatgPeli(string OldNombreCatg, [FromBody] CatgPeli CatgPeli)
        {
            if (string.IsNullOrEmpty(OldNombreCatg))
                return BadRequest("No puede ser null el username.");
            if (OldNombreCatg == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            await _CatgPeliRepository.UpdateCatgPeli(OldNombreCatg, CatgPeli);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCatgPeli(string NombreCatg)
        {
            if (!string.IsNullOrEmpty(NombreCatg))
                return BadRequest();
            await _CatgPeliRepository.DeleteCatgPeli(NombreCatg);
            return NoContent();
        }
    }
}
