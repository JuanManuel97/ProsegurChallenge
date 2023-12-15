using System.ComponentModel.DataAnnotations.Schema;

namespace ProsegurChallenge.Models
{
    public class OrdenProductoModel
    {
        public int IdOrden { get; set; }
        public int IdProducto { get; set; }
        public decimal CantidadProducto { get; set; }
    }
}
