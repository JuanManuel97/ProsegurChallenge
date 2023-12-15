using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Entities
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
