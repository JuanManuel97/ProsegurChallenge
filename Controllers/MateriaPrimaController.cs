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
    public class MateriaPrimaController : ControllerBase
    {
        private readonly AppDBContext _context;

        public MateriaPrimaController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<MateriaPrima>> CrearMateriaPrima(MateriaPrimaModel materiaPrima)
        {
            var materiaPrimaCreada = new MateriaPrima
            {
                Descripcion = materiaPrima.Descripcion,
                Cantidad = materiaPrima.Cantidad,
                DescripcionCantidad = materiaPrima.DescripcionCantidad,
                Precio = materiaPrima.Precio
            };
            _context.MateriaPrimas.Add(materiaPrimaCreada);
            await _context.SaveChangesAsync();

            return Ok(materiaPrima);
        }

        [HttpGet]
        public async Task<ActionResult<Rol>> ObtenerMateriaPrima(int idMateriaprima)
        {
            return Ok(await _context.MateriaPrimas.Where(mp => mp.IdMateriaPrima == idMateriaprima).ToListAsync());
        }
    }
}
