using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("INCREMENTO_SALARIAL")]
    public class IncrementoSalarial : BaseEntity
    {
        [Key]
        [Column("INCREMENTO_ID")]
        public int IncrementoId { get; set; }
        [Column("INCREMENTO_VALOR")]
        public string IncrementoValor { get; set; }
    }
}
