using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("REGISTRO")]
    public class Registro : BaseEntity
    {
        [Key]
        [Column("REGISTRO_ID")]
        public int RegistroId { get; set; }
        [Column("FK_EMPLEADO_ID")]
        public int EmpleadoId { get; set; }
        [Column("FK_DATOS_EMPLEADO_ID")]
        public int? DatosEmpleadoId { get; set; }
        [Column("FK_DATOS_CALIFICAIONES_ID")]
        public int? DatosCalificacionesId { get; set; }
        [Column("FK_DATOS_SALIDA_ID")]
        public int? DatosSalidaId { get; set; }
        [Column("FK_DATOS_ENTREVISTA_ID")]
        public int? DatosEntrevistaId { get; set; }
        [Column("FK_STATUS")]
        public int Status { get; set; }
    }
}
