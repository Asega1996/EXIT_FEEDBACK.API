using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("CELDA")]
    public class Celda : BaseEntity
    {
        [Key]
        [Column("CELDA_ID")]
        public int CeldaId { get; set; }
        [Column("NOMBRE")]
        public string NombreCelda { get; set; }
    }
}
