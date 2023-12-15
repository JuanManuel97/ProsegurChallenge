using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Models
{
    public class ProductoMateriaPrima
    {
        [Key, Column(Order = 1)]
        public int IdProducto { get; set; }

        [Key, Column(Order = 2)]
        public int IdMateriaPrima { get; set; }

        public decimal CantidadPorUnidad { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual MateriaPrima MateriaPrima { get; set; }
    }
}
