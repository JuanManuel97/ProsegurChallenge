using System.ComponentModel.DataAnnotations.Schema;

namespace ProsegurChallenge.Models
{
    public class OrdenModel
    {
        public string Descripcion { get; set; }
        public int IdEstado { get; set; }
    }
}
