using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Models
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }
    }
}
