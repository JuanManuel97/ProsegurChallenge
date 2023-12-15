using System.ComponentModel.DataAnnotations.Schema;

namespace ProsegurChallenge.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Rol")]
        public int IdRol { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
