using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Entities
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set;}

        public ICollection<OrdenProducto> OrdenProductos { get; set; }

        public ICollection<ProductoMateriaPrima> ProductoMateriaPrimas { get; set; }
    }
}
