using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("DATO_EMPLEADO")]
    public class DatoEmpleado : BaseEntity
    {
        [Key]
        [Column("DATO_EMPLEADO_ID")]
        public int DatoEmpleadoId { get; set; }
        [Column("CARRERA_ID")]
        public int CarreraId { get; set; }
        [Column("TECNOLOGIA_ID")]
        public int TecnologiaId { get; set; }
        [Column("TITULACION_ID")]
        public int TitulacionId { get; set; }
        [Column("NUM_EMPLEADO")]
        public int NumEmpleado { get; set; }
        [Column("TITULACION_TIPIFICADA_ID")]
        public int TitulacionTipificadaId { get; set; }
        [Column("PROYECTO_ID")]
        public int ProyectoId { get; set; }
        [Column("TIEMPO_PROYECTO_ID")]
        public int TiempoProyectoId { get; set; }
        [Column("SUPERVISOR")]
        public string Supervisor { get; set; }
        [Column("TUTOR")]
        public string Tutor { get; set; }

    }
}
