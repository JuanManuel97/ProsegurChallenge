using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set;}
    }
}
