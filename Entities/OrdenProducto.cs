using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Entities
{
    public class OrdenProducto
    {
        [Column(Order = 1)]
        public int IdOrden { get; set; }

        [Column(Order = 2)]
        public int IdProducto { get; set; }

        [ForeignKey("IdOrden")]
        public virtual Orden Orden { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }
    }
}
