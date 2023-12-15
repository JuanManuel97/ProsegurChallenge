using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProsegurChallenge.Data;
using ProsegurChallenge.Entities;
using ProsegurChallenge.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProsegurChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoOrdenController : ControllerBase
    {
        private readonly AppDBContext _context;

        public EstadoOrdenController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<EstadoOrden>> CrearEstadoOrden(EstadoOrdenModel estadoOrden)
        {
            var estadoOrdenCreado = new EstadoOrden
            {
                Descripcion = estadoOrden.Descripcion
            };
            _context.EstadoOrdenes.Add(estadoOrdenCreado);
            await _context.SaveChangesAsync();

            return Ok(estadoOrden);
        }
        
    }
}
