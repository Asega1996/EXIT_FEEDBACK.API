using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("TITULACION")]
    public class Titulacion : BaseEntity
    {
        [Key]
        [Column("TITULACION_ID")]
        public int TitulacionId { get; set; }
        [Column("NOMBRE_TITULACION")]
        public string NombreTitulacion { get; set; }
    }
}
