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
    public class RolController : ControllerBase
    {
        private readonly AppDBContext _context;

        public RolController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Rol>> CrearRol(CrearRolModel rol)
        {
            var rolCreado = new Rol
            {
                Descripcion = rol.Descripcion
            };
            _context.Roles.Add(rolCreado);
            await _context.SaveChangesAsync();

            return Ok(rol);
        }

        [HttpGet]
        public async Task<ActionResult<Rol>> ObtenerRol(int idRol)
        {
            return Ok(await _context.Roles.Where(r => r.IdRol == idRol).ToListAsync());
        }
    }
}
