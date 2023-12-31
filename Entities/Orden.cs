﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProsegurChallenge.Entities
{
    public class Orden
    {
        [Key]
        public int IdOrden { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Estado")]
        public int IdEstado { get; set; }

        public virtual EstadoOrden Estado { get; set; }

        public ICollection<OrdenProducto> OrdenProductos { get; set; }
    }
}
