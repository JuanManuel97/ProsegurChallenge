using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Entities
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set;}
    }
}
