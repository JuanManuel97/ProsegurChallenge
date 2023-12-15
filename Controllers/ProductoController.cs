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
    public class ProductoController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ProductoController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Producto>> CrearProducto(ProductoModel producto)
        {
            var productoCreado = new Producto
            {
                Descripcion = producto.Descripcion,
                PrecioVenta = producto.PrecioVenta
            };
            _context.Productos.Add(productoCreado);
            await _context.SaveChangesAsync();

            return Ok(producto);
        }

        [HttpGet]
        public async Task<ActionResult<Producto>> ObtenerProducto(int idProducto)
        {
            return Ok(await _context.Productos.Where(p => p.IdProducto == idProducto).ToListAsync());
        }
    }
}
