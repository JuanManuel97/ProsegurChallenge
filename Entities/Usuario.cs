using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProsegurChallenge.Entities
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }

        [ForeignKey("Rol")]
        public int IdRol { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
