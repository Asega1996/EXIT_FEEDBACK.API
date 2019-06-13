using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("MOTIVO_SALIDA")]
    public class MotivoSalida : BaseEntity
    {
        [Key]
        [Column("MOTIVO_SALIDA_ID")]
        public int MotivoSalidaId { get; set; }
        [Column("NOMBRE_MOTIVO_SALIDA")]
        public string NombreMotivoSalida { get; set; }
    }
}
