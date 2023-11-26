using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarMovie_API_Data.Repository;
using StarMovie_API_Models;

namespace StarMovie_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Usuarios_Controller : ControllerBase
    {
        private readonly IUsuariosRepository _UsuarioRepository;
        public Usuarios_Controller(IUsuariosRepository UsuarioRepository)
        {
            _UsuarioRepository = UsuarioRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _UsuarioRepository.GetAllUsuarios());
        }
        [HttpGet("{username}")]
        public async Task<IActionResult> GetUserByUserName(string username)
        {
            return Ok(await _UsuarioRepository.GetUsuarioDetails(username));
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] Usuarios usuario)
        {
            if (usuario == null)
                return BadRequest();
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            var created = await _UsuarioRepository.InsertUsuario(usuario);
            return Created("Created",created);

        }
        [HttpPut]
        public async Task<IActionResult> UpddateUser(string Oldusername, [FromBody] Usuarios usuario)
        {
            if (string.IsNullOrEmpty(Oldusername))
                return BadRequest("No puede ser null el username.");
            if (usuario == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            await _UsuarioRepository.UpdateUsuario(Oldusername, usuario);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(string Username)
        {
            if (!string.IsNullOrEmpty(Username))
                return BadRequest("No puede ser null el username.");
            await _UsuarioRepository.DeleteUsuario(Username);
            return NoContent();
        }
    }
}
