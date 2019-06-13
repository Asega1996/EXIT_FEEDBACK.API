using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("SUBMOTIVO_SALIDA")]
    public class SubmotivoSalida : BaseEntity
    {
        [Key]
        [Column("SUBMOTIVO_ID")]
        public int SubmotivoId{ get; set; }
        [Column("FK_MOTIVO_ID")]
        public int MotivoSalidaId { get; set; }
        [Column("NOMBRE_SUBMOTIVO")]
        public string NombreSubmotivo { get; set; }

    }
}
