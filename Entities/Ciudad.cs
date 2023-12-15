using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Entities
{
    public class Ciudad
    {
        [Key]
        public int IdCiudad { get; set; }
        public string Nombre { get; set; }
        public decimal PorcentajeImpuesto { get; set; } = 0;
    }
}
