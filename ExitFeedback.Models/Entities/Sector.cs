using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("SECTOR")]
    public class Sector : BaseEntity
    {
        [Key]
        [Column("SECTOR_ID")]
        public int SectorId { get; set; }
        [Column("NOMBRE_SECTOR")]
        public string NombreSector { get; set; }
    }
}
