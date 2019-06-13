using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExitFeedback.Models.Entities
{
    [Table("TIEMPO_EN_PROYECTO")]
    public class TiempoEnProyecto : BaseEntity
    {
        [Key]
        [Column("TIEMPO_EN_PROYECTO_ID")]
        public int TiempoEnProyectoId { get; set; }
        [Column("NOMBRE_TIEMPO_EN_PROYECTO")]
        public string NombreTiempoEnProyecto { get; set; }
    }
}
