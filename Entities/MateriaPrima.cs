using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Entities
{
    public class MateriaPrima
    {
        [Key]
        public int IdMateriaPrima { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; } = 0;
        public string DescripcionCantidad { get; set; }
        public decimal Precio { get; set; } = 0;

        public ICollection<ProductoMateriaPrima> ProductoMateriaPrimas { get; set; }
    }
}
