﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProsegurChallenge.Entities
{
    public class EstadoOrden
    {
        [Key]
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Orden> Ordenes { get; set; }
    }
}
