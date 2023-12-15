using System.ComponentModel.DataAnnotations.Schema;

namespace ProsegurChallenge.Models
{
    public class UsuarioModel
    {
        public string Nombre { get; set; }

        public int IdRol { get; set; }
    }
}
