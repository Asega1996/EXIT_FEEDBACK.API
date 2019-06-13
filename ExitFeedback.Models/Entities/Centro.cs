using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("CENTRO")]
    public class Centro : BaseEntity
    {
        [Key]
        [Column("CENTRO_ID")]
        public int CentroId { get; set; }
        [Column("NOMBRE_CENTRO")]
        public string NombreCentro{ get; set; }
    }
}
