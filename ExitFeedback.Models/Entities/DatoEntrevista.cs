using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("DATO_ENTREVISTA")]
    public class DatoEntrevista : BaseEntity
    {
        [Key]
        [Column("DATO_ENTREVISTA_ID")]
        public int DatoEntrevistaId { get; set; }
        [Column("COMENTARIO_ENTREVISTADOR")]
        public string ComentarioEntrevistador { get; set; }
        [Column("INFORMACION_SUPERVISOR")]
        public string InformacionSupervisor { get; set; }
        [Column("FECHA_ENTREVISTA")]
        public DateTime FechaEntrevista { get; set; }
        [Column("NOMBRE_ENTREVISTADOR")]
        public string NombreEntrevistador { get; set; }

    }
}
