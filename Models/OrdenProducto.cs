using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Models
{
    public class OrdenProducto
    {
        [Key, Column(Order = 1)]
        public int IdOrden { get; set; }

        [Key, Column(Order = 2)]
        public int IdProducto { get; set; }

        [ForeignKey("IdOrden")]
        public virtual Orden Orden { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }
    }
}
