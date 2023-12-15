using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Models
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }
        public string Descripcion { get; set; }
    }
}
