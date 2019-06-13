using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("CARRERA")]
    public class Carrera : BaseEntity
    {
        [Key]
        [Column("CARRERA_ID")]
        public int CarreraId { get; set; }
        [Column("NOMBRE_CARRERA")]
        public string NombreCarrera { get; set; }
    }
}
