using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("TIPO_BUSQUEDA")]
    public class TipoBusqueda : BaseEntity
    {
        [Key]
        [Column("TIPO_BUSQUEDA_ID")]
        public int TipoBusquedaId { get; set; }
        [Column("NOMBRE_TIPO_BUSQUEDA")]
        public string NombreTipoBusqueda { get; set; }
    }
}
