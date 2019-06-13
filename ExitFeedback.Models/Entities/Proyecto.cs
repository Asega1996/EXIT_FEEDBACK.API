using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExitFeedback.Models.Entities
{
    [Table("PROYECTO")]
    public class Proyecto : BaseEntity
    {
        [Key]
        [Column("PROYECTO_ID")]
        public int ProyectoId { get; set; }
        [Column("NOMBRE_PROYECTO")]
        public string NombreProyecto { get; set; }
    }
}
