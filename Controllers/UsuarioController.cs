using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProsegurChallenge.Data;
using ProsegurChallenge.Entities;
using ProsegurChallenge.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProsegurChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDBContext _context;

        public UsuarioController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> CrearUsuario([FromBody] CrearUsuarioModel usuario)
        {
            var usuarioCreado = new Usuario
            {
                Nombre = usuario.Nombre,
                IdRol = usuario.IdRol
            };
            _context.Usuarios.Add(usuarioCreado);
            await _context.SaveChangesAsync();

            return Ok(usuario);
        }

        [HttpGet]
        public async Task<ActionResult<Usuario>> ObtenerUsuario(int idUsuario)
        {
            return Ok(await _context.Usuarios.Where(u => u.IdUsuario == idUsuario).ToListAsync());
        }
    }
}
