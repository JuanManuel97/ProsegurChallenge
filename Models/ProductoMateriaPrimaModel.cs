using System.ComponentModel.DataAnnotations.Schema;

namespace ProsegurChallenge.Models
{
    public class ProductoMateriaPrimaModel
    {
        public int IdProducto { get; set; }
        public int IdMateriaPrima { get; set; }
        public decimal CantidadPorUnidad { get; set; }
    }
}
