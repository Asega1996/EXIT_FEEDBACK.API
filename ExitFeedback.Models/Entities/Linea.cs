using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("LINEA")]
    public class Linea : BaseEntity
    {
        [Key]
        [Column("LINEA_ID")]
        public int LineaId { get; set; }
        [Column("NOMBRE_LINEA")]
        public string NombreLinea { get; set; }
    }
}
