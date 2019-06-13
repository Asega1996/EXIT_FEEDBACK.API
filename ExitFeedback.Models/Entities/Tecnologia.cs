using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("TECNOLOGIA")]
    public class Tecnologia : BaseEntity
    {
        [Key]
        [Column("TECNOLOGIA_ID")]
        public int TecnologiaId { get; set; }
        [Column("NOMBRE_TECNOLOGIA")]
        public string NombreTecnologia { get; set; }
    }
}
