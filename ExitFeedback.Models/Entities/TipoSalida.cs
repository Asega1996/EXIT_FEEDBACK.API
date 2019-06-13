using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("TIPO_SALIDA")]
    public class TipoSalida : BaseEntity
    {
        [Key]
        [Column("TIPO_SALIDA_ID")]
        public int TipoSalidaId { get; set; }
        [Column("NOMBRE_TIPO_SALIDA")]
        public string NombreTipoSalida { get; set; }

    }
}
