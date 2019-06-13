using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("TIPO_EMPRESA")]
    public class TipoEmpresa : BaseEntity
    {
        [Key]
        [Column("TIPO_EMPRESA_ID")]
        public int TipoEmpresaId { get; set; }
        [Column("NOMBRE_TIPO_EMPRESA")]
        public string NombreTipoEmpresa { get; set; }

    }
}
