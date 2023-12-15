using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Entities
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }
    }
}
