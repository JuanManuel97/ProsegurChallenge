using System.ComponentModel.DataAnnotations.Schema;

namespace ProsegurChallenge.Models
{
    public class Orden
    {
        public int IdOrden { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Estado")]
        public int IdEstado { get; set; }

        public virtual Estado Estado { get; set; }
    }
}
